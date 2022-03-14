using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
     void Start()
    {
        Destroy(gameObject, 5);//bullet destroys itself after 5 seconds
    }
}
