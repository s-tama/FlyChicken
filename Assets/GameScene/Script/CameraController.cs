using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // 変数定義
    GameObject chicken;

    // Use this for initialization
    void Start ()
    {
        this.chicken = GameObject.Find("chicken");
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 chickenPos = this.chicken.transform.position;
        transform.position = new Vector3(chickenPos.x + 5, transform.position.y, transform.position.z);
    }
}
