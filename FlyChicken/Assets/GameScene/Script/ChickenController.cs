using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenController : MonoBehaviour
{
    // 列挙型構造体
    enum State
    {
        Small,        // ばね小
        Large,        // ばね大
        Walk,         // 歩く
        Dead,         // 死
        Life,         // 生
    }

    // 変数の定義
    Rigidbody2D rigid2D;
    float x = 0.1f;
    bool gameStart = false;
    float jumpForce = 0;
    State state = State.Small;
    float force = 0;
    bool gameEnd = false;
    float count = 0;
    GameObject scoreText;
    int score;

    // Use this for initialization
    void Start ()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        transform.Translate(-3f, -6f, 0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //GetComponent<AudioSource>().Play();
        if (gameEnd == false)
        {
            if (gameStart == false)
            {
                if (transform.position.y < 2f)
                {
                    force = 90.0f;
                    this.rigid2D.AddForce(transform.up * force);
                }
                else
                {
                    force = 0f;
                    this.rigid2D.AddForce(transform.up * force);
                }

                if (transform.position.y >= -1f)
                {
                    force = 10.0f;
                    this.rigid2D.AddForce(transform.right * force);
                }

                if (transform.position.x >= -6f)
                {
                    this.rigid2D.velocity = new Vector3(0, 0, 0);
                    gameStart = true;
                }
            }

            if (gameStart == true)
            {
                // 移動処理
                Move(0.094f);

                if (force >= 30)
                {
                    force = 30;
                }
                // ジャンプ処理
                Jump();

                if(state==State.Walk)
                {
                    force = -10f;
                    this.rigid2D.AddForce(transform.up * force);
                }

                if(transform.position.y<=-1.0f)
                {
                    state = State.Dead;
                }

                if ((state == State.Dead) || (state == State.Life)) 
                {
                    gameEnd = true;
                }
            }
        }

        if(gameEnd==true)
        {
            //force = -10f;
            //this.rigid2D.AddForce(transform.up * force);
            count++;

            if (count >= 60.0f)
            {
                if (state == State.Dead)
                {
                    PlayerPrefs.SetInt("Count", score / 2);
                    PlayerPrefs.Save();
                    SceneManager.LoadScene("ResultScene1");
                }

                if (state == State.Life)
                {
                    PlayerPrefs.SetInt("Count", score / 2);
                    PlayerPrefs.Save();
                    SceneManager.LoadScene("ResultScene2");
                }
            }
        }
        //Debug.Log(count);
    }

    // ジャンプ処理
    void Jump()
    {
        // ジャンプ
        if (this.rigid2D.velocity.y == 0)
        {
            switch (state)
            {
                case State.Small:
                    jumpForce = 15.0f;
                    break;
                case State.Large:
                    jumpForce = 15.0f * 2.0f;
                    break;
                case State.Walk:
                    jumpForce = 0;
                    break;
            }

            this.rigid2D.velocity = new Vector3(0, jumpForce, 0);
        }
    }

    // 移動処理
    void Move(float x)
    {
        transform.Translate(x, 0, 0);
        //this.rigid2D.AddForce(transform.right * x);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "smallSpring":
                state = State.Small;
                break;
            case "largeSpring":
                state = State.Large;
                break;
            case "needle":
                state = State.Dead;
                break;
            case "crow":
                state = State.Dead;
                break;
            case "goal":
                state = State.Walk;
                break;
            case "goalFlag":
                state = State.Life;
                break;
        }

        if(other.tag=="coin")
        {
            score++;
        }

        if(other.tag=="crow")
        {
            state = State.Dead;
        }
    }
}
