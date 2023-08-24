using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCapsule : MonoBehaviour
{
    public float velMovement = 5f; //Velocidad Personaje
    public float fuerzaJump = 7f; //Fuerza de salto

    private bool enElSuelo = false; //Indicador del personaje tocando el suelo. 


    private Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }


        // Update is called once per frame
        void Update()
        {
            //Movimiento horizontal
            float movimientoH = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(movimientoH * velMovement, rb.velocity.y);


            //salto
            if (Input.GetButton("Jump") && enElSuelo)
            {
                rb.AddForce(new Vector2(0f, fuerzaJump), ForceMode2D.Impulse);
                enElSuelo = false;
            }

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //Detectar el suelo
            if (collision.gameObject.CompareTag("Suelo"))
            {
                enElSuelo = true;
                Debug.Log("Estoy tocando el suelo, cuando salto");
            }
        }

}

