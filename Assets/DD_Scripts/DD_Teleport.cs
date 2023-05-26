
using UnityEngine;
using UnityEngine.UI;

public class DD_Teleport : MonoBehaviour
{
    // ---------------------------------------------------------------------
    public float fl_distance = 2;
    public string st_message = "Press E to Enter";
    public Transform tf_Teleport_Target;
    private Transform tf_PC;
    public GameObject go_message_panel;
   public  Text text_message;

    // Use this for initialization
    void Start()
    {
       if(!tf_PC) tf_PC = GameObject.FindWithTag("Player").transform;   

    }//-----

    // Update is called once per frame
    void Update()
    {
        // In trigger distance
        if (Vector3.Distance(tf_PC.transform.position, transform.position) < fl_distance)
        {
            // Turn on Message Panel
            go_message_panel.SetActive(true);
            text_message.text = st_message;

            if (Input.GetKeyDown("e"))
            {
                tf_PC.transform.position = tf_Teleport_Target.transform.position;
                go_message_panel.SetActive(false);
            }

        }
        else if (Vector3.Distance(tf_PC.transform.position, transform.position) < fl_distance + 1)
        {
            go_message_panel.SetActive(false);
        }

    }//-----

}//=========
