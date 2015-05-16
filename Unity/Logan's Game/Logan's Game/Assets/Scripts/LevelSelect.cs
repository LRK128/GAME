using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	public void debugLoad () {
		Application.LoadLevel ("test");
	}
	public void mainMenu () {
		Application.LoadLevel ("titleScreen");
	}
}
