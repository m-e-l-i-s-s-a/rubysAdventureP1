using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageZone : MonoBehaviour
{
    void onTriggerEnter2D(Collider2D other)
    {
        rubyControls controller = other.GetComponent<rubyControls>();

        if (controller != null)
        {
            controller.changeHealth(-1);
        }
    }
}
