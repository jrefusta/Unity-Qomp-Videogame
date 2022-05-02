using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class PaddleBehaviourScript : MonoBehaviour
{
    private Vector3 direction;
    private GameObject ball;
    private float topBound, botBound;
    private int velY;
    private bool collision;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(0f, 10f, 0f);
        velY = 10;
        ball = GameObject.Find("Ball");
        string name = UnitySceneManager.GetActiveScene().name;
        if (name == "Level1")
        {
            topBound = 5;
            botBound = -5;
        }
        if (name == "Level3")
        {
            topBound = 4.6f;
            botBound = -4.3f;
        }
        collision = false;
    }

    // Update is called once per frame
    void Update()
    {
        string name = UnitySceneManager.GetActiveScene().name;
        if (name == "Level1")
        {
            if (Mathf.Abs(transform.position.x - ball.transform.position.x) < 6)
            {
                if (transform.position.y - ball.transform.position.y - 1 < 0/* && direction.y < 0*/)
                {
                    if (transform.position.y < topBound)
                    {
                        gameObject.transform.Translate(0, velY * Time.deltaTime, 0);
                    }
                    else
                    {
                        gameObject.transform.position = new Vector3((gameObject.transform.position.x), topBound, Mathf.FloorToInt(gameObject.transform.position.z));
                    }
                }
                else if (transform.position.y - ball.transform.position.y - 1 > 0/* && direction.y > 0*/)
                {
                    if (transform.position.y > botBound)
                    {
                        gameObject.transform.Translate(0, -velY * Time.deltaTime, 0);
                    }
                    else
                    {
                        gameObject.transform.position = new Vector3((gameObject.transform.position.x), botBound, Mathf.FloorToInt(gameObject.transform.position.z));
                    }
                }
            }
            else
            {/*
            gameObject.transform.Translate(0, velY * Time.deltaTime, 0);
            if (transform.position.y <= botBound)
            {
                velY = 10;// gameObject.transform.Translate(0, velY * Time.deltaTime, 0);
            }
            if (transform.position.y >= topBound)
            {
                velY = -10;
            }
            if (collision)
            {
                direction.y *= -1;
                collision = false;
            }
            gameObject.transform.Translate(direction * Time.deltaTime);*/
                if (transform.position.y < botBound)
                {
                    gameObject.transform.Translate(0, velY * Time.deltaTime, 0);
                }
                else if (transform.position.y > topBound)
                {
                    gameObject.transform.Translate(0, -velY * Time.deltaTime, 0);
                }
                else
                {

                    if (collision)
                    {
                        direction.y *= -1;
                        collision = false;
                    }
                    gameObject.transform.Translate(direction * Time.deltaTime);
                }
            }
        }
        else if (name == "Level3")
        {
            if (collision)
            {
                direction.y *= -1;
                collision = false;
            }
            gameObject.transform.Translate(direction * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("map"))
        {
            collision = true;
        }
    }
}
