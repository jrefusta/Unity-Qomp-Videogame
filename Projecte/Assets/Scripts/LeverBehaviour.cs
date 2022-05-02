using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class LeverBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public bool active;// = false;
    public bool move;
    void Start()
    {
        move = false;
        active = false;// move = false;
    }

    // Update is called once per frame
    void Update()
    {
        string name = UnitySceneManager.GetActiveScene().name;
        if (name == "Level3")
        {
            if (gameObject.name == "Lever1")
            {
                if (active)
                {
                    if (move)
                    {
                        StartCoroutine(RotateMe(Vector3.forward, 30, 0.5f, 1));
                        Vector3 pos = new Vector3(GameObject.Find("KeyDoor").transform.position.x, GameObject.Find("KeyDoor").transform.position.y, 1.11f);
                        StartCoroutine(MoveToPosition(GameObject.Find("KeyDoor").transform, pos, 1f));
                        Vector3 posPincho0 = new Vector3(GameObject.Find("Pinchis0").transform.position.x, GameObject.Find("Pinchis0").transform.position.y, 0f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis0").transform, posPincho0, 1f));

                        Vector3 posPincho1 = new Vector3(GameObject.Find("Pinchis1").transform.position.x, GameObject.Find("Pinchis1").transform.position.y, 0f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis1").transform, posPincho1, 1f));
                    }
                }
                else
                {
                    if (move)
                    {
                        StartCoroutine(RotateMe(Vector3.forward, -30, 0.5f, 1));
                        Vector3 pos = new Vector3(GameObject.Find("KeyDoor").transform.position.x, GameObject.Find("KeyDoor").transform.position.y, 0f);
                        StartCoroutine(MoveToPosition(GameObject.Find("KeyDoor").transform, pos, 1f));
                        Vector3 posPincho0 = new Vector3(GameObject.Find("Pinchis0").transform.position.x, GameObject.Find("Pinchis0").transform.position.y, 1.43f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis0").transform, posPincho0, 1f));

                        Vector3 posPincho1 = new Vector3(GameObject.Find("Pinchis1").transform.position.x, GameObject.Find("Pinchis1").transform.position.y, 1.43f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis1").transform, posPincho1, 1f));

                    }
                }

            }
            else if (gameObject.name == "Lever2")
            {
                if (active)
                {
                    if (move)
                    {
                        StartCoroutine(RotateMe(Vector3.forward, 30, 0.5f, 2));
                        Vector3 pos = new Vector3(GameObject.Find("Door1").transform.position.x, GameObject.Find("KeyDoor").transform.position.y, 1.11f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Door1").transform, pos, 1f));

                        Vector3 posPincho2 = new Vector3(GameObject.Find("Pinchis2").transform.position.x, GameObject.Find("Pinchis2").transform.position.y, 0);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis2").transform, posPincho2, 1f));

                        Vector3 posPincho3 = new Vector3(GameObject.Find("Pinchis3").transform.position.x, GameObject.Find("Pinchis3").transform.position.y, 0);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis3").transform, posPincho3, 1f));

                        Vector3 posPincho4 = new Vector3(GameObject.Find("Pinchis4").transform.position.x, GameObject.Find("Pinchis4").transform.position.y, 1.43f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis4").transform, posPincho4, 1f));
                    }
                }
                else
                {
                    if (move)
                    {
                        StartCoroutine(RotateMe(Vector3.forward, -30, 0.5f, 2));
                        Vector3 pos = new Vector3(GameObject.Find("Door1").transform.position.x, GameObject.Find("KeyDoor").transform.position.y, 0f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Door1").transform, pos, 1f));

                        Vector3 posPincho2 = new Vector3(GameObject.Find("Pinchis2").transform.position.x, GameObject.Find("Pinchis2").transform.position.y, 1.43f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis2").transform, posPincho2, 1f));

                        Vector3 posPincho3 = new Vector3(GameObject.Find("Pinchis3").transform.position.x, GameObject.Find("Pinchis3").transform.position.y, 1.43f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis3").transform, posPincho3, 1f));

                        Vector3 posPincho4 = new Vector3(GameObject.Find("Pinchis4").transform.position.x, GameObject.Find("Pinchis4").transform.position.y, 0);
                        StartCoroutine(MoveToPosition(GameObject.Find("Pinchis4").transform, posPincho4, 1f));

                    }
                }

            }
        }

        if (name == "Level4")
        {
            if (gameObject.name == "Lever1")
            {
                if (active)
                {
                    if (move)
                    {
                        StartCoroutine(RotateMe(Vector3.forward, 30, 0.5f, 1));
                        Vector3 pos1 = new Vector3(44.2f, GameObject.Find("Auxiliar1").transform.position.y, GameObject.Find("Auxiliar1").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar1").transform, pos1, 1f));
                        Vector3 pos2 = new Vector3(44.2f, GameObject.Find("Auxiliar2").transform.position.y, GameObject.Find("Auxiliar2").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar2").transform, pos2, 1f));
                        Vector3 pos3 = new Vector3(-44.2f, GameObject.Find("Auxiliar3").transform.position.y, GameObject.Find("Auxiliar3").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar3").transform, pos3, 1f));
                        Vector3 pos4 = new Vector3(-44.2f, GameObject.Find("Auxiliar4").transform.position.y, GameObject.Find("Auxiliar4").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar4").transform, pos4, 1f));
                        //cierran
                        Vector3 pos5 = new Vector3(GameObject.Find("Auxiliar5").transform.position.x, -27.65f,GameObject.Find("Auxiliar5").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar5").transform, pos5, 1f));
                        Vector3 pos6 = new Vector3(GameObject.Find("Auxiliar6").transform.position.x, 27.65f, GameObject.Find("Auxiliar6").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar6").transform, pos6, 1f));
                        Vector3 pos7 = new Vector3(GameObject.Find("Auxiliar7").transform.position.x, 27.65f, GameObject.Find("Auxiliar7").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar7").transform, pos7, 1f));
                        Vector3 pos8 = new Vector3(GameObject.Find("Auxiliar8").transform.position.x, -27.65f, GameObject.Find("Auxiliar8").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar8").transform, pos8, 1f));
                    }
                }
                else
                {
                    if (move)
                    {
                        //cierran
                        StartCoroutine(RotateMe(Vector3.forward, -30, 0.5f, 1));
                        Vector3 pos1 = new Vector3(34.92f, GameObject.Find("Auxiliar1").transform.position.y, GameObject.Find("Auxiliar1").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar1").transform, pos1, 1f));
                        Vector3 pos2 = new Vector3(34.92f, GameObject.Find("Auxiliar2").transform.position.y, GameObject.Find("Auxiliar2").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar2").transform, pos2, 1f));
                        Vector3 pos3 = new Vector3(-34.92f, GameObject.Find("Auxiliar3").transform.position.y, GameObject.Find("Auxiliar3").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar3").transform, pos3, 1f));
                        Vector3 pos4 = new Vector3(-34.92f, GameObject.Find("Auxiliar4").transform.position.y, GameObject.Find("Auxiliar4").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar4").transform, pos4, 1f));
                        //abren
                        Vector3 pos5 = new Vector3(GameObject.Find("Auxiliar5").transform.position.x, -35.4f, GameObject.Find("Auxiliar5").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar5").transform, pos5, 1f));
                        Vector3 pos6 = new Vector3(GameObject.Find("Auxiliar6").transform.position.x, 35.4f, GameObject.Find("Auxiliar6").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar6").transform, pos6, 1f));
                        Vector3 pos7 = new Vector3(GameObject.Find("Auxiliar7").transform.position.x, 35.4f, GameObject.Find("Auxiliar7").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar7").transform, pos7, 1f));
                        Vector3 pos8 = new Vector3(GameObject.Find("Auxiliar8").transform.position.x, -35.4f, GameObject.Find("Auxiliar8").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar8").transform, pos8, 1f));

                    }
                }

            }
            else if (gameObject.name == "Lever2")
            {
                if (active)
                {
                    if (move)
                    {
                        StartCoroutine(RotateMe(Vector3.forward, 30, 0.5f, 2));
                        //abren
                        Vector3 pos1 = new Vector3(44.2f, GameObject.Find("Auxiliar1").transform.position.y, GameObject.Find("Auxiliar1").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar1").transform, pos1, 1f));
                        Vector3 pos4 = new Vector3(-44.2f, GameObject.Find("Auxiliar4").transform.position.y, GameObject.Find("Auxiliar4").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar4").transform, pos4, 1f));
                        Vector3 pos5 = new Vector3(GameObject.Find("Auxiliar5").transform.position.x, -35.4f, GameObject.Find("Auxiliar5").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar5").transform, pos5, 1f));
                        Vector3 pos7 = new Vector3(GameObject.Find("Auxiliar7").transform.position.x, 35.4f, GameObject.Find("Auxiliar7").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar7").transform, pos7, 1f));
                        //cierran
                        Vector3 pos2 = new Vector3(34.92f, GameObject.Find("Auxiliar2").transform.position.y, GameObject.Find("Auxiliar2").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar2").transform, pos2, 1f));
                        Vector3 pos3 = new Vector3(-34.92f, GameObject.Find("Auxiliar3").transform.position.y, GameObject.Find("Auxiliar3").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar3").transform, pos3, 1f));
                        Vector3 pos6 = new Vector3(GameObject.Find("Auxiliar6").transform.position.x, 35.4f, GameObject.Find("Auxiliar6").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar6").transform, pos6, 1f));
                        Vector3 pos8 = new Vector3(GameObject.Find("Auxiliar8").transform.position.x, -35.4f, GameObject.Find("Auxiliar8").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar8").transform, pos8, 1f));
                    }
                }
                else
                {
                    if (move)
                    {
                        StartCoroutine(RotateMe(Vector3.forward, -30, 0.5f, 2));
                        //abren
                        Vector3 pos2 = new Vector3(44.2f, GameObject.Find("Auxiliar2").transform.position.y, GameObject.Find("Auxiliar2").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar2").transform, pos2, 1f));
                        Vector3 pos3 = new Vector3(-44.2f, GameObject.Find("Auxiliar3").transform.position.y, GameObject.Find("Auxiliar3").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar3").transform, pos3, 1f));
                        Vector3 pos6 = new Vector3(GameObject.Find("Auxiliar6").transform.position.x, 35.4f, GameObject.Find("Auxiliar6").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar6").transform, pos6, 1f));
                        Vector3 pos8 = new Vector3(GameObject.Find("Auxiliar8").transform.position.x, -35.4f, GameObject.Find("Auxiliar8").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar8").transform, pos8, 1f));
                        //cierran
                        Vector3 pos1 = new Vector3(34.92f, GameObject.Find("Auxiliar1").transform.position.y, GameObject.Find("Auxiliar1").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar1").transform, pos1, 1f));
                        Vector3 pos4 = new Vector3(-34.92f, GameObject.Find("Auxiliar4").transform.position.y, GameObject.Find("Auxiliar4").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar4").transform, pos4, 1f));
                        Vector3 pos5 = new Vector3(GameObject.Find("Auxiliar5").transform.position.x, -35.4f, GameObject.Find("Auxiliar5").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar5").transform, pos5, 1f));
                        Vector3 pos7 = new Vector3(GameObject.Find("Auxiliar7").transform.position.x, 27.65f, GameObject.Find("Auxiliar7").transform.position.z);
                        StartCoroutine(MoveToPosition(GameObject.Find("Auxiliar7").transform, pos7, 1f));

                    }
                }

            }
        }
        if (name == "Level5")
        {
            if (active)
            {
                if (move)
                {
                    StartCoroutine(RotateMe(Vector3.forward, 30, 0.5f, 1));
                    //abren
                    Vector3 pos0 = new Vector3(GameObject.Find("DoorKey").transform.position.x, GameObject.Find("DoorKey").transform.position.y, 1f);
                    StartCoroutine(MoveToPosition(GameObject.Find("DoorKey").transform, pos0, 1f));

                    Vector3 pos1 = new Vector3(GameObject.Find("Door1").transform.position.x, GameObject.Find("Door1").transform.position.y, 10);
                    StartCoroutine(MoveToPosition(GameObject.Find("Door1").transform, pos1, 1f));
                    Vector3 pos2 = new Vector3(GameObject.Find("Door2").transform.position.x, GameObject.Find("Door2").transform.position.y, 10);
                    StartCoroutine(MoveToPosition(GameObject.Find("Door2").transform, pos2, 1f));
                    Vector3 pos3 = new Vector3(GameObject.Find("Door3").transform.position.x, GameObject.Find("Door3").transform.position.y, 10);
                    StartCoroutine(MoveToPosition(GameObject.Find("Door3").transform, pos3, 1f));
                    Vector3 pos4 = new Vector3(GameObject.Find("Door4").transform.position.x, GameObject.Find("Door4").transform.position.y, 10);
                    StartCoroutine(MoveToPosition(GameObject.Find("Door4").transform, pos4, 1f));
                }
            }
            else
            {
                if (move)
                {
                    StartCoroutine(RotateMe(Vector3.forward, -30, 0.5f, 1));
                    //abren
                    Vector3 pos0 = new Vector3(GameObject.Find("DoorKey").transform.position.x, GameObject.Find("DoorKey").transform.position.y, 10);
                    StartCoroutine(MoveToPosition(GameObject.Find("DoorKey").transform, pos0, 1f));

                    Vector3 pos1 = new Vector3(GameObject.Find("Door1").transform.position.x, GameObject.Find("Door1").transform.position.y, 1);
                    StartCoroutine(MoveToPosition(GameObject.Find("Door1").transform, pos1, 1f));
                    Vector3 pos2 = new Vector3(GameObject.Find("Door2").transform.position.x, GameObject.Find("Door2").transform.position.y, 1);
                    StartCoroutine(MoveToPosition(GameObject.Find("Door2").transform, pos2, 1f));
                    Vector3 pos3 = new Vector3(GameObject.Find("Door3").transform.position.x, GameObject.Find("Door3").transform.position.y, 1);
                    StartCoroutine(MoveToPosition(GameObject.Find("Door3").transform, pos3, 1f));
                    Vector3 pos4 = new Vector3(GameObject.Find("Door4").transform.position.x, GameObject.Find("Door4").transform.position.y, 1);
                    StartCoroutine(MoveToPosition(GameObject.Find("Door4").transform, pos4, 1f));

                }
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!move)
            {
                active = !active;
                move = true;
            }
            //GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove)
    {
        var currentPos = transform.position;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
        move = false;
    }
    IEnumerator RotateMe(Vector3 axis, int angle, float inTime, int name)
    {
        var fromAngle = GameObject.Find("Handle" + name).transform.rotation;
        var toAngle = Quaternion.Euler(GameObject.Find("Handle" + name).transform.eulerAngles + axis * angle);
        for (var t = 0f; t <= 1; t += Time.deltaTime / inTime)
        {
            GameObject.Find("Handle" + name).transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
        //GameObject.Find("Handle" + name).transform.rotation = Quaternion.Euler(0, 0, angle);
        //yield return null;
        move = false;
    }
}
