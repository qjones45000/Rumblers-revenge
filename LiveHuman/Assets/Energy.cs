using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    int ATP = 1;
    int CP;
    int ADP;
    int CK;
    int P;

    public Slider energyBar;

	// Use this for initialization
	void Start ()
    {
        energyBar.value = ATP;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnergySource()
    {
       
    }
}
