using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;

public class FailLevel3 : MonoBehaviour {

	public float timeLeft;
	public string timerFormatted;
	public Text timerText;

	private float startTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		string minutes = ((int)timeLeft / 60).ToString ();
		string seconds = (timeLeft % 60).ToString ("f0");
		timerText.text = "Time: " + minutes + " : " + seconds;
		if(timeLeft < 0)
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	void OnTriggerEnter(Collider other) {
		Application.LoadLevel(Application.loadedLevel);
	}
}
