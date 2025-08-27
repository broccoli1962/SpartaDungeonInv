using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [field:SerializeField] public UIMainMenu MainMenu { get; set; }
    [field:SerializeField] public UIStatus Status { get; set; }
    [field:SerializeField] public UIInventory Inventory { get; set; }

    private BaseUI currentUI;

    private void Start()
    {
        MainMenu.gameObject.SetActive(false);
        Status.gameObject.SetActive(false);
        Inventory.gameObject.SetActive(false);
    
        OpenUI(MainMenu);
    }

    public void OpenUI<T>(T ui) where T : BaseUI
    {
        if (currentUI != null)
        {
            currentUI.gameObject.SetActive(false);
        }

        currentUI = ui;
        currentUI.gameObject.SetActive(true);

        Debug.Log($"{ui.name} is Open");
    }
}
