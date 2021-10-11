using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorpress : MonoBehaviour
{
    public AudioSource gone;
    [SerializeField] private doorController door;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gone.Play();
            door.OpenDoor();
            Debug.Log("Door Opened");
            Destroy(gameObject);
        }
        
       
    }
}
