using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UIInventory : BaseUI
{
    [SerializeField] private Button returnButton;

    private void Start()
    {
        returnButton.onClick.AddListener(OpenMainMenu);
    }

    private void OpenMainMenu()
    {
        UIManager.Instance.OpenUI(UIManager.Instance.MainMenu);
    }
}
