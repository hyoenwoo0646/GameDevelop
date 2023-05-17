using UnityEngine;

[System.Serializable]
public class Item
{
    [SerializeField] private ItemSO itemData = default;
    public ItemSO ItemData { get => itemData; }

    [SerializeField] public int amount = default;
    public int Amount { get => amount; }

    public Item()
    {
        itemData = null;
        amount = 0;
    }

    public Item(ItemSO itemData, int amount)
    {
        this.itemData = itemData;
        this.amount = amount;
    }
}
