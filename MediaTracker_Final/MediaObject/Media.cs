// Copyright (c) evanvangNTCgit. All rights reserved.

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
        public Media(int priorityNumber, int mediaConsumed, int mediaLength, MediaTypes mediaType, string name = "No name provided", string creator = "No name provided", string source = "No source provided")
        {
            this.PriorityNumber = priorityNumber;
            this.name = name;
            this.creator = creator;
            this.source = source;
            this.mediaConsumed = mediaConsumed;
            this.mediaLength = mediaLength;
            this.mediaType = mediaType;
        }

        /// <summary>
        /// Gets or sets the priority number of media.
        /// </summary>
        public int PriorityNumber { get => this.priorityNumber; set => this.priorityNumber = value; }

        /// <summary>
        /// Gets the name of the media.
        /// </summary>
        public string Name { get => this.name; }

        /// <summary>
        /// Gets the creator of the media.
        /// </summary>
        public string Creator { get => this.creator; }

        /// <summary>
        /// Gets the source of the media.
        /// </summary>
        public string Source { get => this.source; }

        /// <summary>
        /// Gets or sets the amount of media consumed by user.
        /// </summary>
        public int MediaConsumed { get => this.mediaConsumed; set => this.mediaConsumed = value; }

        /// <summary>
        /// Gets the length of the media.
        /// </summary>
        public int MediaLength { get => this.mediaLength; }

        /// <summary>
        /// Gets the type of media this is.
        /// </summary>
        public MediaTypes MediaType { get => this.mediaType; }

        /// <summary>
        /// This is a method that should return how much of the media was consumed.
        /// </summary>
        /// <returns>Percentage of media consumed.</returns>
        public abstract int GetMediaConsumedDisplay();

        /// <summary>
        /// Proper to string for media.
        /// </summary>
        /// <returns>Media to string.</returns>
        public override string ToString()
        {
            return $"{this.name}, {this.mediaType.ToString()}\n  By: {this.creator}";
        }
    }
}
