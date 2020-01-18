using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyGian : MonoBehaviour {

    public int liver;
    public int spillOver;
    public int liveMuscTrans;
    public int muscleCal;
    public int calories;
    public Food Edible;
    public ArmSize arm; 


   

	// Use this for initialization
	void Start ()
    {
        calories = Edible.food;
        Debug.Log("Cals:"+calories);
    }
	
	// Update is called once per frame
	void Update ()
    {

      
        liveMuscTrans = calories - 100;
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("food"))
        {
            Insulin();
            Debug.Log("Collided");
        }
    }

    public void Insulin()
    {
        //liver transfer
        if (calories < 100)
        {
            liver = calories;
            Debug.Log(liver + " you have energy stored in your liver");
        }
        else
        {

            liver = 100;
            Debug.Log(liveMuscTrans + " you have energy stored in your muscles");
            Debug.Log("Energy in liver: " + liver);
        }

        //from liver to muscle

        //muscle 1
        if(arm.armWidth == 10)
        {
            if(liveMuscTrans <= 100)
            {
                muscleCal = liveMuscTrans;
                Debug.Log("The muscles have: " + muscleCal);
            }
            else
            {
                muscleCal = 100; 
                spillOver = liveMuscTrans - 100;
                Debug.Log("The Muscles are full: " + muscleCal);
                Debug.Log("SPILL OVER!!!!: " + spillOver);
            }
        }

        //muscle 2

        if(arm.armWidth == 20)
        {
            if (liveMuscTrans <= 200)
            {
                muscleCal = liveMuscTrans;
                Debug.Log("The muscles have: " + muscleCal);
            }
            else
            {
                muscleCal = 200;
                spillOver = liveMuscTrans - 200;
                Debug.Log("The Muscles are full: " + muscleCal);
                Debug.Log("SPILL OVER!!!!: " + spillOver);
            }
        }

        //muscle 3


        if (arm.armWidth == 30)
        {
            if (liveMuscTrans <= 300)
            {
                muscleCal = liveMuscTrans;
                Debug.Log("The muscles have: " + muscleCal);
            }
            else
            {
                muscleCal = 300;
                spillOver = liveMuscTrans - 300;
                Debug.Log("The Muscles are full: " + muscleCal);
                Debug.Log("SPILL OVER!!!!: " + spillOver);
            }
        }

        //muscle 4


        if (arm.armWidth == 40)
        {
            if (liveMuscTrans <= 400)
            {
                muscleCal = liveMuscTrans;
                Debug.Log("The muscles have: " + muscleCal);
            }
            else
            {
                muscleCal = 400;
                spillOver = liveMuscTrans - 400;
                Debug.Log("The Muscles are full: " + muscleCal);
                Debug.Log("SPILL OVER!!!!: " + spillOver);
            }
        }

      
    }
}



    
    
