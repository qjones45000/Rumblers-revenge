using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray1 : MonoBehaviour
{

    private RaycastHit hit;
    public float range;
    public float radius;
    public GameObject hand;

    
    public Transform endPos;

    private float time;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown("q"))
        {
            areaBlast();
        }

        if (Input.GetKeyDown("f"))
        {
            percisionBlast();
        }

        if (Input.GetKey("e"))
        {
            attract();
        }

        if(Input.GetKeyDown("r"))
        {
            attract2();
        }

    }

    void areaBlast()
    {
        Vector3 center = this.transform.position;


        Collider[] collider = Physics.OverlapSphere(center, radius);

        foreach (Collider objecta in collider)
        {
            if (objecta.CompareTag("Moveable"))
            {
                Rigidbody rb = objecta.GetComponent<Rigidbody>();

                rb.AddExplosionForce(500, center, 500);
            }

        }

    }

    void percisionBlast()
    {
        var fwd = transform.TransformDirection(Vector3.forward);



        // cast ray


        //check if ray collided
        if (Physics.Raycast(hand.transform.position, hand.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);

            if (hit.rigidbody != null)
            {
                Debug.Log("hit");
                hit.rigidbody.AddExplosionForce(500, fwd, 5000);
            }

        }

    }

    void superBlast()
    {

    }

    void attract()
    {

        Collider[] col = Physics.OverlapSphere(transform.position, 500);

        foreach (Collider collide in col)
        {
            if (collide.CompareTag("Moveable"))
            {

                var fwd = transform.TransformDirection(Vector3.back);

                var pos1 = this.transform.position;
                var pos2 = endPos.transform.position;

                time += Time.deltaTime;

                var dir = Vector3.Lerp(pos1, pos2, time);

                

                Rigidbody rigb = collide.GetComponent<Rigidbody>();

                // rigb.transform.position = this.transform.position;

                Vector3 direction = (this.transform.position + collide.transform.position);

                //rigb.transform.position += fwd;

                if(direction.magnitude == 0.4f)
                {

                }

            }
        }
    }

    void attract2()
    {

        Collider[] col = Physics.OverlapSphere(transform.position, 500);

        foreach (Collider collide in col)
        {
            if (collide.CompareTag("Moveable"))
            {
                Rigidbody rigb = collide.GetComponent<Rigidbody>();

                rigb.transform.position = this.transform.position;

            }
        }
    }

   
}