using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedMul = 500f;

    public float JumpForce = 10f;

    private Rigidbody2D _rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float xPos = Input.GetAxis("Horizontal");
        float speed = Time.deltaTime * speedMul * xPos;

        _rigidbody.AddForce(Vector2.right * speed, ForceMode2D.Force);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }


    }
}
