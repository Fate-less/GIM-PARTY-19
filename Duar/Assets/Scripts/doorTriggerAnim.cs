using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTriggerAnim : MonoBehaviour
{
    [SerializeField] private doorAnimation door;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            door.OpenDoor();
        }
        if (Input.GetMouseButtonUp(0))
        {
            door.CloseDoor();
        }
    }
}
