using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeactivateBombLvl2: MonoBehaviour {

	public Text myMessage;

	public SuccessLevel2 suc2;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider other)
	{
		myMessage.text = "Deactivate Bomb (press f or X)";
		if (other.tag == "Player" && Input.GetButton("Fire1")) {
			myMessage.text = "";
			gameObject.SetActive (false);
			suc2.BombDeactivate ();
		}
	}

	void OnTriggerExit(Collider other)
	{
		myMessage.text = "";
	}

}