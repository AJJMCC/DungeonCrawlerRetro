using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text healthUI;
    public Text spellsUI;
    public Slider healthSlider;
    public Slider spellSlider;

    public Text vitalityUI;
    public Text resilienceUI;
    public Text willpowerUI;
    public Text reflexesUI;

    public Text strengthUI;
    public Text cunningUI;
    public Text acuityUI;
    public Text intelligenceUI;

    public Text augeryUI;
    public Text lockpickingUI;
    public Text smithingUI;
    public Text brewingUI;

    public Text physResUI;
    public Text magiResUI;
    public Text critResUI;

    public GameObject SelectSwordButton;
    public GameObject SelecthandButton;
    public GameObject SelectItemButton;
    public GameObject SelectSpellButton;

    public Slider volumeSlider;
    public Text volumeNum;

    public List<GameObject> allMenuObjects;
    public int m_menuObjectActive;

    private GameObject ReadyItem;

    public Color DisabledColour;
    private Color yes = new Color(255, 255, 255, 255);

    private Camera mainCam;

    PlayerStats pStats;

    // Use this for initialization
    void Start()
    {
        mainCam = Camera.main;
        pStats = GameObject.FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

        }
    }

    private void FixedUpdate()
    {
        playerStats();
        VolumeController();
    }

    public void cameraWindow()
    {
        Rect camViewport = Camera.main.rect;
        Vector3 mousePos = Input.mousePosition;
        if (mousePos.x >= camViewport.xMin && mousePos.x <= camViewport.xMax && mousePos.y >= camViewport.yMin && mousePos.y <= camViewport.yMax)
        {
            // do something only when mouse is within the main game window
        }


    }

    public void closeMenus()
    {
        for (int index = 0; index < allMenuObjects.Count; index++)
        {
            allMenuObjects[index].SetActive(false);
            mainCam.rect = new Rect(0, 0.31f, 1, 0.55f);
        }
    }


    public void changeMenu(int m_menuIndex)
    {
        m_menuObjectActive = m_menuIndex;
        for (int index = 0; index < allMenuObjects.Count; index++)
        {
            allMenuObjects[index].SetActive(false);
        }
        StartCoroutine(activateMenus());
    }

    IEnumerator activateMenus()
    {
        allMenuObjects[m_menuObjectActive].SetActive(true);
        mainCam.rect = new Rect(0.4f, 0.31f, 0.55f, 0.55f);
        yield return null;
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

    public void playerStats()
    {
        healthUI.text = " Health: " + pStats.RealCurrenthealth;
        spellsUI.text = " Spells: " + pStats.CurrentSpells;
        healthSlider.value = pStats.RealCurrenthealth;
        spellSlider.value = pStats.CurrentSpells;
        healthSlider.maxValue = pStats.RealMaxhealth;
        spellSlider.maxValue = pStats.MaxSpells;

        vitalityUI.text = "Vitality: " + pStats.vitality;
        resilienceUI.text = "Resilience: " + pStats.resilience;
        willpowerUI.text = "Willpower: " + pStats.willpower;
        reflexesUI.text = "Reflexes: " + pStats.reflexes;

        strengthUI.text = "Strength: " + pStats.strength;
        cunningUI.text = "Cunning: " + pStats.cunning;
        acuityUI.text = "Acuity: " + pStats.acuity;
        intelligenceUI.text = "Intelligence: " + pStats.intelligence;

        augeryUI.text = "Augery: " + pStats.augery;
        lockpickingUI.text = "Lockpicking: " + pStats.lockpicking;
        smithingUI.text = "Smithing: " + pStats.smithing;
        brewingUI.text = "Brewing: " + pStats.brewing;

        physResUI.text = "Physical: " + pStats.PhysRes;
        magiResUI.text = "Magic: " + pStats.MagiRes;
        critResUI.text = "Critical: " + pStats.CritRes;
    }    

    public void VolumeController()
    {        
        AudioListener.volume = volumeSlider.value;
        volumeNum.text = "" + volumeSlider.value;
    }

    public void quitToDesktop()
    {
        Application.Quit();
    }

    public void quitToMainMenu()
    {
        Application.LoadLevel("Test_MainMenu");
    }

    public void loadMainGame()
    {
        Application.LoadLevel("Test_CharacterController");
    }
}
