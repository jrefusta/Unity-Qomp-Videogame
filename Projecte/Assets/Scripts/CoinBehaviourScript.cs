using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviourScript : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GetComponent<BoxCollider>().isTrigger = true;
            animator.applyRootMotion = false;
            animator.SetBool("obtained", true);
        }
    }
}
