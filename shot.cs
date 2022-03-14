using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{

   public GameObject parent;
   public GameObject replacehead;
   public GameObject PartToVanish;
   private Animator _animator;

   private void Start() {
       _animator = parent.GetComponent<Animator>();
   }

   private void OnCollisionEnter(Collision other) {
       if(other.gameObject.tag != "Finish" || other.gameObject.tag != "bullet"){
           return;
       }

       _animator.enabled = false;
       GameObject.Instantiate(replacehead,transform.position, transform.rotation);
       Destroy(PartToVanish);
   }
}
