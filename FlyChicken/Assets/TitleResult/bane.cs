using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bane : MonoBehaviour {

    float scale = 0.4f;
 
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
     
        if(Input.GetMouseButtonDown(0))
        {
            for (float i = 0.4f; i < 3.0f; i++) 
            {
               
                transform.localScale = new Vector3(2, i, 1);
            }
            
        }

        
	}
}
