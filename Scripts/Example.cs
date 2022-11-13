using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantTools.MasterCommands
{
    public class Example : MonoBehaviour
    {
        //This script has methods which we can run
        public void PrintCommand()
        {
            Debug.Log("Ran Command");
        }
        public void MoveCamera()
        {
            transform.position = new Vector3(10, 10, 10);
        }
    }
}
