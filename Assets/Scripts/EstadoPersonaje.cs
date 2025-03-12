using UnityEngine;

/* 
Para saber si el personaje está en el piso o no
Autor: Iván Carrillo Zardaín
*/

public class EstadoPersonaje : MonoBehaviour
{
    public static bool isGrounded {get; private set;} // las llaves permiten definir el comportamiento (propiedades). El metodo get es publico y el metodo set es privado dentro de la clase. Los metodos get y set ya estan predefinidos.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
