// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal.CommandPattern.Commands
{
    using System.Collections.ObjectModel;
    using MediaTrackerFinal.MediaObject;

    /// <summary>
    /// A command that sorts list by most watched.
    /// </summary>
    public class SortByMostWatchedCommand
    {
        private ObservableCollection<Media> medias;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortByMostWatchedCommand"/> class.
        /// </summary>
        /// <param name="medias">Observable media collection to sort.</param>
        public SortByMostWatchedCommand(ObservableCollection<Media> medias)
        {
            this.medias = medias;
        }

        /// <summary>
        /// The command to function to execute for this command.
        /// </summary>
        public void Execute()
        {
            // Okay lets sort the medias in make it into a new list.
            var sorted = this.medias
                .OrderByDescending(m => m.GetMediaConsumedDisplay())
                .ToList();

            // Clear it.
            this.medias.Clear();

            // And now add to the original media list one by one from the proplerly sorted one.
            foreach (var media in sorted)
            {
                this.medias.Add(media);
            }
        }
    }
}
