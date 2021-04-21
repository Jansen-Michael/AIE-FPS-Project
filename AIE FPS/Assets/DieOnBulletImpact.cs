using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnBulletImpact : MonoBehaviour
{
    public GameObject explosionEffect;

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnCollision is called when this object collides with another object in the physics system.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            print("Test");
            Instantiate(explosionEffect, transform.position, transform.rotation);
            print("Test1");
            Destroy(gameObject);
        }
        print("Test2");
    }
}
