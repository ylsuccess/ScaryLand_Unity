using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorMovement : MonoBehaviour
{
    public GameObject movePlatform;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
   
    private void OnTriggerStay(Collider other) {
        //Vector3 increaseValues = new Vector3(movePlatform.transform.up.x, movePlatform.transform.up.y + 5, movePlatform.transform.up.z);
        if(other.gameObject.tag=="Finish"){
            StartCoroutine(Delay());
            movePlatform.transform.position -= movePlatform.transform.up * 20*Time.deltaTime ;
            wall1.transform.position -= movePlatform.transform.up * 20*Time.deltaTime;
            wall2.transform.position -= movePlatform.transform.up * 20*Time.deltaTime;
            wall3.transform.position -= movePlatform.transform.up * 20*Time.deltaTime;
            wall4.transform.position -= movePlatform.transform.up * 20*Time.deltaTime;
        }
        
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
    }


}
