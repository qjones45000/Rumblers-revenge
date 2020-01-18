using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour {

    private Animator anim;

    private AnimatorStateInfo punchingState;
    private AnimatorStateInfo kickingstate;
    

    static int jab1 = Animator.StringToHash("Punching.punch1");
    static int jab2 = Animator.StringToHash("Punching.punch2");

    static int idle = Animator.StringToHash("Punching.idle");

    static int kick1 = Animator.StringToHash("Kicking.kick1");


    // Use this for initialization
    void Start ()
    {
        anim = this.GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        punchingState = anim.GetCurrentAnimatorStateInfo(1);
        kickingstate = anim.GetCurrentAnimatorStateInfo(1);

        Punch();
        kick();
	}

    void Punch()
    {
        if(punchingState.nameHash == idle && Input.GetKeyDown("j"))
        {
            anim.SetBool("Punch1", true);
           
        }
        else
        {
            anim.SetBool("Punch1", false);
        }

        if(punchingState.nameHash == jab1 && Input.GetKeyDown("j"))
        {
            anim.SetBool("Punch2", true);
            anim.SetBool("Punch1", false);
        }
        else
        {
            anim.SetBool("Punch2", false);
        }

      if(punchingState.nameHash == jab2 && Input.GetKeyDown("j"))
        {
            anim.SetBool("Punch1", true);
            anim.SetBool("idle", false);
        }
      else
        {
            anim.SetBool("idle", true);
           
        }

    
    }

    void kick()
    {
        if(kickingstate.nameHash == idle && Input.GetKeyDown("k"))
        {
            anim.SetBool("Kick1", true);
            Debug.Log("kicking but not working");
        }
        else
        {
            
            anim.SetBool("Kick1", false);
        }
    }
}
