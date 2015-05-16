using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

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
