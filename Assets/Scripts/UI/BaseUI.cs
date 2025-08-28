using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUI : MonoBehaviour
{
    public virtual void OpenUI()
    {
        gameObject.SetActive(true);
        OnOpen();
    }

    public virtual void CloseUI() {
        gameObject.SetActive(false);
        OnClose();
    }

    protected virtual void OnOpen(){}
    protected virtual void OnClose(){}
}
