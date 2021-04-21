using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    public float timeInSeconds = 5f;

    void Start()
    {
        StartCoroutine(DestroyAfterXSeconds());
    }

    IEnumerator DestroyAfterXSeconds()
    {
        yield return new WaitForSeconds(timeInSeconds);

        Destroy(gameObject);
    }
}
