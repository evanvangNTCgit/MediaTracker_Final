// Copyright (c) evanvangNTCgit. All rights reserved.
namespace MediaTrackerFinal.JsonObjectHandling
{
    using System.Collections.ObjectModel;
    using System.Text.Json;
    using MediaTrackerFinal.MediaObject;

    /// <summary>
    ///  This class will handle making a JSON object for the JSON file that holds users current media.
    /// </summary>
    public static class MakeMediaJSON
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };

        /// <summary>
        /// Creates a JSON string from a media observable collection.
        /// </summary>
        /// <param name="mediasToSerialize">The observable collection of media to serialize.</param>
        /// <returns>Observable media collection serialized.</returns>
        public static string CreateMediaJson(ObservableCollection<Media> mediasToSerialize)
        {
            var testing = JsonSerializer.Serialize(mediasToSerialize);
            string formattedJson = System.Text.Json.JsonSerializer
            .Serialize(
                JsonDocument.Parse(testing),
                options);

            return formattedJson;
        }
    }
}
