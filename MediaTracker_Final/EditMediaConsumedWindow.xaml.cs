// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal
{
    using System.Configuration;
    using System.Windows;
    using MediaTrackerFinal.MediaObject;

    /// <summary>
    /// Interaction logic for EditMediaConsumedWindow.xaml.
    /// </summary>
    public partial class EditMediaConsumedWindow : Window
    {
        private Media mediaGettingEdited;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditMediaConsumedWindow"/> class.
        /// This is a window that can change how much user has consumed their media.
        /// </summary>
        /// <param name="mediaEditing">Media getting edit.</param>
        public EditMediaConsumedWindow(Media mediaEditing)
        {
            this.InitializeComponent();

            this.mediaGettingEdited = mediaEditing;

            var times = GetTimesFromMedia.HoursMinSecFromMedia(this.mediaGettingEdited.MediaLength);

            this.DurationDisplayText.Text = $"Hours: {times[0]}, Minutes: {times[1]}, Seconds: {times[2]}";

            for (int i = 0; i <= times[0]; i++)
            {
                this.hoursComboBox.Items.Add(i.ToString());
            }

            for (int i = 0; i <= 60; i++)
            {
                this.minutesComboBox.Items.Add(i.ToString());
                this.secondsComboBox.Items.Add(i.ToString());
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            bool h = int.TryParse(this.hoursComboBox.SelectedValue?.ToString(), out int hoursInput);
            bool m = int.TryParse(this.minutesComboBox.SelectedValue?.ToString(), out int minutesInput);
            bool s = int.TryParse(this.secondsComboBox.SelectedValue?.ToString(), out int secondsInput);

            hoursInput = hoursInput * 3600;
            minutesInput = minutesInput * 60;

            if ((hoursInput + minutesInput + secondsInput) > this.mediaGettingEdited.MediaLength)
            {
                MessageBox.Show("You input a time longer than the video length please try again.");
                return;
            }

            this.mediaGettingEdited.MediaConsumed = hoursInput + minutesInput + secondsInput;

            this.Close();
        }
    }
}
