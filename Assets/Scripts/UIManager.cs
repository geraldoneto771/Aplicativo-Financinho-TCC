using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform mainMenu, carShopMenu;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }

    // Update is called once per frame
    public void CarShopButton()
    {
        mainMenu.DOAnchorPos(new Vector2(-1884, 0), 0.25f);
        carShopMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void CloseCarShopButton()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
        carShopMenu.DOAnchorPos(new Vector2(1884, 0), 0.25f);
    }

}