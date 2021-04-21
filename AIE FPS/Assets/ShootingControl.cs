using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingControl : MonoBehaviour
{
    // The bullet.
    public GameObject bullet;

    // Where the bullet spawn from.
    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        // If left click is pressed:
        if (Input.GetMouseButtonDown(0))
        {
            // Instantiate the bullet at the position and rotation of the spawnpoint.
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
