using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    
    public GameObject SelectSwordButton;
    public GameObject SelecthandButton;
    public GameObject SelectItemButton;
    public GameObject SelectSpellButton;

    public GameObject SettingsButton;
    public GameObject InvButton;
    public GameObject StatsButton;
    public GameObject SettingsWindow;
    public GameObject InvWindow;
    public GameObject StatsWindow;

    private GameObject ReadyItem;

    public Color DisabledColour;
    private Color yes = new Color(255,255,255,255);

    private bool InvenUp;
    private bool SettingsUp;
    private bool StatsUp;

    // Use this for initialization
    void Start ()
    {
        InvenUp = false;
        SettingsUp = false;
        StatsUp = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Q))
        {

        }
	}

    public void InvenRaise()
    {
        if (!InvenUp)
        {
            InvWindow.SetActive(true);
            InvenUp = true;
        }
    }

    public void InvenLower()
    {
        if (InvenUp)
        {
            InvWindow.SetActive(false);
            InvenUp = false;
        }
    }

    public void SettingsRaise()
    {
        if (!SettingsUp)
        {
            SettingsWindow.SetActive(true);
            SettingsUp = true;
        }
    }

    public void SettingsLower()
    {
        if (SettingsUp)
        {
            SettingsWindow.SetActive(false);
            SettingsUp = false;
        }
    }

    public void StatsRaise()
    {
        if (!StatsUp)
        {
            StatsWindow.SetActive(true);
            StatsUp = true;
        }
    }

    public void StatsLower()
    {
        if (StatsUp)
        {
            StatsWindow.SetActive(false);
            StatsUp = false;
        }
    }


    //stuff to do when the player selects the sword icon
    public void SelectedSword()
    {
        SelectSwordButton.GetComponent<Image>().color = DisabledColour;
        SelecthandButton.GetComponent<Image>().color = yes;
        SelectItemButton.GetComponent<Image>().color = yes;
        SelectSpellButton.GetComponent<Image>().color = yes;
    }


    //stuff to do when the player selects the hand icon
    public void Selectedhand()
    {
        SelectItemButton.GetComponent<Image>().color = yes;
        SelectSwordButton.GetComponent<Image>().color = yes; 
        SelecthandButton.GetComponent<Image>().color = DisabledColour;
        SelectSpellButton.GetComponent<Image>().color = yes;
    }
    

    //stuff to do when the player selects the spell icon
    public void SelectedSpell()
    {
        SelectItemButton.GetComponent<Image>().color = yes;
        SelectSwordButton.GetComponent<Image>().color = yes;
        SelecthandButton.GetComponent<Image>().color = yes;
        SelectSpellButton.GetComponent<Image>().color = DisabledColour;
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
            SelectSpellButton.GetComponent<Image>().color = yes;
        }
        
    }
}
