using UnityEngine;
using System.Collections;

public class FailLevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider other) {
		if (other.name == "Player") {
			Debug.Log ("Fail");
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
