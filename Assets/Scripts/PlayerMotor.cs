using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller; 
    private float speed = 5.0f;
    private Vector3 moveVector;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController> (); 
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity*Time.deltaTime; 
        }
        moveVector = Vector3.zero;
        // valor en X izq- der
        moveVector.x = Input.GetAxisRaw("Horizontal")*speed;
        // valor en Y arriba - abajo
        moveVector.y = verticalVelocity; 
        // valor en Z atras - adelante
        moveVector.z = speed; 

        controller.Move(moveVector* Time.deltaTime); 

    }
}
