using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubyControls : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    floaat vertical;

    void Start()
    {
        rigidbody2d = GetComponent<rigidbody2d>();
    }

    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
