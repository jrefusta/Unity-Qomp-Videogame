using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class KeyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private float velocityClose = 1f;
    private int idolID;
    private int animationStage;
    private Animator animator;
    public bool taken;
    private bool snake;
    private int keysSnake;

    void Start()
    {
        taken = false;
        idolID = -1;
        animationStage = 0;
        snake = false;
        keysSnake = 0;
    }

    // Update is called once per frame
    void Update()
    {
        string name = UnitySceneManager.GetActiveScene().name;
        if (name == "Level2")
        {
            if (idolID > -1)
            {
                openIdolDoor(idolID);
            }
            if (keysSnake == 3)
            {
                snake = true;
            }
        }
        animator = GetComponent<Animator>();

    }
    void OnCollisionEnter(Collision collision)
    {
        string name = UnitySceneManager.GetActiveScene().name;

        if (name == "Level1")
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                //GameObject.Find("Key").transform.position = new Vector3(GameObject.Find("Key").transform.position.x, GameObject.Find("Key").transform.position.y, 10f);
                Vector3 pos = new Vector3(56, GameObject.Find("Door").transform.position.y, GameObject.Find("Door").transform.position.z);
                StartCoroutine(MoveToPosition(GameObject.Find("Door").transform, pos, 1f));
            }
            GetComponent<BoxCollider>().isTrigger = true;
            animator.applyRootMotion = false;
            animator.SetBool("obtained", true);
        }
        if (name == "Level2")
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                if (gameObject.name == "Key0")
                {
                    //GameObject.Find("Key0").transform.position = new Vector3(GameObject.Find("Key0").transform.position.x, GameObject.Find("Key0").transform.position.y, 2f);
                    idolID = 0;
                }
                if (gameObject.name == "Key1")
                {
                    keysSnake += 1;
                    //GameObject.Find("Key1").transform.position = new Vector3(GameObject.Find("Key0").transform.position.x, GameObject.Find("Key0").transform.position.y, 2f);
                    idolID = 1;
                }
                if (gameObject.name == "Key2")
                {
                    keysSnake += 1;
                    //GameObject.Find("Key2").transform.position = new Vector3(GameObject.Find("Key0").transform.position.x, GameObject.Find("Key0").transform.position.y, 2f);
                    idolID = 2;
                }
                if (gameObject.name == "Key3")
                {
                    keysSnake += 1;
                    //GameObject.Find("Key3").transform.position = new Vector3(GameObject.Find("Key0").transform.position.x, GameObject.Find("Key0").transform.position.y, 2f);
                    idolID = 3;
                }
                GetComponent<BoxCollider>().isTrigger = true;
                animator.applyRootMotion = false;
                animator.SetBool("obtained", true);
            }
        }
        else if (name == "Level3")
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                if (gameObject.name == "Key0")
                {
                    //GameObject.Find("Key0").transform.position = new Vector3(GameObject.Find("Key0").transform.position.x, GameObject.Find("Key0").transform.position.y, 2f);
                    Vector3 pos = new Vector3(GameObject.Find("Door0").transform.position.x, GameObject.Find("Door0").transform.position.y, 1.11f);
                    StartCoroutine(MoveToPosition(GameObject.Find("Door0").transform, pos, 1f));
                }
                GetComponent<BoxCollider>().isTrigger = true;
                animator.applyRootMotion = false;
                animator.SetBool("obtained", true);
            }
        }
        else if (name == "Level4")
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                if (gameObject.name == "KeyRed")
                {
                    //GameObject.Find("KeyRed").transform.position = new Vector3(GameObject.Find("KeyRed").transform.position.x, GameObject.Find("KeyRed").transform.position.y, 2f);

                    StartCoroutine(RotatePipe(Vector3.up, -180, 3f, "PipeRed1"));
                    StartCoroutine(RotatePipe(Vector3.up, 180, 3f, "PipeRed2"));
                }
                if (gameObject.name == "KeyBlue")
                {
                    //GameObject.Find("KeyBlue").transform.position = new Vector3(GameObject.Find("KeyBlue").transform.position.x, GameObject.Find("KeyBlue").transform.position.y, 2f);

                    StartCoroutine(RotatePipe(Vector3.up, -180, 3f, "PipeBlue1"));
                    StartCoroutine(RotatePipe(Vector3.up, 180, 3f, "PipeBlue2"));
                }
                if (gameObject.name == "KeyGreen")
                {
                    //GameObject.Find("KeyGreen").transform.position = new Vector3(GameObject.Find("KeyGreen").transform.position.x, GameObject.Find("KeyGreen").transform.position.y, 2f);

                    StartCoroutine(RotatePipe(Vector3.up, -180, 3f, "PipeGreen1"));
                    StartCoroutine(RotatePipe(Vector3.up, 180, 3f, "PipeGreen2"));
                }
                if (gameObject.name == "KeyYellow")
                {
                    //GameObject.Find("KeyYellow").transform.position = new Vector3(GameObject.Find("KeyYellow").transform.position.x, GameObject.Find("KeyYellow").transform.position.y, 2f);

                    StartCoroutine(RotatePipe(Vector3.up, -180, 3f, "PipeYellow1"));
                    StartCoroutine(RotatePipe(Vector3.up, 180, 3f, "PipeYellow2"));
                }
                GetComponent<BoxCollider>().isTrigger = true;
                animator.applyRootMotion = false;
                animator.SetBool("obtained", true);
            }
        }
        else if (name == "Level5")
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                //GameObject.Find("Key").transform.position = new Vector3(GameObject.Find("Key").transform.position.x, GameObject.Find("Key").transform.position.y, 10f);
                Vector3 pos = new Vector3(GameObject.Find("DoorCoin").transform.position.x, 10, GameObject.Find("DoorCoin").transform.position.z);
                StartCoroutine(MoveToPosition(GameObject.Find("DoorCoin").transform, pos, 1f));
                StartCoroutine(RotatePipe(Vector3.left, 120, 1f, "DoorCoin"));
                taken = true;
            }
            GetComponent<BoxCollider>().isTrigger = true;
            animator.applyRootMotion = false;
            animator.SetBool("obtained", true);
        }
    }

     void openIdolDoor(int name)
    {
        switch (animationStage)
        {
            case 0:
                StartCoroutine(RotateMe(Vector3.left, 90, 1f, name));
                animationStage = 1;
                break;
            case 1:
                if (name == 1 || name == 2 || name == 3)
                {
                    if (GameObject.Find("Ball").GetComponent<BallBehaviourScript>().keysSnake == 3)
                    {
                        Vector3 pos = new Vector3(GameObject.Find("Idol" + 1).transform.position.x, GameObject.Find("Idol" + 1).transform.position.y, 2.49f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Idol" + 1).transform, pos, 1f));
                        Vector3 pos2 = new Vector3(GameObject.Find("Idol" + 2).transform.position.x, GameObject.Find("Idol" + 2).transform.position.y, 2.49f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Idol" + 2).transform, pos2, 1f));
                        Vector3 pos3 = new Vector3(GameObject.Find("Idol" + 3).transform.position.x, GameObject.Find("Idol" + 3).transform.position.y, 2.49f);
                        StartCoroutine(MoveToPosition(GameObject.Find("Idol" + 3).transform, pos3, 1f));
                    }
                }
                else
                {
                    Vector3 pos = new Vector3(GameObject.Find("Idol" + idolID).transform.position.x, GameObject.Find("Idol" + idolID).transform.position.y, 2.49f);
                    StartCoroutine(MoveToPosition(GameObject.Find("Idol" + idolID).transform, pos, 1f));
                }
                animationStage = 2;
                break;
            case 2:
                idolID = -1;
                break;
            default:
                break;

        } 
    }

    IEnumerator RotateMe(Vector3 axis, int angle, float inTime, int name)
    {
        var fromAngle = GameObject.Find("Idol" + name).transform.rotation;
        var toAngle = Quaternion.Euler(GameObject.Find("Idol" + name).transform.eulerAngles + axis*angle);
        for (var t = 0f; t <= 1; t += Time.deltaTime / inTime)
        {
            GameObject.Find("Idol" + name).transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
        GameObject.Find("Idol" + name).transform.rotation = Quaternion.Euler(-angle, 0, 0);
        animationStage = 1;
        yield return null;
    }


    IEnumerator RotatePipe(Vector3 axis, int angle, float inTime, string name)
    {
        var fromAngle = GameObject.Find(name).transform.rotation;
        var toAngle = Quaternion.Euler(GameObject.Find(name).transform.eulerAngles + axis * angle);
        for (var t = 0f; t <= 1; t += Time.deltaTime / inTime)
        {
            GameObject.Find(name).transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
        //GameObject.Find(name).transform.rotation = Quaternion.Euler(0, angle, 0);
        animationStage = 1;
        yield return null;
    }

    public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove)
    {
        string name = UnitySceneManager.GetActiveScene().name;
        if (name == "Level2") yield return new WaitForSeconds(1);
        var currentPos = transform.position;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
    }
}
