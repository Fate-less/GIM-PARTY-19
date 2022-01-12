using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class CrewmateGFX : MonoBehaviour
{
    public Animator animator;
    public AIPath aiPath;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = aiPath.desiredVelocity.x;
        movement.y = aiPath.desiredVelocity.y;
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
