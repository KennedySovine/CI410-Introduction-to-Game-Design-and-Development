using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpTutorial : MonoBehaviour
{
    public GameObject Tutorial;
    // Start is called before the first frame update
    void Start(){
        Tutorial.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider collision){
        Tutorial.gameObject.SetActive(true);
    }
    void Update(){
        if (Input.GetKeyDown("space")){
            Tutorial.gameObject.SetActive(false);
        }
    }
}
