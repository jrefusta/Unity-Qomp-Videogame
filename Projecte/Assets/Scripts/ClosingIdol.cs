using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingIdol : MonoBehaviour
{
    // Start is called before the first frame update
    private int animationStage;
    private AudioSource source;
    private AudioClip closingIdol;
    private bool closed;
    void Start()
    {
        closed = false;
        animationStage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        source = audioSources[0];
        closingIdol = audioSources[0].clip;
        if (GameObject.Find("Ball").transform.position.x > 60)
        {

            if (animationStage == 0)
            {
                Vector3 pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0.0f);
                StartCoroutine(MoveToPosition(gameObject.transform, pos, 1f));
                ++animationStage;
            }
            else if (animationStage == 1)
            {
                if (!closed) { source.PlayOneShot(closingIdol); closed = true; }
                StartCoroutine(RotateMe(Vector3.right, 90, 1f));
                ++animationStage;
            }
        }
        
    }
    IEnumerator RotateMe(Vector3 axis, int angle, float inTime)
    {
        yield return new WaitForSeconds(1);
        var fromAngle = gameObject.transform.rotation;
        var toAngle = Quaternion.Euler(gameObject.transform.eulerAngles + axis * angle);
        for (var t = 0f; t <= 1; t += Time.deltaTime / inTime)
        {
            gameObject.transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        yield return null;
    }

    public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove)
    {
        var currentPos = transform.position;
        Debug.Log(position);
        Debug.Log(currentPos);
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            gameObject.transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
    }
}
