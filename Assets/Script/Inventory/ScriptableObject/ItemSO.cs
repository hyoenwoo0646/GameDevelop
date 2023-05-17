using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class ItemSO : ScriptableObject
{
    [Tooltip("������ �̸� ����")]
    [SerializeField] private string name = default;
    public string Name { get => name; }

    [Tooltip("������ �̹��� ����")]
    [SerializeField] private Sprite icon = default;
    public Sprite Icon { get => icon; }

    [Tooltip("������ ���� ����")]
    [SerializeField] private string description = default;
    public string Description { get => description; }

    [Tooltip("������ Ÿ�� ����")]
    [SerializeField] private ItemTypeSO itemTypes = default;
}
