using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstLight : MonoBehaviour
{
    public GameObject go_message_panel;
    public Text text_panel;
    private int count = 0;
    private GameObject PC;
    /*float timer;
    public float delay = 5;*/
    private string[] messages = {"You found an Object of Light...!", "Slowly, as you gather them, color will return to our lives", "Please, go find them all.", "You're the last hope!"};
    void Start(){
        //Disable Player Control when in cutscene
        PC =GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter(Collider collision){
        count= 1;
        PC.GetComponent<DD_PC_Control>().enabled = false;
        text_panel.text = messages[0];
        go_message_panel.SetActive(true);

        if (Input.GetKeyDown("space")){
            Debug.Log(count);
            if (count  == 4){
                Debug.Log("Check");
                go_message_panel.SetActive(false);
                PC.GetComponent<DD_PC_Control>().enabled = true;
            }
            else{
                text_panel.text = messages[count];
                count++;
            }
        }
    }

    void OnTriggerStay(Collider collision){
        if (Input.GetKeyDown("space")){
            Debug.Log(count);
            if (count  == 4){
                Debug.Log("Check");
                go_message_panel.SetActive(false);
                PC.GetComponent<DD_PC_Control>().enabled = true;
            }
            else{
                text_panel.text = messages[count];
                count++;
            }
        }
    }
}
