using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBottomArrive : MonoBehaviour
{
    public MeshRenderer door;
    public BoxCollider door_;

    public GameObject elevator_bottom;
    private void OnTriggerEnter(Collider other) {
        
        Debug.Log("Elevaror collides bottom");
        door.enabled = false;
        door_.isTrigger = true;
        //elevator_bottom.SetActive(false);
    }
}
