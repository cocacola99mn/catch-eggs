using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    private Rigidbody2D Basket;
    public float speed = 4;
    public float xBound = 2.5f;

    void Start()
    {
        Basket = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        if (h > 0)
            Basket.velocity = Vector2.right * speed;
        else if (h < 0)
            Basket.velocity = Vector2.left * speed;
        else
            Basket.velocity = Vector2.zero;
        
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound),transform.position.y);
    }
}
