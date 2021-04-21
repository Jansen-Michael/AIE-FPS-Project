using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTanslation : MonoBehaviour
{

    public Vector3 direction = new Vector3(0, 0, 1);

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
