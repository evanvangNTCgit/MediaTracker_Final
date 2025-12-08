// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal.MediaObject
{
    /// <summary>
    /// This is the lecture media class.
    /// </summary>
    public class Lecture : Media
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lecture"/> class.
        /// </summary>
        /// <param name="priorityNumber">prioritny number of Lecture.</param>
        /// <param name="name">Name of the Lecture.</param>
        /// <param name="creator">Creator of the Lecture.</param>
        /// <param name="source">Source of Lecture.</param>
        /// <param name="mediaConsumed">Amount of Lecture Consumed.</param>
        /// <param name="mediaLength">Length of the Lecture.</param>
        public Lecture(int priorityNumber, string name, string creator, string source, int mediaConsumed, int mediaLength)
            : base(priorityNumber, mediaConsumed, mediaLength, MediaTypes.Lecture, name, creator, source)
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
