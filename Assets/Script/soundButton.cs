using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundButton : MonoBehaviour{
	public AudioSource PlaySound;

	public void PlaySoundInfo(){
		PlaySound.Play();
	}
}