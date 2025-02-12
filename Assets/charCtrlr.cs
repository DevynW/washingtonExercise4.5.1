using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charCtrlr : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetBool("burpees", true);

        }

        bool banimRunning = animator.GetBool("burpees");

        if (banimRunning = true && Input.GetKeyUp(KeyCode.B))
        {
            animator.SetBool("burpees", false);
        }
        /*if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetTrigger("burpees");
        }*/

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("crossJump", true);

        }

        bool cJanimRunning = animator.GetBool("crossJump");

        if (cJanimRunning = true && Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool("crossJump", false);
        }

/*        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("crossJump");
        }*/

        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetBool("jumpingJacks", true);
            
        }

        bool jJanimRunning = animator.GetBool("jumpingJacks");

        if ( jJanimRunning = true && Input.GetKeyUp(KeyCode.J))
        {
            animator.SetBool("jumpingJacks", false);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetBool("kettlebellSwing", true);

        }

        bool kSanimRunning = animator.GetBool("kettlebellSwing");

        if (kSanimRunning = true && Input.GetKeyUp(KeyCode.K))
        {
            animator.SetBool("kettlebellSwing", false);
        }
        /*if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("kettlebellSwing");
        }*/
    }
}
