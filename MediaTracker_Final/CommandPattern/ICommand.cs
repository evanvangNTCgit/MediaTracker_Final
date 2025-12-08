// Copyright (c) evanvangNTCgit. All rights reserved.
namespace MediaTrackerFinal.CommandPattern
{
    using System.Collections.ObjectModel;
    using MediaTrackerFinal.MediaObject;

    /// <summary>
    /// The interface for all commands to implement.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Each command needs some sort of code to execute.
        /// </summary>
        void Execute();
    }
}
