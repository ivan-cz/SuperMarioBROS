using Unity.VisualScripting;
using UnityEngine;


// Codigo para detectar colisión de goomba
public class ColisionGoomba : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        //si el jugador toca al goomba se destruye al jugador
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

    
}
