using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
public class TextBehaviourScript : MonoBehaviour
{
    private Animator animator;
    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        string name = UnitySceneManager.GetActiveScene().name;
        if (name == "Level1")
        {
            if (Input.GetKeyDown(KeyCode.Space)) animator.SetBool("space", true);
        }
        else if (name == "Level5")
        {
            if (active)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -10);
            }
        }
    }
}
