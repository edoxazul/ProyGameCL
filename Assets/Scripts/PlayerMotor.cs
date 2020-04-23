using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMotor : MonoBehaviour 
{
    private CharacterController controller; 
    private float speed = 5.0f;
    private Vector3 moveVector;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    private Inventario inventario = new Inventario();
    private UI_Management ui;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        ui = GameObject.Find("Canvas").GetComponent<UI_Management>();
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

        timer = timer + Time.deltaTime;
        if (timer > 0.5)
        {
            ui.AddScore(1);
            timer = 0;
        }
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Guante")
        {
            ui.AddGuante();
            Debug.Log("Se ha añadido un guante");
            Destroy(hit.gameObject);
        }
        if (hit.gameObject.tag == "Mascarilla")
        {
            ui.AddMascarilla();
            Debug.Log("Se ha añadido una mascarilla");
            Destroy(hit.gameObject);
        }
        if (hit.gameObject.tag == "Gema")
        {
            inventario.AumentarGemas(1);
            inventario.MostrarGemas();
            ui.AddScore(25);
            Destroy(hit.gameObject);
        }
    }
}
