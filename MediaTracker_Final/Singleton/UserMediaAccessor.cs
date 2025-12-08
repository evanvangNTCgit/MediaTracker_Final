// Copyright (c) evanvangNTCgit. All rights reserved.


namespace MediaTrackerFinal.Singleton
{
    using System;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Text.Json.Nodes;
    using MediaTrackerFinal.MediaObject;
    using MediaTrackerFinal.MediaObject.MediaFactory;

    /// <summary>
    /// This is a class that I plan on implementing singleton.
    /// This will provide an access to the Users media JSON file.
    /// If they do not have one... Lets make one for them!.
    /// </summary>
    public class UserMediaAccessor
    {
        private ObservableCollection<Media> medias = new ObservableCollection<Media>();

        /// <summary>
        /// Gets the userMedia list.
        /// The beauty of singleton.
        /// I can make sure code only refrences this one JSON file.
        /// But then also if not seen lets get it.
        /// </summary>
        public ObservableCollection<Media> Medias
        {
            get
            {
                if (this.medias.Count <= 0)
                {
                    this.GetUserMedia();
                    return this.medias;
                }
                else
                {
                    return this.medias!;
                }
            }
        }

        private void GetUserMedia()
        {
            try
            {
                var data = File.ReadAllText("../../../TestJSON/testMedia.json");
                var dataArray = JsonArray.Parse(data)!.AsArray();

                foreach (JsonNode media in dataArray!)
                {
                    int priorityNum = media!["PriorityNumber"]!.GetValue<int>();
                    string title = media["Name"]!.GetValue<string>();
                    string creator = media["Creator"]!.GetValue<string>();
                    string source = media["Source"]!.GetValue<string>();
                    int mediaConsumed = media["MediaConsumed"]!.GetValue<int>();
                    int mediaDuration = media["MediaLength"]!.GetValue<int>();
                    int mediaType = media["MediaType"]!.GetValue<int>();

                    var mToAdd = MediaFactory.CreateMediaFromJsonObject(priorityNum, title, creator, mediaType, source, mediaConsumed, mediaDuration);
                    this.medias.Add(mToAdd);
                }
            }

            // Okay user likely does not have a JSON file for media lets use a dummy one.
            catch (FileNotFoundException)
            {
                var data = @"[
  {
    ""PriorityNumber"": 99,
    ""Name"": ""Dummy Video"",
    ""Creator"": ""Evan Vang"",
    ""Source"": ""Evan's Basement"",
    ""MediaConsumed"": 100,
    ""MediaLength"": 100,
    ""MediaType"": 1
  }
]";
                var dataArray = JsonArray.Parse(data)!.AsArray();

                foreach (JsonNode media in dataArray!)
                {
                    int priorityNum = media!["PriorityNumber"]!.GetValue<int>();
                    string title = media["Name"]!.GetValue<string>();
                    string creator = media["Creator"]!.GetValue<string>();
                    string source = media["Source"]!.GetValue<string>();
                    int mediaConsumed = media["MediaConsumed"]!.GetValue<int>();
                    int mediaDuration = media["MediaLength"]!.GetValue<int>();
                    int mediaType = media["MediaType"]!.GetValue<int>();

                    var mToAdd = MediaFactory.CreateMediaFromJsonObject(priorityNum, title, creator, mediaType, source, mediaConsumed, mediaDuration);
                    this.medias.Add(mToAdd);
                }

                Console.WriteLine("Hello!");
            }
        }
    }
}
