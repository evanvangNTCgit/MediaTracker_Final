// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal.MediaObject
{
    /// <summary>
    /// This is the Podcast media class.
    /// </summary>
    public class Podcast : Media
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Podcast"/> class.
        /// </summary>
        /// <param name="priorityNumber">prioritny number of Podcast.</param>
        /// <param name="name">Name of the Podcast.</param>
        /// <param name="creator">Creator of the Podcast.</param>
        /// <param name="source">Source of Podcast.</param>
        /// <param name="mediaConsumed">Amount of Podcast Consumed.</param>
        /// <param name="mediaLength">Length of the Podcast.</param>
        public Podcast(int priorityNumber, string name, string creator, string source, int mediaConsumed, int mediaLength)
            : base(priorityNumber, name, creator, source, mediaConsumed, mediaLength, MediaTypes.Podcast)
        {
        }

        /// <summary>
        /// Get the amount of media user watched.
        /// </summary>
        /// <returns>The percentage of media consumed from user (15% for example).</returns>
        public override int GetMediaConsumedDisplay()
        {
            // So for example a 10,000 second movie.
            // We watched 1,500 seconds of it.
            // We get .15 returned or 15 percent.
            return (this.MediaConsumed / this.MediaLength) * 100;
        }
    }
}
