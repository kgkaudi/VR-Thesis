using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Level1()
    {
        Application.LoadLevel("Level 1");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
