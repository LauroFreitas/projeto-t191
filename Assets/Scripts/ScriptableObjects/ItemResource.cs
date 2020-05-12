using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item Asset")]
public class ItemResource : ScriptableObject
{
	public string itemName;

	public string description;

	public int cost;
}
