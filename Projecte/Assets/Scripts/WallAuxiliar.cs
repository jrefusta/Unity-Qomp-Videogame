using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAuxiliar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Ball").transform.position.y < -8 && GameObject.Find("Ball").transform.position.x  > -10 && GameObject.Find("Ball").transform.position.x < 10)
        {
            Vector3 pos = new Vector3(gameObject.transform.position.x, -15.5f, gameObject.transform.position.z);
            StartCoroutine(MoveToPosition(gameObject.transform, pos, 1f));
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
}
