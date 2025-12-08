// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal.MediaObject
{
    /// <summary>
    /// The movie media class.
    /// </summary>
    public class Movie : Media
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// </summary>
        /// <param name="priorityNumber">prioritny number of Movie.</param>
        /// <param name="name">Name of the Movie.</param>
        /// <param name="creator">Creator of the Movie.</param>
        /// <param name="source">Source of Movie.</param>
        /// <param name="mediaConsumed">Amount of Movie Consumed.</param>
        /// <param name="mediaLength">Length of the Movie.</param>
        public Movie(int priorityNumber, string name, string creator, string source, int mediaConsumed, int mediaLength)
            : base(priorityNumber, mediaConsumed, mediaLength, MediaTypes.Movie, name, creator, source)
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
            var dec = (double)this.MediaConsumed / (double)this.MediaLength;
            var percentageToReturn = Convert.ToInt32(dec * 100);
            return percentageToReturn;
        }
    }
}
