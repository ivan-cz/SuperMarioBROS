// Iván Carrillo Zardaín A01752903


using UnityEngine;

public class ItemMoneda : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // La moneda desaparece al tocar al jugador
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

   
}
