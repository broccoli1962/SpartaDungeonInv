using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private List<ItemData> dataList = new();

    private void Start()
    {
        SetData();
    }

    private void SetData()
    {
        Character character = new Character("AAAAA", 1, 100.0f, 35, 20, 100, 25);
        
        for (int i = 0; i < dataList.Count; i++) {
            Item testItem = new Item(dataList[i]);
            character.AddItem(testItem);
        }

        UIManager.Instance.Inventory.InitInventoryUI(character);
        UIManager.Instance.MainMenu.SetCharacterInfo(character);
        UIManager.Instance.Status.SetCharacterInfo(character);
        Debug.Log("데이터 설정 완료");
    }
}
