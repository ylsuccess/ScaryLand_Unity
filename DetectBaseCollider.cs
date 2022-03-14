using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBaseCollider : MonoBehaviour
{
    
     private void OnTriggerEnter(Collider other) {
        
        Debug.Log("Elevaror collides base floor");
        
    }
}
