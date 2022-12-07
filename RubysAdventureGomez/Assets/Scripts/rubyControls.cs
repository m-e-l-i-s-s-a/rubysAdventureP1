using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyControls : MonoBehaviour
{
//-----Publicly Declared Speed Value-----//
    public float speed = 3.0f;

//-----Publicly Declared Health Values----//
    public int maxHealth = 5;
    public float timeInvincible = 2.0f;
    public int health { get { return currentHealth;  }}
    int currentHealth;

    //-----Privately Declared Invincible Values----//
    bool isInvincible;
    float invincibleTimer;

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

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }
    }

    void FixedUpdate()
    {
     //-----Movement Control-----//
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
                return;

            isInvincible = true;
            invincibleTimer = timeInvincible;
        }

     //-----Health Change/Display-----//
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
