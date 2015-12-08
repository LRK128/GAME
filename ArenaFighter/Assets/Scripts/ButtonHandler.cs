using UnityEngine;
using System.Collections;

public class ButtonHandler : MonoBehaviour {
	
	    public void multiplayerButton() {
		GameLevel.loadMultiplayerMenu();
		}
	
		public void exitButton() {
		GameLevel.loadMainMenu();
		}

	public void demoButton(){
		GameLevel.loadDemoLevel ();
	}

}
