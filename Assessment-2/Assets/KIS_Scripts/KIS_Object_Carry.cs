using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KIS_Object_Carry : MonoBehaviour
{
    // Variables
    public Color col_highlight = Color.yellow;
    private Color col_original;
    public float fl_activation_distance = 2F;
    public Transform tf_pc;
    private Material mat_object;
    private bool bl_carrying = false;
    private bool bl_has_RB = false;

    //Start
    private void Start(){
        if (tf_pc == null) tf_pc = GameObject.FindWithTag("Player").transform;
        mat_object = GetComponent<Renderer>().material;
        col_original = mat_object.color;
        //Check if RigidBody is attatched
        if (GetComponent<Rigidbody>()) bl_has_RB = true;
        
    }

    void Update(){
        //activation distance?
        if (Vector3.Distance(transform.position, tf_pc.position) < fl_activation_distance){
            if (!bl_carrying){
                if (mat_object.color == col_original) mat_object.color = col_highlight;
            }
            else{
                mat_object.color = col_original;
            }

            //Check for key press
            if (Input.GetKeyDown(KeyCode.F)){
                if (!bl_carrying){
                    //stop rigidbody from moving
                    if (bl_has_RB) GetComponent<Rigidbody>().isKinematic = true;

                    //position the obj in front of the PC converting local to world coordinates
                    transform.SetPositionAndRotation(tf_pc.position + tf_pc.TransformDirection(0.3F, 0.3F, 1.3F), tf_pc.rotation);

                    //Child the obejct to the PC
                    transform.parent = tf_pc;
                    bl_carrying = true;
                }
        
                else{
                    bl_carrying = false;
                    transform.parent = null;
                    if (bl_has_RB) GetComponent<Rigidbody>().isKinematic = false;
                }
            }
        }
        else if (Vector3.Distance(transform.position, tf_pc.position) < fl_activation_distance +1){
            //Reset the color as we move away
            mat_object.color = col_original;
        }
    }
}