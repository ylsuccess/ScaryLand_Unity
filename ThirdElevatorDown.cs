using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdElevatorDown : MonoBehaviour
{   
    public GameObject movePlatform;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject elevatorFloor;
    public GameObject ceiling;
    public MeshRenderer door;
    public BoxCollider door_;

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.tag=="Finish"){
            StartCoroutine(Delay());
            movePlatform.transform.position -= movePlatform.transform.up * 10*Time.deltaTime;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
        door.enabled = true;
        door_.isTrigger = false;
    }
}
