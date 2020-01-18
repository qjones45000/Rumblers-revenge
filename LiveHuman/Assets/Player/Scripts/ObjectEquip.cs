using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEquip : MonoBehaviour {

    /*to pick up the object
     if player is within distance of object and on button press
     objects transformation is equal to players hand*/

    public GameObject obj;
    public Transform hand;
    public Rigidbody rb;

    

    // Use this for initialization
    void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {


       
        

	}

    private void FixedUpdate()
    {
        pickUp();
        drop();
    }

    void pickUp()
    {
        //track the distance between the player and the object

        float dist = Vector3.Distance(obj.transform.position, this.transform.position);

        Vector3 distance = this.transform.position - obj.transform.position;

        Debug.Log("bitch" + distance);

        if (dist < 3 && dist > 0 &&  Input.GetKeyDown("n"))
        {
            obj.transform.position = hand.transform.position;
            obj.transform.rotation = hand.transform.rotation;
            obj.transform.parent = hand.transform;

            Destroy(rb);

            var melee = GetComponent<melee>();

            melee.enabled = true;

            var punching = GetComponent<Combat>();
            punching.enabled = false;
           
        }
    }

    void drop()
    {

        if(obj.transform.parent == true && Input.GetKeyDown("b"))
        {

            obj.transform.parent = null;
           rb = obj.AddComponent<Rigidbody>();

            var melee = GetComponent<melee>();
            melee.enabled = false;

            var punching = GetComponent<Combat>();
            punching.enabled = true;
        }

    }
}
