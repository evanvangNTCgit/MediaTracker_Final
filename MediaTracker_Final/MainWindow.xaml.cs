// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal
{
    using System.Collections.ObjectModel;
    using System.Windows;
    using MediaTrackerFinal.InterfaceHandling;
    using MediaTrackerFinal.MediaObject;
    using MediaTrackerFinal.MediaObject.MediaFactory;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
         * Okay so we use an observable collection so that way changes here get shown in the UI.
         */
        private ObservableCollection<Media> medias = new ObservableCollection<Media>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            /*
             * TODO
             * Make the window to edit and add media object.
             * And the JSON file so user can open and close without their data being lost.
             */
            this.InitializeComponent();

            var test = MediaFactory.CreateMedia(1, "Wausau", "Evan", MediaTypes.Movie, "Youtube", 100, 1000);

            this.medias.Add(test);

            test = MediaFactory.CreateMedia(2, "Toy Story", "Disney", MediaTypes.Video, "Disney Plus", 500, 5550);

            this.medias.Add(test);

            test = MediaFactory.CreateMedia(3, "Interstellar", "Christopher Nolan", MediaTypes.Video, "Netflix", 650, 5000);

            this.medias.Add(test);

            this.MediaListBox.ItemsSource = this.medias;
        }

        private void HightPriority_Click(object sender, RoutedEventArgs e)
        {
            var windowTextChangeHandler = new InterfaceHandler(this, this.MediaListBox, this.PriorityText, this.MediaName, this.MediaCreator, this.MediaType, this.MediaSource, this.MediaConsumed);
        }

        private void LeastPriority_Click(object sender, RoutedEventArgs e)
        {
            var windowTextChangeHandler = new InterfaceHandler(this, this.MediaListBox, this.PriorityText, this.MediaName, this.MediaCreator, this.MediaType, this.MediaSource, this.MediaConsumed);
        }

        private void MostWatched_Click(object sender, RoutedEventArgs e)
        {
            var windowTextChangeHandler = new InterfaceHandler(this, this.MediaListBox, this.PriorityText, this.MediaName, this.MediaCreator, this.MediaType, this.MediaSource, this.MediaConsumed);
        }

        private void LeastWatched_Click(object sender, RoutedEventArgs e)
        {
            var windowTextChangeHandler = new InterfaceHandler(this, this.MediaListBox, this.PriorityText, this.MediaName, this.MediaCreator, this.MediaType, this.MediaSource, this.MediaConsumed);
        }

        private void AddMedia_Click(object sender, RoutedEventArgs e)
        {
            // Its okay for null here because I will enforce the user to provide proper fields.
            var addMediaWindow = new AddMediaWindow(this.medias);

            addMediaWindow.ShowDialog();

            this.medias.Add(addMediaWindow.MediaGettingAdded);
        }

        private void RemoveMedia_Click(object sender, RoutedEventArgs e)
        {
            var windowTextChangeHandler = new InterfaceHandler(this, this.MediaListBox, this.PriorityText, this.MediaName, this.MediaCreator, this.MediaType, this.MediaSource, this.MediaConsumed);
        }

        private void EditMedia_Click(object sender, RoutedEventArgs e)
        {
            var windowTextChangeHandler = new InterfaceHandler(this, this.MediaListBox, this.PriorityText, this.MediaName, this.MediaCreator, this.MediaType, this.MediaSource, this.MediaConsumed);
        }

        private void MediaListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var windowTextChangeHandler = new InterfaceHandler(this, this.MediaListBox, this.PriorityText, this.MediaName, this.MediaCreator, this.MediaType, this.MediaSource, this.MediaConsumed);

            Media mediaSelected = (Media)this.MediaListBox.SelectedItem;

            windowTextChangeHandler.ChangePriorityNumber(mediaSelected.PriorityNumber);
            windowTextChangeHandler.ChangeMediaName(mediaSelected.Name);
            windowTextChangeHandler.ChangeMediaCreator(mediaSelected.Creator);
            windowTextChangeHandler.ChangeMediaSource(mediaSelected.Source);
            windowTextChangeHandler.ChangeMediaType(mediaSelected.MediaType.ToString());
            windowTextChangeHandler.ChangeMediaConsumed($"%{mediaSelected.GetMediaConsumedDisplay().ToString()} Consumed");
        }
    }
}