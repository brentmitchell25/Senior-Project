using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseItem {

	private string itemName;
	private string itemDescription;
	private int itemID;
	private int stamina;
	private int endurance;
	private int strength;
	private int intellect;

	public enum ItemTypes {
		EQUIPMENT,
		WEAPON,
		SCROLL,
		POTION,
		CHEST
	}
	private ItemTypes itemType;

	public BaseItem(){}

	public BaseItem(Dictionary<string,string> itemsDictionary) {
		itemName = itemsDictionary["ItemName"];
		itemID = int.Parse (itemsDictionary["ItemID"]);
		itemType = (ItemTypes)System.Enum.Parse (typeof(BaseItem.ItemTypes), itemsDictionary ["ItemType"].ToString ());
	}

	public string ItemName {
		get {
			return itemName;
		}
		set {
			itemName = value;
		}
	}

	public string ItemDescription {
		get {
			return itemDescription;
		}
		set {
			itemDescription = value;
		}
	}

	public int ItemID {
		get {
			return itemID;
		}
		set {
			itemID = value;
		}
	}

	public ItemTypes ItemType {
		get {
			return itemType;
		}
		set {
			itemType = value;
		}
	}

	public int Stamina {
		get {
			return stamina;
		}
		set {
			stamina = value;
		}
	}
	
	public int Endurance {
		get {
			return endurance;
		}
		set {
			endurance = value;
		}
	}
	
	public int Strength {
		get {
			return strength;
		}
		set {
			strength = value;
		}
	}
	
	public int Intellect {
		get {
			return intellect;
		}
		set {
			intellect = value;
		}
	}

}
