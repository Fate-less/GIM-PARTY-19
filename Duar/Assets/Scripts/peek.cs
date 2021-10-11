using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peek : MonoBehaviour
{
    public AudioSource footsteps;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5.0f);
        footsteps.Play();
        Destroy(gameObject);
    }
}
