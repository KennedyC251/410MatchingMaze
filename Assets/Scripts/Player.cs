using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float speed;
    float speedX, speedY;
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * speed;
        speedY = Input.GetAxisRaw("Vertical") * speed;
        rb2D.velocity = new Vector2(speedX, speedY);
    }
}
