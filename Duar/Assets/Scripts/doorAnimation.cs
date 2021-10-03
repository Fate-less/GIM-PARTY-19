using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorAnimation : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        animator.SetBool("isOpen", true);
    }
    public void CloseDoor()
    {
        animator.SetBool("isOpen", false);
    }
}
