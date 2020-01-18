using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmSize : MonoBehaviour {


    public GameObject[] arm;
    public float x;
    public float z;
    public int armWidth;
    
    

    // Use this for initialization
    void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update ()
    {

        foreach(GameObject arm in arm)
        {
            x = arm.transform.localScale.x;
            z = arm.transform.localScale.z;

            if (Input.GetKeyDown("g"))
            {
                arm.transform.localScale += new Vector3(0.1f, 0, 0.1f);
                Debug.Log("this is from the Armsize script");
            }
        }
      





        if (x == 0.1f && z == 0.1f)
        {
            armWidth = 10;
        }

        if (x == 0.2f && z == 0.2f)
        {
            armWidth = 20;
        }

        if (x == 0.3f && z == 0.3f)
        {
            armWidth = 30;
        }

        if (x == 0.4f && z == 0.4f)
        {
            armWidth = 40;
        }




      
    }
}
        


