using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baneScript : MonoBehaviour
{

    // Use this for initialization
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTouch()
    {
        animator.SetTrigger("jump");
    }

}
