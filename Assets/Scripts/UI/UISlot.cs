using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private GameObject equip;
    [SerializeField] private Button slotButton;

    public event Action<UISlot> OnClicked;

    public Item currentItem;
    public bool isEquip = false;

    private void Start()
    {
        slotButton.onClick.AddListener(()=> {
            OnClicked?.Invoke(this);
            }
        );
    }

    public void SetItem(Item item)
    {
        Debug.Log("아이템 설정");
        currentItem = item;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (currentItem != null) {
            icon.enabled = true;
            icon.sprite = currentItem.ItemIcon;

            if (isEquip) {
                equip.SetActive(true);
            }
            else
            {
                equip.SetActive(false);
            }
        }
        else
        {
            icon.enabled = false;
        }
    }
}
