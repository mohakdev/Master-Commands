using UnityEngine;
using UnityEngine.UI;

namespace RadiantTools.MasterCommands
{
    //This class manages the Input and UI of Command Prompt
    public class CommandInput : MonoBehaviour
    {
        CommandList commandList;
        void Start()
        {
            commandList = GetComponent<CommandList>();
        }
        public void RunCommand(string inputText)
        {
            foreach(Command command in commandList.allCommands)
            {
                if (inputText.Equals(command.commandName))
                {
                    command.commandAction.Invoke();
                }
            }
        } 
    }
}
