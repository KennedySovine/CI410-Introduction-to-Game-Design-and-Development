using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponTutorial : MonoBehaviour
{
    public GameObject Tutorial;
    public Text text_panel;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider collision){
        Tutorial.gameObject.SetActive(true);
        text_panel.text = "Press [F] to pick up the Bow and Arrows.";
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.F)){
            text_panel.text = "Press left click to shoot";
        }
        else if (Input.GetKey(KeyCode.Mouse0)){
            Tutorial.gameObject.SetActive(false);
        }
    }
}
