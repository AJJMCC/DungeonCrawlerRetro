using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMakerMaster : MonoBehaviour {

    private MapGenScript MapMakerSlave;

    public Transform[] mapObjectAnchorss;

    public Texture2D[] MapTextures;

    private int Level = 0;
    private int CurrentlevelsReady = 0;

    // Use this for initialization
    void Start () {
        MapMakerSlave = this.GetComponent<MapGenScript>();
        CurrentlevelsReady = MapTextures.Length;
        Debug.Log(CurrentlevelsReady);
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.M))
        {
            if (Level < CurrentlevelsReady)
            {
                CommandSlave();
                Debug.Log("made map");
            }
            else
                Debug.LogError("you dont have a map to make so piss off");
          
        }
	}

    void CommandSlave()
    {

        MapMakerSlave.RecieveCommand(mapObjectAnchorss[Level], MapTextures[Level], Level);
        Level++;
    }
}
