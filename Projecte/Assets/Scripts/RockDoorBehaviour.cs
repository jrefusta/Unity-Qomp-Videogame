using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDoorBehaviour : MonoBehaviour
{
    private bool moved;
    private AudioSource source;
    private AudioClip closingIdol;
    // Start is called before the first frame update
    void Start()
    {
        moved = false;
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        source = audioSources[0];
        closingIdol = audioSources[0].clip;
        if (GameObject.Find("Ball").transform.position.x < -10)
        {
            if (!moved)
            {
                source.PlayOneShot(closingIdol);
                GameObject.Find("Lever1").GetComponent<LeverBehaviour>().active = true;
                GameObject.Find("Lever1").GetComponent<LeverBehaviour>().move = true;
                Vector3 pos = new Vector3(-3.94f, 27.88f, 0.12f);
                StartCoroutine(MoveToPosition(gameObject.transform, pos, 1f));
                StartCoroutine(RotateMe(Vector3.left, 30, 1f, "RockDoor"));
                moved = true;
            }
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
    }
    IEnumerator RotateMe(Vector3 axis, int angle, float inTime, string name)
    {
        var fromAngle = GameObject.Find(name).transform.rotation;
        var toAngle = Quaternion.Euler(GameObject.Find(name).transform.eulerAngles + axis * angle);
        for (var t = 0f; t <= 1; t += Time.deltaTime / inTime)
        {
            GameObject.Find(name).transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
        //GameObject.Find(name).transform.rotation = Quaternion.Euler(angle, 0, 0);
    }
}

