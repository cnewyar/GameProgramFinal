using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class roboguySchmoovement : MonoBehaviour
{
    private float _xMove;
    public float speed = 10f;
    private Rigidbody2D rb;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        CheckInput();
    }
    void CheckInput()
    {
        _xMove = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * speed);
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(_xMove, 0) * speed);
    }
}
