using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	public void StartGame() {
		Application.LoadLevel("levelSelect");
	}

	public void EndGame() {
		Application.Quit ();
	}

	public void Credits () {
		Application.LoadLevel ("credits");
	}
}
