using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batterfly : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        //change the name of gravestone
        if (otherObject.GetComponent<Scarecrow>())
        {
            GetComponent<Attacker>().Attack(otherObject);
            Destroy(gameObject);
            GetComponent<Health>().TriggerDeathVFX();
        }

        else if (otherObject.GetComponent<Defender>() || otherObject.GetComponent<Projectile>())
        {
            return;
        }

    }
}
