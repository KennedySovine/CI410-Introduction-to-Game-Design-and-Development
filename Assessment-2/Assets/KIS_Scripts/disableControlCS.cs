using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableControlCS : MonoBehaviour
{
    public GameObject canvas;
    public GameObject PC;

    void Update()
    {
        if (canvas.activeSelf){
            PC.GetComponent<DD_PC_Control>().enabled = false;
        }
        else{
            PC.GetComponent<DD_PC_Control>().enabled = true;
        }
        
    }
}
