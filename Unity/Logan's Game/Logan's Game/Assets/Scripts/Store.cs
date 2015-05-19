using UnityEngine;
using System.Collections;

public class Store : MonoBehaviour {

	public GUIText money;
	public GUIText itemName;
	public GUIText itemPrice;
	public ArrayList sitems = new ArrayList();
	private static StoreItem currentitem;
	private int currentint = 0;
	private int itemslegnth;
	// Use this for initialization
	void Start () {

	    StoreItem[] sitems = FindObjectsOfType(typeof(StoreItem)) as StoreItem[];
		Debug.Log ("Found " + sitems.Length.ToString() + " Items");
		for (int i = 0; i < sitems.Length; i++) {
			GameObject current = sitems[i].gameObject;
			currentitem = current.GetComponent<StoreItem>();
			int price = currentitem.price;
			string itemname = currentitem.itemName;
			current.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
			Debug.Log ("Price: " + price.ToString());
			Debug.Log ("Item Name" + itemname);
		}
		itemslegnth = sitems.Length;
		Store.updateDisplay(0);
	
	}
	
	public static void updateDisplay(int itemCount){
		StoreItem[] sitems = FindObjectsOfType(typeof(StoreItem)) as StoreItem[];
		Debug.Log (itemCount);
		GameObject current = sitems[itemCount].gameObject;
		current.transform.position = new Vector3(-65.0f, 58.0f, -419.0f);
		currentitem = current.GetComponent<StoreItem>();
		int price = currentitem.price;
		string itemname = currentitem.itemName;
		Debug.Log ("Price: " + price.ToString());
		Debug.Log ("Item Name" + itemname);

	}

	public void nextItem(){
		currentint = currentint + 1;
		if (currentint > itemslegnth - 1) {
			currentint = 0;
		}
		updateDisplay (currentint);

	}

	public void backItem(){
		currentint = currentint - 1;
		if (currentint < 0) {
			currentint = itemslegnth;
		}
		updateDisplay (currentint);
	}
}
