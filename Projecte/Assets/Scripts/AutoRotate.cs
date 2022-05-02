using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Coin") transform.Rotate(Vector3.right * 300 * Time.deltaTime);
        else if (gameObject.tag == "Key" || gameObject.tag == "KeySnake") transform.Rotate(Vector3.up * 300 * Time.deltaTime);
    }
}
