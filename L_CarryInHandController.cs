using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_CarryInHandController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform l_hand;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = l_hand.position;
    }
}
