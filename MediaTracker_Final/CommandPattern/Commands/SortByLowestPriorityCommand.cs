// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal.CommandPattern.Commands
{
    using System.Collections.ObjectModel;
    using MediaTrackerFinal.MediaObject;

    class SortByLowestPriorityCommand : ICommand
    {
        private ObservableCollection<Media> medias;

        public SortByLowestPriorityCommand(ObservableCollection<Media> medias)
        {
            this.medias = medias;
        }

        /// <summary>
        /// The function to execute for this command.
        /// </summary>
        public void Execute()
        {
            // Okay lets sort the medias in make it into a new list.
            var sorted = this.medias
                .OrderByDescending(m => m.PriorityNumber)
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
