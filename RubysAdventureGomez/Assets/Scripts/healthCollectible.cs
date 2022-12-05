using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthCollectible : MonoBehaviour
{
    void onTriggerEnter2D (Collider2D other)
    {
        rubyControls controller = other.GetComponent<rubyControls>();

        if(controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.changeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}
