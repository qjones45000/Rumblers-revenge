using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIdetect : MonoBehaviour
{

    // search for enemies with a tag enemie
    // identify if there an eenemy

    GameObject[] enemies;
    public float distance = 110f;
    private CapsuleCollider col;
    private Animator anim;

    

    private NavMeshAgent nav;

	// Use this for initialization
	void Start ()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
       


         

        

        

	}


    private void FixedUpdate()
    {



        detect();

    }

    void detect()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemies");

        foreach(GameObject target in enemies)
        {
            var fwd = transform.TransformDirection(Vector3.forward);

            RaycastHit hit;

            Ray ray = new Ray(this.transform.position + transform.up, fwd);

            Debug.DrawLine(transform.position + transform.up, transform.position + fwd * distance, Color.red);

            float angle = Vector3.Angle(Vector3.forward, transform.InverseTransformPoint(target.transform.position));
            float dist = Vector3.Distance(this.transform.position, target.transform.position);

            if (angle < 360/2f && dist < 50)
            {

                nav.SetDestination(target.transform.position);
                anim.SetFloat("Forward", 1, 0.1f, Time.deltaTime);

                if (Physics.Raycast(ray, out hit, distance))
                {
                    if (hit.collider.tag == "enemies")
                    {
                        Debug.Log("imma fuck you up");

                       
                    }
                }
            }
            else
            {
                anim.SetFloat("Forward", 0, 0, Time.deltaTime);
            }
        }



     
    }

}
