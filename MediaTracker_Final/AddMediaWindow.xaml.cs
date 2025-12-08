// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal
{
    using System.Collections.ObjectModel;
    using System.Windows;
    using MediaTrackerFinal.MediaObject;
    using MediaTrackerFinal.MediaObject.MediaFactory;

    /// <summary>
    /// Interaction logic for AddMediaWindow.xaml.
    /// </summary>
    public partial class AddMediaWindow : Window
    {
        private ObservableCollection<Media> medias;

        private Media mediaGettingAdded;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMediaWindow"/> class.
        /// </summary>
        /// <param name="mediaList">The list of media getting a media object added into.</param>
        /// <param name="mediaBeingAdded">This is the media that will be added into the list box.</param>
        public AddMediaWindow(ObservableCollection<Media> mediaList)
        {
            this.medias = mediaList;

            this.InitializeComponent();

            // Populating the combo boxes...
            this.mediaTypeComboBox.Items.Add("Movie");
            this.mediaTypeComboBox.Items.Add("Podcast");
            this.mediaTypeComboBox.Items.Add("Lecture");
            this.mediaTypeComboBox.Items.Add("Video");

            for (int i = 0; i <= 100; i++)
            {
                var numberToAdd = i.ToString();
                if (i > 0)
                {
                    this.PriorityNumberComboBox.Items.Add(numberToAdd);
                }

                this.durationHoursComboBox.Items.Add(numberToAdd);

                this.consumedHoursComboBox.Items.Add(numberToAdd);
            }

            // -1 is NOT A VALID INPUT, however is what I set it to if user attempts to add media with duplicate priority number.
            this.PriorityNumberComboBox.Items.Add(-1);

            for (int i = 0; i <= 60; i++)
            {
                var numberToAdd = i.ToString();
                this.durationSecondsComboBox.Items.Add(numberToAdd);
                this.durationMinutesComboBox.Items.Add(numberToAdd);

                this.consumedSecondsComboBox.Items.Add(numberToAdd);
                this.consumedMinutesComboBox.Items.Add(numberToAdd);
            }
        }

        /// <summary>
        /// Gets the media getting added from the add media window.
        /// </summary>
        public Media MediaGettingAdded { get => this.mediaGettingAdded; }

        /// <summary>
        /// Converts the hours, minutes, and seconds input into one big second value.
        /// </summary>
        /// <param name="hours">The hours length of media.</param>
        /// <param name="minutes">The minutes length of media.</param>
        /// <param name="seconds">The seconsd length of media.</param>
        /// <returns>Media time converted into seconds.</returns>
        private static int GetMediaLength(int hours = 0, int minutes = 0, int seconds = 0)
        {
            int mediaLengthInSeconds = 0;

            if (hours != 0)
            {
                mediaLengthInSeconds += hours * 60 * 60;
            }

            if (minutes != 0)
            {
                mediaLengthInSeconds += minutes * 60;
            }

            if (seconds != 0)
            {
                mediaLengthInSeconds += seconds;
            }

            return mediaLengthInSeconds;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.PriorityNumberComboBox.SelectedItem == null || this.PriorityNumberComboBox.SelectedItem.ToString() == "-1")
            {
                MessageBox.Show("Please choose a valid priority number.");
                return;
            }
            else if (this.mediaTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please choose a media type.");
                return;
            }
            else if (this.titleInputBox == null)
            {
                MessageBox.Show("Please put in a title for your media.");
                return;
            }

            var userMediaSelection = this.mediaTypeComboBox.SelectedValue.ToString();

            var priorityNum = int.Parse(this.PriorityNumberComboBox.SelectedValue.ToString());
            var name = this.titleInputBox.Text;
            var creator = this.creatorInputBox.Text;
            var source = this.sourceInputBox.Text;

            // Getting the length of the media...
            var h = int.TryParse(this.consumedHoursComboBox.SelectedValue.ToString(), out int consumedHours);
            var m = int.TryParse(this.consumedMinutesComboBox.SelectedValue.ToString(), out int consumedMinutes);
            var s = int.TryParse(this.consumedSecondsComboBox.SelectedValue.ToString(), out int consumedSeconds);

            var consumedLength = GetMediaLength(consumedHours, consumedMinutes, consumedSeconds);

            var durationHours = int.Parse(this.durationHoursComboBox.SelectedValue.ToString());
            var durationMinutes = int.Parse(this.durationMinutesComboBox.SelectedValue.ToString());
            var durationSeconds = int.Parse(this.durationSecondsComboBox.SelectedValue.ToString());

            var durationLength = GetMediaLength(durationHours, durationMinutes, durationSeconds);

            // Making the media...
            switch (userMediaSelection)
            {
                case "Movie":
                    this.mediaGettingAdded = MediaFactory.CreateMedia(priorityNum, name, creator, MediaTypes.Movie, source, consumedLength, durationLength);
                    break;
                case "Podcast":
                    this.mediaGettingAdded = MediaFactory.CreateMedia(priorityNum, name, creator, MediaTypes.Podcast, source, consumedLength, durationLength);
                    break;
                case "Lecture":
                    this.mediaGettingAdded = MediaFactory.CreateMedia(priorityNum, name, creator, MediaTypes.Lecture, source, consumedLength, durationLength);
                    break;
                case "Video":
                    this.mediaGettingAdded = MediaFactory.CreateMedia(priorityNum, name, creator, MediaTypes.Video, source, consumedLength, durationLength);
                    break;
            }

            this.Close();
        }

        private void PriorityNumberComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            foreach (var m in this.medias)
            {
                if (m.PriorityNumber.ToString() == this.PriorityNumberComboBox.SelectedValue.ToString())
                {
                    MessageBox.Show($"You already have a piece of media with this priority number. \n{m.ToString()}\nPlease choose a different number");
                    this.PriorityNumberComboBox.SelectedValue = -1;
                    break;
                }
            }
        }
    }
}
