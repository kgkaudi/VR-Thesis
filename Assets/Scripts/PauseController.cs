using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseController : MonoBehaviour {

	private bool paused;
	public Text pausedMessage;

	// Use this for initialization
	void Start () {
        pausedMessage.text = "";
		paused = false;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButtonUp("Cancel"))
		{
			Pause();
		}
	}

	public void Pause()
	{
		if (paused == false)
		{
			pausedMessage.text = "PAUSED";
			paused = true;
			Time.timeScale = 0;
		}
		else
		{
			pausedMessage.text = "";
			paused = false;
			Time.timeScale = 1;
		}
	}

    public void Resume()
    {
        pausedMessage.text = "";
        paused = false;
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.LoadLevel("Opening Menu");
    }
}
