using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class ItemSO : ScriptableObject
{
    [Tooltip("아이템 이름 지정")]
    [SerializeField] private string name = default;
    public string Name { get => name; }

    [Tooltip("아이템 이미지 지정")]
    [SerializeField] private Sprite icon = default;
    public Sprite Icon { get => icon; }

    [Tooltip("아이템 설명 지정")]
    [SerializeField] private string description = default;
    public string Description { get => description; }

    [Tooltip("아이템 타입 지정")]
    [SerializeField] private ItemTypeSO itemTypes = default;
}
