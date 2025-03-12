using UnityEngine;

/*
Modifica los parámetros del animator del Personaje
Autor: Iván Carrillo Zardaín
*/

public class AnimacionPersonaje : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spRenderer;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isGrounded", EstadoPersonaje.isGrounded);
        //Modificar el parámetro del animador 'velocidad'
        animator.SetFloat("velocidad", Mathf.Abs(rb.linearVelocityX));
        spRenderer.flipX = rb.linearVelocityX < 0;
    
    }
}
