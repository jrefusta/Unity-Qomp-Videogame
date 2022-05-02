using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class CameraBehaviour : MonoBehaviour
{
    public int stage = 1;
    public bool cameraMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        string name = UnitySceneManager.GetActiveScene().name;
        if (name == "Level1")
        {
            gameObject.transform.position = new Vector3Int(0, 0, -13);
        }
        else if (name == "Level2")
        {
            gameObject.transform.position = new Vector3Int(0, 0, -17);
        }
        else if (name == "Level3")
        {
            gameObject.transform.position = new Vector3Int(0, 0, -17);
        }
        else if (name == "Level4")
        {
            gameObject.transform.position = new Vector3(0, -0.5f, -75);
        }
        else if (name == "Level5")
        {
            gameObject.transform.position = new Vector3(25, 2.5f, -75);
        }
    }
    // Update is called once per frame
    void Update()
    {
        string name = UnitySceneManager.GetActiveScene().name;
        if (name == "Level1")
        {

            if (stage == 1)
            {
                if (GameObject.Find("Ball").transform.position.x > 13)
                {
                    Vector3 pos = new Vector3(20, 0, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 2;
                }
                if (GameObject.Find("Ball").transform.position.x < -13)
                {
                    Vector3 pos = new Vector3(-20, 0, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 3;
                }
            }
            if (stage == 2)
            {
                if (GameObject.Find("Ball").transform.position.x < 13)
                {
                    Vector3 pos = new Vector3(0, 0, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 1;
                }
                if (GameObject.Find("Ball").transform.position.y < -7)
                {
                    Vector3 pos = new Vector3(20, -14, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 5;
                }
            }
            if (stage == 3)
            {
                if (GameObject.Find("Ball").transform.position.x > -13)
                {

                    Vector3 pos = new Vector3(0, 0, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 1;
                }
                if (GameObject.Find("Ball").transform.position.y < -7)
                {
                    Vector3 pos = new Vector3(-20, -14, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 4;
                }
            }
            if (stage == 4)
            {
                if (GameObject.Find("Ball").transform.position.y > -7)
                {

                    Vector3 pos = new Vector3(-20, 0, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 3;
                }
                if (GameObject.Find("Ball").transform.position.x > -13)
                {
                    Vector3 pos = new Vector3(0, -14, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 6;
                }
            }
            if (stage == 5)
            {
                if (GameObject.Find("Ball").transform.position.y > -7)
                {

                    Vector3 pos = new Vector3(20, 0, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 2;
                }
                if (GameObject.Find("Ball").transform.position.x < 13)
                {

                    Vector3 pos = new Vector3(0,-14, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 6;
                }
            }

            if (stage == 6)
            {
                if (GameObject.Find("Ball").transform.position.x > 13)
                {
                    Vector3 pos = new Vector3(20, -14, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 5;
                }
                if (GameObject.Find("Ball").transform.position.x < -13)
                {
                    Vector3 pos = new Vector3(-20, -14, - 13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 4;
                }
                if (GameObject.Find("Ball").transform.position.y < -21)
                {

                    Vector3 pos = new Vector3(0, -29, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 7;
                }
            }
            if (stage == 7)
            {
                if (GameObject.Find("Ball").transform.position.y > -21)
                {
                    Vector3 pos = new Vector3(0, -14, -13);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 6;
                }
            }
        }
        else if (name == "Level2")
        {
            if (stage == 1)
            {
                if (GameObject.Find("Ball").transform.position.x > 6)
                {
                    Vector3 pos = new Vector3(15, 1, -27);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 2;
                }
            }
            if (stage == 2)
            {
                if (GameObject.Find("Ball").transform.position.y < -15)
                {
                    Vector3 pos = new Vector3(15, -18, -35);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 3;
                }
                if (GameObject.Find("Ball").transform.position.x > 27)
                {
                    Vector3 pos = new Vector3(41, -1, -20);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 4;
                }
            }
            if (stage == 3)
            {
                if (GameObject.Find("Ball").transform.position.y > -5)
                {

                    Vector3 pos = new Vector3(15, 1, -27);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 2;
                }
            }
            if (stage == 4)
            {
                if (GameObject.Find("Ball").transform.position.x < 27)
                {

                    Vector3 pos = new Vector3(15, 1, -27);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 2;
                }
                if (GameObject.Find("Ball").transform.position.x > 60)
                {
                    Vector3 pos = new Vector3(76, 7, -35);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 5;
                }
            }
            if (stage == 5)
            {
                if (GameObject.Find("Ball").transform.position.y < -14)
                {

                    Vector3 pos = new Vector3(76, -23.5f, -25);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 6;
                }
                if (GameObject.Find("Ball").transform.position.y > 25)
                {

                    Vector3 pos = new Vector3(76, 44, -42);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 7;
                }
            }

            if (stage == 6)
            {
                if (GameObject.Find("Ball").transform.position.y > -14)
                {
                    Vector3 pos = new Vector3(76, 7, -35);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 5;
                }
            }
            if (stage == 7)
            {
                if (GameObject.Find("Ball").transform.position.y < 25)
                {
                    Vector3 pos = new Vector3(76, -23.5f, -25);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 6;
                }
            }
        }

        else if (name == "Level3")
        {

            if (stage == 1)
            {
                if (GameObject.Find("Ball").transform.position.x > 11)
                {
                    if (GameObject.Find("Ball").transform.position.x > 8 && GameObject.Find("Ball").transform.position.y > 0)
                    {
                        Vector3 pos = new Vector3(0, 8.5f, -26);
                        StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                        stage = 3;
                    }
                    if (GameObject.Find("Ball").transform.position.x > 8 && GameObject.Find("Ball").transform.position.y < 0)
                    {
                        Vector3 pos = new Vector3(0, -8.5f, -26);
                        StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                        stage = 4;
                    }
                }
            }
            if (stage == 3)
            {
                if (GameObject.Find("Ball").transform.position.y < 7 && GameObject.Find("Ball").transform.position.x < 8 && GameObject.Find("Ball").transform.position.x > -8)
                {
                    Vector3 pos = new Vector3(0, 0, -17);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 1;
                }
                if (GameObject.Find("Ball").transform.position.x > 8 && GameObject.Find("Ball").transform.position.y < 0)
                {
                    Vector3 pos = new Vector3(0, -8.5f, -26);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 4;
                }
                else if (GameObject.Find("Ball").transform.position.x < -22)
                {
                    Vector3 pos = new Vector3(0, 18, -43);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 6;
                }
            }
            if (stage == 4)
            {
                if (GameObject.Find("Ball").transform.position.y > 6 && GameObject.Find("Ball").transform.position.x < 8 && GameObject.Find("Ball").transform.position.x > -8)
                {
                    Vector3 pos = new Vector3(0, 0, -17);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 1;
                }
                if (GameObject.Find("Ball").transform.position.x > 8 && GameObject.Find("Ball").transform.position.y > 0)
                {
                    Vector3 pos = new Vector3(0, 8.5f, -26);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 3;
                }
            }

            if (stage == 6)
            {
                if (GameObject.Find("Ball").transform.position.y < 15 && GameObject.Find("Ball").transform.position.x > -22 && GameObject.Find("Ball").transform.position.x < 15)
                {
                    Vector3 pos = new Vector3(0, 8.5f, -26);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 3;
                }
                if (GameObject.Find("Ball").transform.position.x > 35)
                {
                    Vector3 pos = new Vector3(50, -6, -34);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 7;
                }
            }
            if (stage == 7)
            {
                if (GameObject.Find("Ball").transform.position.y > 15)
                {
                    Vector3 pos = new Vector3(0, 18, -43);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 6;
                }
                if (GameObject.Find("Ball").transform.position.y < -25)
                {
                    Vector3 pos = new Vector3(0, -20, -40);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 8;
                }
            }
            if (stage == 8)
            {
                if (GameObject.Find("Ball").transform.position.y > 1)
                {
                    Vector3 pos = new Vector3(50, -6, -34);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 7;
                }
                if (GameObject.Find("Ball").transform.position.x < -36)
                {
                    Vector3 pos = new Vector3(-48, 6, -40);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 9;
                }
            }
            if (stage == 9)
            {
                if (GameObject.Find("Ball").transform.position.x > -36)
                {
                    Vector3 pos = new Vector3(0, -20, -40);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.10f));
                    stage = 8;
                }
            }
        }
        else if (name == "Level4")
        {
            if (stage == 1)
            {
                if (GameObject.Find("Ball").transform.position.y > 13)
                {
                    Vector3 pos = new Vector3(0, 15, -56);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.1f));
                    stage = 2;
                }
                if (GameObject.Find("Ball").transform.position.y < -13)
                {
                    Vector3 pos = new Vector3(0, -15, -56);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.1f));
                    stage = 3;
                }
            }
            if (stage == 2)
            {
                if (GameObject.Find("Ball").transform.position.y < 13)
                {
                    Vector3 pos = new Vector3(0, -0.5f, -75);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.1f));
                    stage = 1;
                }
            }
            if (stage == 3)
            {
                if (GameObject.Find("Ball").transform.position.y > -13)
                {
                    Vector3 pos = new Vector3(0, -0.5f, -75);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.1f));
                    stage = 1;
                }
            }
        }
        else if (name == "Level5")
        {
            if (stage == 1)
            {
                if (GameObject.Find("Ball").transform.position.x < -10)
                {
                    Vector3 pos = new Vector3(-57, 2.5f, -75);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.1f));
                    stage = 2;
                }
            }
            if (stage == 2)
            {
                if (GameObject.Find("Ball").transform.position.x > -10)
                {
                    Vector3 pos = new Vector3(25, 2.5f, -75);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.1f));
                    stage = 1;
                }

                if (GameObject.Find("Ball").transform.position.x < -84)
                {
                    Vector3 pos = new Vector3(-25, 2.5f, -105);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.1f));
                    stage = 3;
                }
            }
            if (stage == 3)
            {
                if (GameObject.Find("Ball").transform.position.x > -84)
                {
                    Vector3 pos = new Vector3(-9, 2.5f, -85);
                    StartCoroutine(MoveToPosition(gameObject.transform, pos, 0.1f));
                    stage = 4;
                }
            }
        }
    }
    public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove)
    {
        cameraMoving = true;
        var currentPos = transform.position;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
        cameraMoving = false;
    }
}
