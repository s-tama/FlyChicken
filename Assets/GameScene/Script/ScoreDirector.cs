using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour
{
    int score;
    GameObject scoreText;

    // Use this for initialization
    void Start ()
    {
        score = PlayerPrefs.GetInt("Count", 0);
        scoreText = GameObject.Find("Score");
        scoreText.GetComponent<Text>().text = score.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
