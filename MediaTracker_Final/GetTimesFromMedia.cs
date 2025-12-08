// Copyright (c) evanvangNTCgit. All rights reserved.
namespace MediaTrackerFinal
{
    /// <summary>
    /// This is a static class with a method to get the proper hours minutes and seconds from the media.
    /// </summary>
    public static class GetTimesFromMedia
    {
        /// <summary>
        /// Gets the hours, minutes, and seconds from a media object.
        /// </summary>
        /// <param name="mediaSeconds">Media seconds.</param>
        /// <returns>The array of hours, minutse, and seconds in said order.</returns>
        public static int[] HoursMinSecFromMedia(int mediaSeconds)
        {
            int hoursToReturn = 0;
            int minutesToReturn = 0;
            int secondsToReturn = 0;

            int hoursInSeconds = 3600;
            int minutesInSeconds = 60;

            while (mediaSeconds >= hoursInSeconds)
            {
                hoursToReturn++;
                mediaSeconds -= hoursInSeconds;
            }

            while (mediaSeconds >= minutesInSeconds)
            {
                minutesToReturn++;
                mediaSeconds -= minutesInSeconds;
            }

            if (mediaSeconds > 0)
            {
                secondsToReturn += mediaSeconds;
                mediaSeconds = 0;
            }

            return[hoursToReturn, minutesToReturn, secondsToReturn];
        }
    }
}
