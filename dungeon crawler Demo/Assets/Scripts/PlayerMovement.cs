using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public static PlayerMovement Instance;

    [Tooltip("the transofrm to turn")]
    public Transform PlayerTrans;
    [Tooltip("the rigidbody to move about")]
    public Rigidbody PB;
   

    [Tooltip("how fast we move")]
    public float BaseMoveSpeed;

   


    [Tooltip("how fast we turn")]
    public float BaseTurnSpeed;
    private float YROT;

    [Tooltip("This is so our player controller can disable movement at need")]
    public bool CanPlayerMove = true;
    [Tooltip("This is so our player controller can disable rotation at need")]
    public bool CanPlayerTurn = true;




    // Use this for initialization
    void Start ()
    {
		
	}
	//this setup uses Axis controls instead of keys so later we can support multiple control schemes and it is super simple
	//to change the sluggishness of movement and so on change the horizontal axis input controls 
    //to do that go to: Edit > Project Settings > Input
    //change "Vertical" for movement
    //change "Horizontal" for rotation
	void Update ()
    {
        if (CanPlayerMove)
        MovementChecks();

        if (CanPlayerTurn)
        TurnChecks();
        
    }

    void MovementChecks()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            PB.velocity = PlayerTrans.forward * (BaseMoveSpeed * Input.GetAxis("Vertical")) ;
        }
    }
   
    void TurnChecks()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            YROT += (BaseMoveSpeed * Input.GetAxis("Horizontal"));
            PlayerTrans.rotation = Quaternion.Euler(Vector3.up * YROT);
        }
    }
   
}

