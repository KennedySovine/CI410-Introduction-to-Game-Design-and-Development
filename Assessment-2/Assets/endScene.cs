using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endScene : MonoBehaviour
{
    public GameObject go_message_panel;
    public GameObject _restartButton;
    private GameObject PC;
    private GameObject Ending;

    public void OnTriggerEnter(Collider collider)
     {
        Ending = GameObject.Find("Ending");
        PC =GameObject.FindWithTag("Player");
        Ending.SetActive(true);
        go_message_panel.SetActive(true);
        PC.GetComponent<DD_PC_Control>().enabled = false;
     }

     public void RestartButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
}
