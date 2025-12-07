namespace MediaTrackerFinal.MediaObject
{
    /// <summary>
    /// This will be my abstract media.
    /// This is a class for media to inherit from.
    /// I want to keep it short so that it only contain fields IT NEEDS information for.
    /// </summary>
    public abstract class Media
    {
        // The priority number of the media.
        private int priorityNumber;

        // The name of the media.
        private string name;

        // Creator of the media.
        private string creator;

        // The source for media.
        private string source;

        // Current length media has been watched.
        private int mediaConsumed;

        // Length of the media.
        private int mediaLength;

        private MediaTypes mediaType;

        /// <summary>
        /// Initializes a new instance of the <see cref="Media"/> class.
        /// </summary>
        /// <param name="priorityNumber">prioritny number of media.</param>
        /// <param name="name">Name of the media.</param>
        /// <param name="creator">Creator of the Media.</param>
        /// <param name="mediaType">Type of media.</param>
        /// <param name="source">Source of Media.</param>
        /// <param name="mediaConsumed">Amount of media Consumed.</param>
        /// <param name="mediaLength">Length of the media.</param>
        public Media(int priorityNumber, string name, string creator, string source, int mediaConsumed, int mediaLength, MediaTypes mediaType)
        {
            this.PriorityNumber = priorityNumber;
            this.Name = name;
            this.Creator = creator;
            this.Source = source;
            this.MediaConsumed = mediaConsumed;
            this.MediaLength = mediaLength;
            this.mediaType = mediaType;
        }

        public int PriorityNumber { get => priorityNumber; set => priorityNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Creator { get => creator; set => creator = value; }
        public string Source { get => source; set => source = value; }
        public int MediaConsumed { get => mediaConsumed; set => mediaConsumed = value; }
        public int MediaLength { get => mediaLength; set => mediaLength = value; }

        /// <summary>
        /// This is a method that should return how much of the media was consumed.
        /// </summary>
        /// <returns>Percentage of media consumed.</returns>
        public abstract int GetMediaConsumedDisplay();

        public override string ToString()
        {
            return $"{this.name}\n  By: {this.creator}";
        }
    }
}
