using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee : MonoBehaviour {

    // get access to the animator
    // get animator states information
    // assign the current animator state information to the animator
    // get access to the animations you want to use

    static int swing1 = Animator.StringToHash("Swinging.swing1");
    static int swing2 = Animator.StringToHash("Swinging.swing2");
    static int idle = Animator.StringToHash("Swinging.idle");

    private Animator anim;

    private AnimatorStateInfo swingState;

	// Use this for initialization
	void Start ()
    {
        anim = this.GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {

        swingState = anim.GetCurrentAnimatorStateInfo(3);

        
		
	}

    private void FixedUpdate()
    {
        meleeCom();
    }

    void meleeCom()
    {
        if(swingState.nameHash == idle && Input.GetKeyDown("j"))
        {
            anim.SetBool("swing1", true);
            Debug.Log("swinging");
        }
        else
        {
            anim.SetBool("swing1", false);
        }

        if(swingState.nameHash == swing1 && Input.GetKeyDown("j"))
        {
            anim.SetBool("swing2", true);
        }
        else
        {
            anim.SetBool("swing2", false);
        }

        if(swingState.nameHash == swing2 && Input.GetKeyDown("j"))
        {
            anim.SetBool("swing1", true);
        }
    }
}
