using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Vector2 forceDir;
    public float forceStr;

    Rigidbody2D rb;
    public float vel;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(forceDir);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddRelativeForce(rb.velocity.normalized * forceStr * Time.fixedDeltaTime);
        rb.velocity = rb.velocity.normalized * forceStr;
        vel = rb.velocity.magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
