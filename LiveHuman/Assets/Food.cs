using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    public int food;

	// Use this for initialization
	void Start ()
    {
        food = Random.Range(0, 1000);
        Debug.Log("Food: " + food);
    }
	
	// Update is called once per frame
	void Update ()
    {
  
    }
}
