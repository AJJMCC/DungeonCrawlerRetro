using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    
    public GameObject SelectSwordButton;
    public GameObject SelecthandButton;
    public GameObject SelectItemButton;

    private GameObject ReadyItem;

    public Color DisabledColour;
    private Color yes = new Color(255,255,255,255);

    private bool InvenUp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Q))
        {

        }
	}

    void InvenRaise()
    {
        if (!InvenUp)
        {

        }
    }

    void InvenLower()
    {
        if (InvenUp)
        {

        }
    }


    //stuff to do when the player selects the sword icon
    public void SelectedSword()
    {
        SelectSwordButton.GetComponent<Image>().color = DisabledColour;
        SelecthandButton.GetComponent<Image>().color = yes;
        SelectItemButton.GetComponent<Image>().color = yes;
    }


    //stuff to do when the player selects the hand icon
    public void Selectedhand()
    {
        SelectItemButton.GetComponent<Image>().color = yes;
        SelectSwordButton.GetComponent<Image>().color = yes; 
        SelecthandButton.GetComponent<Image>().color = DisabledColour;
    }



    //the thirs button, items and stuff to do with that
    public void ChangeReadyItem(GameObject ItemToChangeTo)
    {
        ReadyItem = ItemToChangeTo;
    }

    public void SelectedItem()
    {

        if (ReadyItem != null)
        {
            SelectItemButton.GetComponent<Image>().color = DisabledColour;
            SelectSwordButton.GetComponent<Image>().color = yes;
            SelecthandButton.GetComponent<Image>().color = yes;
        }
        
    }
}
