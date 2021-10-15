using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cofrinho : MonoBehaviour
{

    public InputField inputMoney;
    private int totalMoney = 0;
    public Text textTotalCofre;
    private int money;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        textTotalCofre.text = "R$" + totalMoney.ToString();

    }

    public void addMoney()
    {

        money = int.Parse(inputMoney.text);
        totalMoney += money;
        
    }

    public void quebrarCofre()
    {
        totalMoney = 0;
        
    }
}
