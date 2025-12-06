// Copyright (c) evanvangNTCgit. All rights reserved.
namespace MediaTrackerFinal
{
    using System.IO;
    using System.Text.Json.Nodes;
    using static System.Net.Mime.MediaTypeNames;

    /// <summary>
    /// This is a class that I plan on implementing singleton.
    /// This will provide an access to the Users media JSON file.
    /// If they do not have one... Lets make one for them!.
    /// </summary>
    public class UserMediaAccessor
    {
        // This is the media JSON OBJECT of the user.
        private JsonNode mediaObject;

        // This is the array of media User stores.
        private JsonArray mediaArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMediaAccessor"/> class.
        /// This is the constructor.s
        /// Here I will read the JSON file of user.
        /// And set the fields accordingly.
        /// </summary>
        public UserMediaAccessor()
        {
            try
            {
                var r = new StreamReader("../../../TestJSON/testMedia.json");
                var data = r.ReadToEnd();

                // First we get the JSON object of the user.
                this.mediaObject = JsonObject.Parse(data) !;

                // Then we find the media field in the object.
                // This media field holds the array of media user wants to track.
                this.mediaArray = (JsonArray)this.mediaObject["Media"] !;
            }
            catch
            {
                throw new NotImplementedException("Find a way to create a JSON object for user");
                Console.WriteLine("User likely does not have a JSON file.");
            }
        }

        /// <summary>
        /// The the user JSONNode Object.
        /// </summary>
        /// <returns>JSON media node of user.</returns>
        public JsonNode GetUserMediaNode()
        {
            return this.mediaObject;
        }

        /// <summary>
        /// Gets the Media Array of the user.
        /// </summary>
        /// <returns>Media Array of the user.</returns>
        public JsonArray GetMediaArray()
        {
            return this.mediaArray;
        }
    }
}
