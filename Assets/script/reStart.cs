using UnityEngine;
using System.Collections;

public class reStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("floor").GetComponent<AudioSource> ().enabled = false;
		music.Play(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public AudioSource music;

	void OnGUI()
	{
		if (GUI.Button(new Rect(100, 10, 60, 30), "退出"))
		{
			Application.Quit();
		}
		if (GUI.Button(new Rect(200, 10, 60, 30), "重新开始"))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene("ss1");
			//Application.LoadLevel("Shot");
		}
		if(GUI.Button(new Rect(110, 50, 60, 30), "Play"))
		{
			music.Play();            
		}
		if (GUI.Button(new Rect(110, 100, 60, 30), "Pause"))
		{
			music.Pause();
		}
		if (GUI.Button(new Rect(110, 150, 60, 30), "Stop"))
		{
			music.Stop();
		}
		print("ongui");
	}
}
