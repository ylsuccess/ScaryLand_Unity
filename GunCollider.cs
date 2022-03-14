using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCollider : MonoBehaviour
{
    private bool pickup;
    public Transform hand;
    private int count;
    public Transform footlocation;
    public Transform parent_body_transform;
     void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Finish"){
            Debug.Log("Zombie Collide with gun");
            pickup = true;
            Update();
            count =1;
        }
    }

    void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Finish"){
            Debug.Log("Zombie Stay on gun");
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Finish"){
            Debug.Log("Zombie Exits gun");
        }
    }

    private void Update() {
        if(Input.GetKey(KeyCode.Space) && count==1){
            transform.position = new Vector3(transform.position.x, footlocation.position.y, transform.position.z);
            pickup = false;
            count = 0;

        }
        if(pickup)
            transform.position = hand.position;
            //transform.rotation = parent_body_transform.rotation;
            transform.eulerAngles = new Vector3(parent_body_transform.rotation.eulerAngles.x, parent_body_transform.rotation.eulerAngles.y - 90, parent_body_transform.rotation.eulerAngles.z);
    }
}
