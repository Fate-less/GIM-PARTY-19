using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public AudioSource whoaw;
    [SerializeField] private doorController door;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            whoaw.Play();
            door.OpenDoor();
            Debug.Log("Door Opened");
        }
        if (Input.GetMouseButtonUp(0))
        {
            door.CloseDoor();
            Debug.Log("Door Closed");
        }
    }
}
