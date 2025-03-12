using Unity.VisualScripting;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{   

    // transform, gameObject

    // Velocidades 
    public float velocidadX;
    
    [SerializeField]
    private float velocidadY;

    // Necesito que se mueva
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Inicializar rb
        rb = GetComponent<Rigidbody2D>();
    }


    // FixedUpdate is called to update the object in a fixed frame rate
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
