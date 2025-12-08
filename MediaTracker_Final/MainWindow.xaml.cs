// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.IO;
    using System.Text.Json;
    using System.Text.Json.Nodes;
    using System.Text.Json.Serialization;
    using System.Windows;
    using MediaTrackerFinal.CommandPattern.Commands;
    using MediaTrackerFinal.InterfaceHandling;
    using MediaTrackerFinal.JsonObjectHandling;
    using MediaTrackerFinal.MediaObject;
    using MediaTrackerFinal.MediaObject.MediaFactory;
    using MediaTrackerFinal.Singleton;

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
            this.InitializeComponent();

            var userMediaAccesser = new UserMediaAccessor();
            this.medias = userMediaAccesser.Medias;

            this.MediaListBox.ItemsSource = this.medias;

            var test = GetTimesFromMedia.HoursMinSecFromMedia(90670);
            Console.WriteLine("hi");
        }

        private void HightPriority_Click(object sender, RoutedEventArgs e)
        {
            var highPriorityCommand = new SortByHighestPriorityCommand(this.medias);
            highPriorityCommand.Execute();
        }

        private void LeastPriority_Click(object sender, RoutedEventArgs e)
        {
            var lowPriorityCommand = new SortByLowestPriorityCommand(this.medias);
            lowPriorityCommand.Execute();
        }

        private void MostWatched_Click(object sender, RoutedEventArgs e)
        {
            var sortbyMostWatched = new SortByMostWatchedCommand(this.medias);
            sortbyMostWatched.Execute();
        }

        private void LeastWatched_Click(object sender, RoutedEventArgs e)
        {
            var sortbyLeastWatched = new sortByLeastWatchedCommand(this.medias);
            sortbyLeastWatched.Execute();
        }

        private void AddMedia_Click(object sender, RoutedEventArgs e)
        {
            var addMediaWindow = new AddMediaWindow(this.medias);

            addMediaWindow.ShowDialog();

            this.medias.Add(addMediaWindow.MediaGettingAdded);
        }

        private void RemoveMedia_Click(object sender, RoutedEventArgs e)
        {
            Media mediaSelected = (Media)this.MediaListBox.SelectedItem;
            this.medias.Remove(mediaSelected);

            this.MediaListBox.SelectedIndex += 1;
        }

        private void EditMedia_Click(object sender, RoutedEventArgs e)
        {
            var editMediaWindow = new EditMediaConsumedWindow((Media)this.MediaListBox.SelectedItem);

            editMediaWindow.ShowDialog();

            this.MediaListBox.Items.Refresh();
            this.MediaListBox.SelectedIndex += 1;
            this.MediaListBox.SelectedIndex -= 1;
        }

        private void MediaListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var windowTextChangeHandler = new InterfaceHandler(this, this.MediaListBox, this.PriorityText, this.MediaName, this.MediaCreator, this.MediaType, this.MediaSource, this.MediaConsumed);

            Media mediaSelected = (Media)this.MediaListBox.SelectedItem;

            if (mediaSelected != null)
            {
                windowTextChangeHandler.ChangePriorityNumber(mediaSelected.PriorityNumber);
                windowTextChangeHandler.ChangeMediaName(mediaSelected.Name);
                windowTextChangeHandler.ChangeMediaCreator(mediaSelected.Creator);
                windowTextChangeHandler.ChangeMediaSource(mediaSelected.Source);
                windowTextChangeHandler.ChangeMediaType(mediaSelected.MediaType.ToString());
                windowTextChangeHandler.ChangeMediaConsumed($"{mediaSelected.GetMediaConsumedDisplay().ToString()}% Consumed");
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            WriteToJSON.WriteMediaToJsonFile("../../../TestJSON/testMedia.json", this.medias);
        }
    }
}