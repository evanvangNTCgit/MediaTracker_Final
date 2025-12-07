// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal.MediaObject.MediaFactory
{
    /// <summary>
    /// This is my factory OOD implementation.
    /// Here will be where I create media.
    /// I need it to follow a certain format so that it can be serialized into a JSON file.
    /// </summary>
    public class MediaFactory
    {
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
        /// <returns>The newly created User Media.</returns>
        public static Media CreateMedia(int priorityNumber, string name, string creator, MediaTypes mediaType, string source, int mediaConsumed, int mediaLength)
        {
            Media mediaInstantiated = null !;
            switch (mediaType)
            {
                case MediaTypes.Movie:
                    throw new NotImplementedException();
                case MediaTypes.Lecture:
                    throw new NotImplementedException();
                case MediaTypes.Podcast:
                    throw new NotImplementedException();
                case MediaTypes.Video:
                    mediaInstantiated = new Video(priorityNumber, name, creator, source, mediaConsumed, mediaLength);
                    break;
            }

            return mediaInstantiated;
        }
    }
}
