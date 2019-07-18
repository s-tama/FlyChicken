using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneidou : MonoBehaviour {
    int time = 0;
    int state = 0;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      

        if (Input.GetMouseButton(0))
        {
            state = 1;
        }
        if(state == 1)
        {
            time++;
        }
        if (time >= 120)
        {
            SceneManager.LoadScene("GameScene");
        }
        Debug.Log(time);
    }
}
