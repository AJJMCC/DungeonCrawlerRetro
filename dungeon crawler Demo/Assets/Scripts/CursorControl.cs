using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour {

    public static CursorControl Instance;

    //Cursor check distance
    public float distance = 50f;

    public Texture2D AttackCursor;
    public Texture2D HandCursor;
    public Sprite ItemCursor;

    bool WeaponActiveTime;
    bool HandActiveTime;

	// Use this for initialization
	void Start ()
    {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckForClicks();

    }

    void CheckForClicks()
    {

        
        if (Input.GetMouseButtonDown(0))
        {
            if (WeaponActiveTime)
            {

            }

            if (HandActiveTime)
            {
                //create a ray cast and set it to the mouses cursor position in game
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, distance))
                {
                    //draw invisible ray cast/vector
                    Debug.DrawLine(ray.origin, hit.point);
                    //log hit area to the console
                    Debug.Log(hit.collider);

                    if (hit.collider.gameObject.layer != 5)
                        {
                        ClickedOnSomething(hit.collider.gameObject);
                        }
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (WeaponActiveTime)
            {
            }
        }
        

       
          
    }

    void ClickedOnSomething(GameObject something)
    {

    }


    public void WeaponActive()
    {
        Cursor.SetCursor(AttackCursor,Vector2.zero, CursorMode.Auto);
    }

    public void InteractActive()
    {
        Cursor.SetCursor(HandCursor, Vector2.zero, CursorMode.Auto);
    }
}
