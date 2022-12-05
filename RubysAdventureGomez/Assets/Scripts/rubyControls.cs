using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubyControls : MonoBehaviour
{
//-----Publicly Declared Speed Value-----//
    public float speed = 3.0f;

//-----Publicly Declared Health Value----//
    public int maxHealth = 5;
    public int health { get { return currentHealth;  }}
    int currentHealth;

//-----Privately Declared RigidBody Variables-----//
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;


    void Start()
    {
     //-----Connection of RigidBody Variables-----//
        rigidbody2d = GetComponent<Rigidbody2D>();

     //-----Connection of Health Variables-----//
        currentHealth = maxHealth;
    }

    
    void Update()
    {
     //-----Input for Mopvement Variables-----//
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
     //-----Movement Control-----//
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    public void changeHealth(int amount)
    {
     //-----Health Change/Display-----//
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
