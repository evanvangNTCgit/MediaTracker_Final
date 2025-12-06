// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal
{
    using System.Text.Json.Nodes;
    using System.Windows;
    using MediaTrackerFinal.InterfaceHandling;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            var mediaGetter = new UserMediaAccessor();

            var windowTextChangHandler = new InterfaceHandler(this, this.MediaListBox, this.PriorityText, this.MediaName, this.MediaCreator, this.MediaType, this.MediaSource, this.MediaConsumed);

            var test = mediaGetter.GetMediaArray();

            foreach (var testItem in test)
            {
                var displayText = $"{testItem["Media Name"]} \n  By: {testItem["Media Creator"]}";
                this.MediaListBox.Items.Add(displayText);
            }

            Console.WriteLine("hi");
        }

        private void HightPriority_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LeastPriority_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MostWatched_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LeastWatched_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddMedia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveMedia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditMedia_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}