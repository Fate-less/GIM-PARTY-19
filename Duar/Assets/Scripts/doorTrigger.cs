using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    [SerializeField] private doorController door;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
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
