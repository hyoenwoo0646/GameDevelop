using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EItemType
{ 
	WEAPON,
	FOOD,
	QUEST,
}

public enum EItemActionType
{
	NONE,
	USE,
	EQUIP,
}

[System.Serializable]
public class ItemTypeSO : ScriptableObject
{
	[SerializeField] private EItemType itemType = default;
    public EItemType ItemType { get => itemType; }

    [SerializeField] private EItemActionType itemActionType = default;
	public EItemActionType ItemActionType { get => itemActionType; }
}
