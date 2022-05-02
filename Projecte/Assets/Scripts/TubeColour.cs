using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class TubeColour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name = UnitySceneManager.GetActiveScene().name;

        if (gameObject.tag == "Red")
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.red);
        }
        if (gameObject.tag == "Blue")
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.blue);
        }
        if (gameObject.tag == "Green")
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.green);
        }
        if (gameObject.tag == "Yellow")
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.yellow);
        }

        if ((gameObject.tag == "enemy" && name == "Level1") || gameObject.tag == "White")
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.white);
        }
        if ((gameObject.tag == "enemy" && name == "Level2"))
        {
            Color brown = new Color(0.478f, 0.278f, 0.101f);
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", brown);
        }
        if (gameObject.tag == "Key" && name == "Level2" || (gameObject.tag == ("enemy") && name == "Level5"))
        {
            Color brown = new Color(0.478f, 0.278f, 0.101f);
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", brown);
        }

        if (gameObject.tag == "Key" && name == "Level3")
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.black);
        }
        if (gameObject.tag == "KeySnake" && name == "Level2" || (gameObject.tag == ("Key") && name == "Level5"))
        {
            Color gold = new Color(0.976f, 0.847f, 0.282f);
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", gold);
        }

        if (gameObject.tag == "Coin")
        {
            Color brown = new Color(0.976f, 0.847f, 0.282f);
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", brown);
        }
        if ((gameObject.tag == "enemy" && name == "Level3"))
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.black);
        }
        if ((gameObject.name == "KeyBlue"))
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.blue);
        }
        if ((gameObject.name == "KeyRed"))
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.red);
        }
        if ((gameObject.name == "KeyGreen"))
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.green);
        }
        if ((gameObject.name == "KeyYellow"))
        {
            var renderer = gameObject.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.yellow);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
