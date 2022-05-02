using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
public class BallSpikeMovement : MonoBehaviour
{
    int speedPos = 15;
    bool collision = false;
    int speedRot = 200;
    private bool stop = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string name = UnitySceneManager.GetActiveScene().name;


        if (name == "Level1")
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.white);
        }
        if (name == "Level3" || name == "Level4" || name == "Level5")
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.black);
        }

        if (name == "Level2")
        {
            Color brown = new Color(0.478f, 0.278f, 0.101f);
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", brown);
        }

        if (name != "Level5")
        {
            if (collision && speedPos < 0)
            {
                speedPos *= -1;
                speedRot *= -1;
                collision = false;
            }
            if (collision && speedPos > 0)
            {
                speedPos *= -1;
                speedRot *= -1;
                collision = false;
            }

        }
        else
        {
            speedPos = speedRot = 0;
            if (!stop) {
            if (GameObject.Find("Key").GetComponent<KeyBehaviour>().taken)
                {
                    speedPos = 15;
                    speedRot = 200;
                    if (gameObject.transform.position.y < 40 && gameObject.transform.position.y > -35)
                    {
                        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 1);
                    }
                    if (gameObject.name == "LastSpikeBall")
                    {
                        if (gameObject.transform.position.y > 10) stop = true;
                    }
                    else
                    {
                        if (gameObject.transform.position.y < 6 && gameObject.transform.position.y > 0) stop = true;
                    }
                }
            }
        }
        gameObject.transform.Translate(speedPos * Time.deltaTime, 0, 0);
        gameObject.transform.Rotate(Vector3.right * speedRot * Time.deltaTime);
    }
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "map" || collisionInfo.collider.tag == "enemy") collision = true;
    }
}
