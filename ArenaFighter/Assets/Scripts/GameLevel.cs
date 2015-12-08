using UnityEngine;
using System.Collections;

public class GameLevel : MonoBehaviour {
	
		public static void loadMainMenu() {
			Application.LoadLevel ("MainMenu");
		}

		public static void loadMultiplayerMenu() {
			Application.LoadLevel ("MultiplayerMenu");
		}
	public static void loadDemoLevel() {
		Application.LoadLevel ("Demogame");
	}

}
