using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;

public class SuccessLevel3 : MonoBehaviour {

	public Text bombsText;
	public int bombsRemaining;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bombsText.text = "Bombs Remaining: " + bombsRemaining;
	}

	public void BombDeactivate(){
		bombsRemaining--;
		if(bombsRemaining == 0){
            Application.Quit();
        }
	}
}