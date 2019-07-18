using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpringGenerator : MonoBehaviour
{
    // 変数定義
    public GameObject smallSpringPrefab;
    float springPosx = 2;
    public GameObject largeSpringPrefab;

    // Use this for initialization
    void Start ()
    {
        //this.animator = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        /*
            Ａキー又はＳキーが押されたらばねを設置していく
            Ａキーでばね小、Ｓキーでばね大を設置
        */
        {
            if (Input.GetKeyDown(KeyCode.A))
                DrawSmoolSpring();
            if (Input.GetKeyDown(KeyCode.S))
                DrawLargeSpring();
        }

        //if (ride == false)
        //{
        //    this.animator.speed = 0.0f;
        //}
        //if (ride == true)
        //{
        //    this.animator.speed = 1.0f;
        //}
        //this.animator.speed = 0.0f;
    }

    // ばね小の設置
    void DrawSmoolSpring()
    {
        GameObject go = Instantiate(smallSpringPrefab) as GameObject;
        go.transform.position = new Vector3(transform.position.x, -1f, 0);
        //springPosx += 2.0f;
    }

    // ばね大の設置
    void DrawLargeSpring()
    {
        GameObject go = Instantiate(largeSpringPrefab) as GameObject;
        go.transform.position = new Vector3(transform.position.x, -1f, 0);
        //springPosx += 2.0f;
    }

    public void SmallSpringButtonDown()
    {
        DrawSmoolSpring();
    }

    public void LargeSpringButtonDown()
    {
        DrawLargeSpring();
    }

    void OnTriggerEnter2D(Collider2D Collider)
    {
        //pos_x += 2.0f;
        transform.Translate(new Vector3(1f, 0, 0));
    }
}
