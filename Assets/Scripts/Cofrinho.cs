using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cofrinho : MonoBehaviour
{
    private double valor;
    public GameObject inputMoney;
    public GameObject textTotalCofre;

    public void addMoney()
    {
        valor += double.Parse(inputMoney.GetComponent<Text>().text);
        textTotalCofre.GetComponent<Text>().text = "R$" + valor.ToString();

    }

    public void quebrarCofre()
    {
        // totalMoney = 0;
        valor = 0;
        textTotalCofre.GetComponent<Text>().text = "R$" + valor.ToString();

    }

}
