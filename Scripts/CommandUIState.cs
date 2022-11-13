using System.Collections;
using UnityEngine;

namespace RadiantTools.MasterCommands
{
    public class CommandUIState : MonoBehaviour
    {
        //Most of the UI is managed in CommandInput and this class only manages the state of the command prompt
        [SerializeField] GameObject commandPrompt;
        bool canChangeState = true;
        void Update()
        {
            if(!canChangeState) { return; }
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.Q))
            {
                commandPrompt.SetActive(!commandPrompt.activeSelf);
                canChangeState = false;
                Invoke(nameof(SetCanChangeState), 1f);
            }
        }
        void SetCanChangeState()
        {
            canChangeState = true;
        }
    }
}
