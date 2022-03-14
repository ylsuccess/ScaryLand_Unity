using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdElevatorUp : MonoBehaviour
{
    public GameObject movePlatform;
    public MeshRenderer elevatorDoor;
    public BoxCollider doorThru;

    private void OnTriggerStay(Collider other){
        Debug.Log("Player steps on thrid floor elevator.");
        if(other.gameObject.tag == "Finish"){
            StartCoroutine(Delay());
        }
        // elevatorDoor.enabled = true;
        // doorThru.isTrigger = false;
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Finish"){
            movePlatform.transform.position -= movePlatform.transform.up * 20* Time.deltaTime;
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
        movePlatform.transform.position += movePlatform.transform.up * 20*Time.deltaTime;
        elevatorDoor.enabled = true;
        doorThru.isTrigger = false;
    }
}
