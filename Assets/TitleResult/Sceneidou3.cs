using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneidou3 : MonoBehaviour {

    // Use this for initialization
    int time = 0;
    int state = 0;
    void Start ()
    {
      
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        state = 1;
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("TitleScene");
        }
        if (state == 1)
        {
            time++;
        }
        if (time >= 620)
        {
            SceneManager.LoadScene("TitleScene");
        }
        Debug.Log(time);
    }
}
