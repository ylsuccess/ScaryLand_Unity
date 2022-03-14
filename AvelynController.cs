using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvelynController : MonoBehaviour
{
      public float speed;
     public float area;
     private Vector2 newWayPoint;
     private Vector3 wayPoint;
     private Vector3 oldWayPoint;

     public float timeSmooth;
     private float time;
     private CharacterController controller;
     private bool playerDetect;
     public Transform player;
     float x;
    float y;
    float z;
    Vector3 pos;
    public Transform wp1;
    public Transform p2;
    public Transform p3;
    public Transform p4;
    void Start()
    {
        // x = Random.Range(370, 800);
        // y = 212;
        // z = Random.Range(-250, 26);
        // pos = new Vector3(x, y, z);
        // transform.position = pos;
        newWayPoint = transform.position;
        wayPoint = new Vector3(newWayPoint.x, transform.position.y, newWayPoint.y);
        wayPoint = transform.position;
         controller = GetComponent<CharacterController>();
         
         oldWayPoint = wayPoint;
    }
    

     // Update is called once per frame
     void Update () {
        //  if(!playerDetect)
        //     SailRandomly();
        //  else
        //  {
        //      transform.LookAt(player);
        //  }
        if(playerDetect){
            transform.LookAt(player);
            float step =  20 * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
     }

     void SailRandomly(){
         //rende lookat() più gradevole alla vista
         Vector3 smoothLookAt = Vector3.Slerp(oldWayPoint, wayPoint, time/timeSmooth);
         time += Time.deltaTime;
         smoothLookAt.y = wayPoint.y;
         
         //il bot si dirige verso "waypoint" finché non lo raggiunge, poi cambia direzione
         if(Vector3.Distance(transform.position, wayPoint)>20.0f && time/timeSmooth < 1.0f){
             transform.LookAt(smoothLookAt);
             controller.SimpleMove(transform.forward * speed);
         }
         else {
             newWayPoint = Random.insideUnitCircle * area;
             oldWayPoint = wayPoint;
             wayPoint = new Vector3(newWayPoint.x, wayPoint.y, newWayPoint.y);
             transform.LookAt(smoothLookAt);
             controller.SimpleMove(transform.forward * speed);
             time = 0;
         }
     }
     
     void OnGUI() {
     }

     void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Finish"){
            playerDetect = true;
            speed = 20;
            Debug.Log("Detect player");
            transform.LookAt(player);
            controller.SimpleMove(transform.forward * speed);
            time = 0;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Finish"){
            Debug.Log("Finish detect player");
            playerDetect = false;
        }
    }
}
