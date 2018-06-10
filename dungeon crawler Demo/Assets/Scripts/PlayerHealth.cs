using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public static PlayerHealth Instance;


    [Tooltip("Below this percentage, the player will be considered injured")]
    public float FirstHealthWarningPerventage;
    [Tooltip("Below this percentage, the player will be considered at low health")]
    public float LowHealthWarningPercentage;


    public float PhysRes;
    public float MagiRes;
    


    private bool Alive;
    private float RealCurrenthealth = 100;
    private float RealMaxhealth = 100;
    private float PercentageCurrentHealth;



	// Use this for initialization
	void Start ()
    {
        Instance = this;

    }
	
	// Update is called once per frame
	void Update ()
    {
        HealthChecker();
	}

    public void TakePhysicalHit(float RawDamage)
    {
        Debug.Log("Took a hit");
    }

    public void TakemagicalHit(float RawDamage)
    {
        Debug.Log("Took a magical hit");
    }

    void HealthChecker()
    {
        //calculate % health
        PercentageCurrentHealth = RealCurrenthealth / RealMaxhealth * 100 / 1;


        //check our percentage health if its below the other markers do something
        if (PercentageCurrentHealth < FirstHealthWarningPerventage)
        {
            Debug.Log("We dropped below first health % threshold");
        }
        if (PercentageCurrentHealth < LowHealthWarningPercentage)
        {
            Debug.Log("We dropped below second health % threshold");
        }




        // are we dead yet? please?!
        if (RealCurrenthealth <= 0)
        {
            Died();
        }
    }

    void Died()
    {
        Debug.Log("We died");
    }
}
