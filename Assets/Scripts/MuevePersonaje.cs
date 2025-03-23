// Iván Carrillo Zardaín A01752903

using Unity.VisualScripting;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{   

    

    // Velocidades 
    public float velocidadX;
    
    [SerializeField]
    private float velocidadY;

    
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Inicializar rb
        rb = GetComponent<Rigidbody2D>();
    }


   // Función que se actualiza en cada frame para mover el personaje
    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        if (movVertical > 0) 
        {
            rb.linearVelocity = new Vector2(movHorizontal*velocidadX, 
            movVertical*velocidadY); 
        }
        else 
        {
            rb.linearVelocity = new Vector2(movHorizontal*velocidadX, rb.linearVelocityY);
        }

    }
   
}
