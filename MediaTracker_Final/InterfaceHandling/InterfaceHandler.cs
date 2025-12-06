// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal.InterfaceHandling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Controls;

    /// <summary>
    /// This class will act as an interface handler.
    /// Taking text for each of its methods to display into the WPF UI.
    /// </summary>
    public class InterfaceHandler
    {
        private MainWindow window;

        private ListBox mediaListBox;

        private TextBlock priorityText;

        private TextBlock mediaName;

        private TextBlock mediaCreator;

        private TextBlock mediaType;

        private TextBlock mediaSource;

        private TextBlock mediaConsumed;

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceHandler"/> class.
        /// Constructor for the interface Handler.
        /// Requires an interface and numerous textboxes to edit.
        /// </summary>
        /// <param name="mainWindow">Mainwindow to edit.</param>
        /// <param name="mediaListBox">Media List box to edit.</param>
        /// <param name="priorityText">Priority Text to edit.</param>
        /// <param name="mediaName">Media Text to edit.</param>
        /// <param name="mediaCreator">Media Creator Text to edit.</param>
        /// <param name="mediaType">Media Type Text to edit.</param>
        /// <param name="mediaSource">Media Source Text to edit.</param>
        /// <param name="mediaConsumed">Media Consumed Text to edit.</param>
        public InterfaceHandler(MainWindow mainWindow, ListBox mediaListBox, TextBlock priorityText, TextBlock mediaName, TextBlock mediaCreator, TextBlock mediaType, TextBlock mediaSource, TextBlock mediaConsumed)
        {
            this.window = mainWindow;

            this.mediaListBox = mediaListBox;

            this.priorityText = priorityText;

            this.mediaName = mediaName;

            this.mediaCreator = mediaCreator;

            this.mediaType = mediaType;

            this.mediaSource = mediaSource;

            this.mediaConsumed = mediaConsumed;
        }

        /// <summary>
        /// Changes the priority number shown on user display.
        /// </summary>
        /// <param name="number">Number to change priority to.</param>
        public void ChangePriorityNumber(int number)
        {
            this.priorityText.Text = $"Priority: {number}";
        }

        /// <summary>
        /// Changes the name of media on the interface.
        /// </summary>
        /// <param name="mediaName">Name to change media name to.</param>
        public void ChangeMediaName(string mediaName)
        {
            this.mediaName.Text = mediaName;
        }

        /// <summary>
        /// Changes the media creator on the interface.
        /// </summary>
        /// <param name="mediaCreator">Creator to change media creator to.</param>
        public void ChangeMediaCreator(string mediaCreator)
        {
            this.mediaCreator.Text = $"By {mediaCreator}";
        }

        /// <summary>
        /// Changes the media typeon the interface.
        /// </summary>
        /// <param name="mediaType">Type to change media type to.</param>
        public void ChangeMediaType(string mediaType)
        {
            this.mediaType.Text = mediaType;
        }

        /// <summary>
        /// Changes the edia source on interface.
        /// </summary>
        /// <param name="mediaSource">Source to change media source to.</param>
        public void ChangeMediaSource(string mediaSource)
        {
            this.mediaSource.Text = mediaSource;
        }

        /// <summary>
        /// Changes the amount media was consumed by.
        /// </summary>
        /// <param name="mediaConsumed">m.</param>
        public void ChangeMediaConsumed(string mediaConsumed)
        {
            this.mediaConsumed.Text = mediaConsumed;
        }
    }
}
