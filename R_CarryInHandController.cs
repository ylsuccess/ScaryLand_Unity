using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_CarryInHandController : MonoBehaviour
{
    public Transform r_hand;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = r_hand.position;
    }
   
}
