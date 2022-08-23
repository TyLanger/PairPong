using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float moveSpeed = 10;

    public float vertInput;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //transform.position = Vector2.MoveTowards(transform.position, transform.position + new Vector3(0, vertInput, 0), moveSpeed * Time.fixedDeltaTime);
        rb.MovePosition((Vector2)transform.position + Vector2.up * vertInput * moveSpeed * Time.fixedDeltaTime);
    }
}
