using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UIStatus : BaseUI
{
    [SerializeField] private Button returnButton;
    [SerializeField] private TextMeshProUGUI AtkValue;
    [SerializeField] private TextMeshProUGUI DefValue;
    [SerializeField] private TextMeshProUGUI HpValue;
    [SerializeField] private TextMeshProUGUI CritValue;

    private void Start()
    {
        returnButton.onClick.AddListener(OpenMainMenu);
    }

    private void OpenMainMenu()
    {
        UIManager.Instance.OpenUI(UIManager.Instance.MainMenu);
    }

    public void SetCharacterInfo(Character character)
    {
        AtkValue.text = character.Atk.ToString();
        DefValue.text = character.Def.ToString();
        HpValue.text = character.Hp.ToString();
        CritValue.text = character.Crit.ToString();
    }
}
