// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal
{
    using System.IO;
    using System.Text.Json.Nodes;
    using System.Windows;

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

            var r = new StreamReader("../../../TestJSON/testMedia.json");
            var data = r.ReadToEnd();

            var jsonOBJ = JsonObject.Parse(data);
            var myArray = (JsonArray)jsonOBJ["Media"];

            Console.WriteLine("Hello");
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