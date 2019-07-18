using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    Rigidbody2D rigid2D;

	// Use this for initialization
	void Start ()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "chicken")
        {
            Destroy(gameObject);
        }
    }
}
