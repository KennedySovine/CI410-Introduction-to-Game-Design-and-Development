using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Variables
    public float fl_activation_distance = 3F;
    private GameObject PC;
    public Transform tf_pc;
    private Material mat_object;
    private bool bl_has_RB = false;
    public GameObject item;

    //Start
    private void Start(){
        if (tf_pc == null) tf_pc = GameObject.FindWithTag("Player").transform;
        //Check if RigidBody is attatched
        if (GetComponent<Rigidbody>()) bl_has_RB = true;
        PC = GameObject.FindWithTag("Player");
    }

    void Update(){
            //Check for key press
            if (Vector3.Distance(transform.position, tf_pc.position) < fl_activation_distance){
            if (Input.GetKeyDown(KeyCode.F)){
                    //stop rigidbody from moving
                    if (bl_has_RB) GetComponent<Rigidbody>().isKinematic = true;

                    //position the obj in front of the PC converting local to world coordinates
                    PC.GetComponent<Inventory>().inventoryAdd(item);
                    Destroy(item);
                    //Child the obejct to the PC
                    GetComponent<Slow_Rotate_Bounce>().enabled = false;
            }
            }
    }
}
