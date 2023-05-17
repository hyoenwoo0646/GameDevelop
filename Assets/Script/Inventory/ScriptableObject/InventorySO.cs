using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "Inventory/Inventory")]
public class InventorySO : ScriptableObject
{
    [Tooltip("보유 아이템 목록 및 수량")]
    [SerializeField] private List<Item> items = new List<Item>();
    public List<Item> Items { get => items; }

	public void Init()
	{
		if (items == null)
			items = new List<Item>();

		items.Clear();
	}

	public void Add(ItemSO itemData, int count = 1)
	{
		if (count <= 0)
			return;

		for (int i = 0; i < items.Count; i++)
		{
			Item currentItem = items[i];

			if (itemData == currentItem.ItemData)
			{
				currentItem.amount += count;

				return;
			}
		}

		items.Add(new Item(itemData, count));
	}

	public void Remove(ItemSO item, int count = 1)
	{
		if (count <= 0)
			return;

		for (int i = 0; i < items.Count; i++)
		{
			Item currentItem = items[i];

			if (currentItem.ItemData == item)
			{
				currentItem.amount -= count;

				if (currentItem.Amount <= 0)
					items.Remove(currentItem);

				return;
			}
		}
	}

	public bool Contains(ItemSO item)
	{
		for (int i = 0; i < items.Count; i++)
		{
			if (item == items[i].ItemData)
			{
				return true;
			}
		}

		return false;
	}

	public int GetAmount(ItemSO item)
	{
		for (int i = 0; i < items.Count; i++)
		{
			Item currentItem = items[i];
			if (item == currentItem.ItemData)
			{
				return currentItem.Amount;
			}
		}

		return 0;
	}

}
