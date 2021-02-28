using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;

    

    public float speed;

    void Start ()
    {
        
        Destroy(gameObject, 1);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }

    public void AdjustSpeed (float newSpeed)
    {
        speed = newSpeed;
    }
}
