// Copyright (c) evanvangNTCgit. All rights reserved.

using MediaTrackerFinal.MediaObject;
using System.Collections.ObjectModel;

namespace MediaTrackerFinal.CommandPattern
{
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
