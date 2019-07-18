using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallSpringAnimator : MonoBehaviour
{
    Animator animator;
    bool ride = false;

    // Use this for initialization
    void Start ()
    {
        this.animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (ride == false)
        {
            this.animator.speed = 0.0f;
        }
        if (ride == true)
        {
            this.animator.speed = 1.0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "chicken")
        {
            ride = true;
        }
        else
        {
            ride = false;
        }
    }
}
