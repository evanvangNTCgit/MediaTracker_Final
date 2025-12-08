// Copyright (c) evanvangNTCgit. All rights reserved.

using MediaTrackerFinal.MediaObject;
using System.Collections.ObjectModel;

namespace MediaTrackerFinal.CommandPattern.Commands
{
    /// <summary>
    /// A no command class is needed as to not throw an error when no command is set to a button.
    /// </summary>
    public class NoCommand : ICommand
    {
        /// <summary>
        /// The function executed when there is no command.
        /// Here I just simply log to the console that nothing was implemented here.
        /// </summary>
        void ICommand.Execute()
        {
            Console.WriteLine("No command implemented");
        }
    }
}
