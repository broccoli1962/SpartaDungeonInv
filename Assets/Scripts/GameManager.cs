using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private void Start()
    {
        SetData();
        Debug.Log("데이터 설정 완료");
    }

    private void SetData()
    {
        Character character = new Character("AAAAA", 1, 100.0f, 35, 20, 100, 25);

        UIManager.Instance.MainMenu.SetCharacterInfo(character);
        UIManager.Instance.Status.SetCharacterInfo(character);
    }
}
