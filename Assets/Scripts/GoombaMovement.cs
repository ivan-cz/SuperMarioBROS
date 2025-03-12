using UnityEngine;

public class GoombaMovement : MonoBehaviour
{
    
    private float velGoomba = -5.0f;
    private Rigidbody2D rb;
    
    private Vector2 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
        movement = new Vector2(velGoomba, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = movement;
    }
}
