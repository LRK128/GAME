using UnityEngine;
using System.Collections;

public class keyCheck : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			//Application.LoadLevel ("titleScreen");	
			Application.LoadLevel ("titleScreen");
		}
	}
}
