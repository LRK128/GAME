using UnityEngine;
using System.Collections;

public class Store : MonoBehaviour {

	public GUIText money;
	public GUIText itemName;
	public GUIText itemPrice;
	public ArrayList sitems = new ArrayList();
	public GameObject current;
	public StoreItem currentitem;
	public int currentint = 0;
	public int itemslegnth;
	// Use this for initialization
	void Start () {

		StoreItem[] sitems = FindObjectsOfType(typeof(StoreItem)) as StoreItem[];
		Debug.Log ("Found " + sitems.Length.ToString() + " Items");
		for (int i = 0; i < sitems.Length; i++) {
			current = sitems[i].gameObject;
			currentitem = current.GetComponent<StoreItem>();
			int price = currentitem.price;
			string itemname = currentitem.itemName;
			Debug.Log ("Price: " + price.ToString());
			Debug.Log ("Item Name" + itemname);
		}
		itemslegnth = sitems.Length;
	
	}
	
	public void updateDisplay(){
		sitems [currentint] = (GameObject)current;
		Vector3 center = new Vector3(-65, 58, -419);
		current.transform.position = center ;

	}

	public void nextItem(){
		currentint = currentint + 1;
		if (currentint > itemslegnth) {
			currentint = 0;
		}
		updateDisplay ();

	}

	public void backItem(){
		currentint = currentint - 1;
		if (currentint < 0) {
			currentint = itemslegnth;
		}
		updateDisplay ();
	}
}
