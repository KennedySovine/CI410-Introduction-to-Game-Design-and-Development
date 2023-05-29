using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginningMessages : MonoBehaviour
{
    public GameObject go_message_panel;
    public Text text_panel;
    private int count = 0;
    /*float timer;
    public float delay = 5;*/
    private string[] messages = {"You don't know why you're here, do you?", "The world has lost its color.", "No one but you can see the beauty of the world anymore.", "You must help them!"};
    void Start(){
        go_message_panel.SetActive(true);
        Screen.lockCursor = true;
    }
    void Update(){ 
     if (Input.GetKeyDown("space")){
        Debug.Log(count);
        if (count  == 4){
            Debug.Log("Check");
            go_message_panel.SetActive(false);
        }
        else{
                text_panel.text = messages[count];
                count++;
            }
        }
    }
}
