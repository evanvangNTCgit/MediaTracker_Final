// Copyright (c) evanvangNTCgit. All rights reserved.

namespace MediaTrackerFinal.JsonObjectHandling
{
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Text.Json;
    using MediaTrackerFinal.MediaObject;

    /// <summary>
    /// This is a class that will handle writing media collection to a JSON file.
    /// </summary>
    public static class WriteToJSON
    {
        /// <summary>
        /// Writes a json string to a file.
        /// </summary>
        /// <param name="filePath">File path to write JSON string to.</param>
        /// <param name="medias">Media being writed.</param>
        public static void WriteMediaToJsonFile(string filePath, ObservableCollection<Media> medias)
        {
            var json = JsonSerializer.Serialize(medias);
            File.WriteAllText(filePath, json);
        }
    }
}
