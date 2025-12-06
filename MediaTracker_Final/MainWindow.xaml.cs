// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal
{
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
            var test = Multiply(2, 10);
            MessageBox.Show($"{test}");
        }

        /// <summary>
        /// Sample Documentation.
        /// </summary>
        /// <param name="x">The first value to multiply.</param>
        /// <param name="y">Second value to multiply.</param>
        /// <returns>The X and Y values multiplied.</returns>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}