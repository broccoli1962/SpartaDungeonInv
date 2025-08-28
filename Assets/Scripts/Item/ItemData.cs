using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(fileName = "ItemSO",menuName = "Item/ItemSO")]
public class ItemData : ScriptableObject
{
    public Sprite itemIcon;
    public float atkParam;
    public float defParam;
    public float hpParam;
    public float critParam;
}

public class Item
{
    public ItemData Data { get; private set; }
    
    public Sprite ItemIcon => Data.itemIcon;
    public float AtkParam => Data.atkParam;
    public float DefParam => Data.defParam;
    public float HpParam => Data.hpParam;
    public float CritParam => Data.critParam;
    
    public Item(ItemData data)
    {
        Data = data;
    }
}
