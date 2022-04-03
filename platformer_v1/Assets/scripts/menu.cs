using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour{
	public AudioClip din;
	AudioSource audio;
	void Start()
    {
		audio = GetComponent<AudioSource>();
	}
	public void PlayPressed()
	{
		audio.PlayOneShot(din);
		for(int i = 0; i < 50000000; i++)
		{ }
		SceneManager.LoadScene("MainScene");
	}
	public void ExitPressed()
	{
		audio.PlayOneShot(din);
		for (int i = 0; i < 50000000; i++)
		{ }
		Debug.Log("Exit pressed!");
		Application.Quit();
	}   
}
