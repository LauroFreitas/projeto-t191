using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
	public GameObject containerList;
	[SerializeField]
	private GameObject[] itemContainers;

	private void Start()
	{
		itemContainers = new GameObject[containerList.transform.childCount];

		for (int i = 0; i < itemContainers.Length; i++)
		{
			itemContainers[i] = containerList.transform.GetChild(i).gameObject;

			itemContainers[i].SetActive(false);
		}
	}
}
