using UnityEngine;
using UnityEngine.Events;
using System;
using System.Collections.Generic;

namespace RadiantTools.MasterCommands
{
    //This class manages the list of commands
    [Serializable]
    public class Command
    {
        [Tooltip("Name of the Command")]
        public string commandName;
        [Tooltip("Description of the command")]
        public string description;
        [Tooltip("Methods you want to run when a command is executed")]
        public UnityEvent commandAction;
    }
    [DisallowMultipleComponent]
    public class CommandList : MonoBehaviour
    {
        public List<Command> allCommands = new();
    }
}
