using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float constantSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        // Move the bullet locally forward.
        transform.Translate(new Vector3(0, 0, constantSpeed * Time.deltaTime));
    }
}
