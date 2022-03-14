using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDetect : MonoBehaviour
{
    public Collider elevatorDoor;
    public Collider doorOpenCollide;
    public MeshRenderer doorMesh;

    private void OnTriggerEnter(Collider other) {
        
        Debug.Log("Elevaror collides");
        elevatorDoor.isTrigger = true;
        doorMesh.enabled = false;
        doorOpenCollide.isTrigger = true;
    }
}
