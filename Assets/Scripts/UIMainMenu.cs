using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UIMainMenu : BaseUI
{
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private TextMeshProUGUI playerLevel;
    [SerializeField] private TextMeshProUGUI playerGold;

    public void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
    }

    private void OpenStatus()
    {
        UIManager.Instance.OpenUI(UIManager.Instance.Status);
    }

    private void OpenInventory()
    {
        UIManager.Instance.OpenUI(UIManager.Instance.Inventory);
    }

    public void SetCharacterInfo(Character character)
    {
        playerName.text = character.Name;
        playerLevel.text = character.Level.ToString();
        playerGold.text = character.Gold.ToString();
    }
}
