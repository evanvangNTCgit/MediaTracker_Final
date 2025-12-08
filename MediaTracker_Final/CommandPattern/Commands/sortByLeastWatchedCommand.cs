// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal.CommandPattern.Commands
{
    using System.Collections.ObjectModel;
    using MediaTrackerFinal.MediaObject;

    /// <summary>
    /// This command will sort a media list by the least watched.
    /// </summary>
    public class SortByLeastWatchedCommand : ICommand
    {
        private ObservableCollection<Media> medias;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortByLeastWatchedCommand"/> class.
        /// </summary>
        /// <param name="medias">Observable media collection to sort.</param>
        public SortByLeastWatchedCommand(ObservableCollection<Media> medias)
        {
            this.medias = medias;
        }

        /// <summary>
        /// Function to execute to sort by least watched.
        /// </summary>
        public void Execute()
        {
            // Okay lets sort the medias in make it into a new list.
            var sorted = this.medias
                .OrderBy(m => m.GetMediaConsumedDisplay())
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
