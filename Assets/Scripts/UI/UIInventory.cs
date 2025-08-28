using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

[Serializable]
public class UIInventory : BaseUI
{
    [SerializeField] private Button returnButton;
    [SerializeField] private GameObject slotPrefab;

    public Transform slotParent;
    public List<UISlot> slots = new();
    private Character character;

    private void Start()
    {
        returnButton.onClick.AddListener(OpenMainMenu);
    }

    private void OpenMainMenu()
    {
        UIManager.Instance.OpenUI(UIManager.Instance.MainMenu);
    }

    public void InitInventoryUI(Character player)
    {
        character = player;

        for (int i = 0; i < player.Inventory.Count; i++) {
            GameObject ob = Instantiate(slotPrefab, slotParent, true);
            if(ob.TryGetComponent<UISlot>(out UISlot newSlot))
            {
                slots.Add(newSlot);
                newSlot.SetItem(player.Inventory[i]);
                newSlot.OnClicked += OnSlotClick;
                Debug.Log("아이템 생성");
            }
            else
            {
                Debug.Log("아이템이 없는뎁쇼");
            }
        }
    }

    public void OnSlotClick(UISlot clickedSlot)
    {
        clickedSlot.isEquip = clickedSlot.isEquip ? false : true;
        clickedSlot.RefreshUI();

        if (clickedSlot.isEquip) {
            character.Equip(clickedSlot.currentItem);
        }
        else
        {
            character.UnEquip(clickedSlot.currentItem);
        }
    }
}
