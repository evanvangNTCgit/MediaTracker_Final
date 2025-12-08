// Copyright (c) evanvangNTCgit. All rights reserved.

using System.IO;

namespace MediaTrackerFinal.JsonObjectHandling
{
    /// <summary>
    /// This is a class that will handle writing media collection to a JSON file.
    /// </summary>
    public static class WriteToJSON
    {
        /// <summary>
        /// Writes a json string to a file.
        /// </summary>
        /// <param name="filePath">File path to write JSON string to.</param>
        /// <param name="json">Json being writed.</param>
        public static void WriteMediaToJsonFile(string filePath, string json)
        {
            File.WriteAllText(filePath, json);
        }
    }
}
