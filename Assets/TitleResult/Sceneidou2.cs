using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneidou2 : MonoBehaviour {

    int time = 0;
    int state = 0;
    // Use this for initialization
    void Start () {
		
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
        if (time >= 600)
        {
            SceneManager.LoadScene("TitleScene");
        }
        Debug.Log(time);
    }
}
