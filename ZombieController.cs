using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    private CharacterController controller;
    public Animator anim;
    public float speed;
    private float playerSpeed = 2.0f;
    private Rigidbody rb;

    UnityEngine.AI.NavMeshAgent agent;
    float move;
     private float gravityValue = -9.81f;
    private Vector3 playerVelocity;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim.applyRootMotion = false;
    }

     void Update()
    {
        
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
        
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // move = Input.GetAxis("Vertical");
        // anim.SetFloat("Speed", move);
       

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.Play("Z_Run", 0, 0.25f);
            rb.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.Play("Z_Run",0, 0.25f);
            rb.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.Play("Z_Run", 0, 0.25f);
            rb.transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.Play("Z_Run", 0, 0.25f);
            rb.transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }

      void OnAnimatorMove()
    {
        // Update position based on animation movement using navigation surface height
        Vector3 position = anim.rootPosition;
        Debug.Log("Current root position is " + position);
        position.y = agent.nextPosition.y;
        position.x = agent.nextPosition.x;
        transform.position = position;

    }
}











































// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ZombieController : MonoBehaviour
// {
//     private CharacterController controller;
//     public Animator anim;
//     public float speed;
//     private float playerSpeed = 2.0f;
//     private Rigidbody rb;

//     UnityEngine.AI.NavMeshAgent agent;
//     float move;
//      private float gravityValue = -9.81f;
//     private Vector3 playerVelocity;
//     // Start is called before the first frame update
//     void Start()
//     {
//         controller = GetComponent<CharacterController>();
//         rb = GetComponent<Rigidbody>();
//         agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
//         anim.applyRootMotion = false;
//     }

//      void Update()
//     {
        
//         Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
//         controller.Move(move * Time.deltaTime * playerSpeed);

//         if (move != Vector3.zero)
//         {
//             gameObject.transform.forward = move;
//         }

//         playerVelocity.y += gravityValue * Time.deltaTime;
//         controller.Move(playerVelocity * Time.deltaTime);
//     }

//     // Update is called once per frame
//     void FixedUpdate()
//     {
//         move = Input.GetAxis("Vertical");
//         anim.SetFloat("Speed", move);

//         if (Input.GetKey(KeyCode.RightArrow))
//         {
//             anim.Play("Z_Run", 0, 0.25f);
//             rb.transform.position += Vector3.right * speed * Time.deltaTime;
//         }
//         if (Input.GetKey(KeyCode.LeftArrow))
//         {
//             anim.Play("Z_Run",0, 0.25f);
//             rb.transform.position += Vector3.left * speed * Time.deltaTime;
//         }
//         if (Input.GetKey(KeyCode.UpArrow))
//         {
//             anim.Play("Z_Run", 0, 0.25f);
//             rb.transform.position += Vector3.forward * speed * Time.deltaTime;
//         }
//         if (Input.GetKey(KeyCode.DownArrow))
//         {
//             anim.Play("Z_Run", 0, 0.25f);
//             rb.transform.position += Vector3.back * speed * Time.deltaTime;
//         }
//     }

//       void OnAnimatorMove()
//     {
//         // Update position based on animation movement using navigation surface height
//         Vector3 position = anim.rootPosition;
//         Debug.Log("Current root position is " + position);
//         position.y = agent.nextPosition.y;
//         position.x = agent.nextPosition.x;
//         transform.position = position;

//     }
// }
