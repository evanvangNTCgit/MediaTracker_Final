// Copyright (c) evanvangNTCgit. All rights reserved.
namespace MediaTrackerFinal.JsonObjectHandling
{
    using MediaTrackerFinal.MediaObject;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using System.Text.Json.Nodes;
    using System.Windows;

    /// <summary>
    ///  This class will handle making a JSON object for the JSON file that holds users current media.
    /// </summary>
    public class MakeMediaJSON
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };

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
