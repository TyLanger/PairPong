using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    


    float vertInput;
    public Vector2 mousePos;

    public Paddle leftPaddle;
    public Paddle rightPaddle;

    public float middleZoneWidth = 2.5f;
    public GameObject middleSprite;

    // Start is called before the first frame update
    void Start()
    {
        // these are the numbers that look right for the temp art
        // might change with a different sprite
        middleSprite.transform.localScale = new Vector3(15 * middleZoneWidth, 80, 0);
    }

    // Update is called once per frame
    void Update()
    {
        vertInput = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // When the mouse is to the left, move the left paddle
        // in the middle, move both
        if (Mathf.Abs(mousePos.x) < middleZoneWidth)
        {
            leftPaddle.vertInput = vertInput;
            rightPaddle.vertInput = vertInput;
        }
        else if (mousePos.x < 0)
        {
            leftPaddle.vertInput = vertInput;
        }
        else
        {
            rightPaddle.vertInput = vertInput;
        }

        
    }
}
