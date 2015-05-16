using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
	public GameObject obj;
	public GameObject cam;
	public GameObject player;
	private Vector3 temp;

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float MoveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, MoveVertical);
		rb.AddForce (movement * 25);
	}

	void start () {
	}

	void Update (){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			//Application.LoadLevel ("titleScreen");	
			obj.SetActive(true);
			print ("esc pressed");
		}

		temp = new Vector3 (player.transform.position.x, player.transform.position.y + 9, player.transform.position.z + -4);
			cam.transform.position = temp;

		if (player.transform.position.y < -20) {
			temp = new Vector3 (0.0f, 0.5f, 0.0f);
			player.transform.position = temp;
		}
	}
	public void saveQuit() {
		Application.LoadLevel ("titleScreen");
	}

	public void returnToGame () {
		obj.SetActive (false);
	}
}
