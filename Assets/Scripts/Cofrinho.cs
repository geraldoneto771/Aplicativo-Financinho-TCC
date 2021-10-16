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
       
        if ((double.Parse(inputMoney.GetComponent<Text>().text)) <= 0)
        {
            Debug.Log("Entre com um valor maior que zero!");
        } 
        else if ((double.Parse(inputMoney.GetComponent<Text>().text)) > 0)
        {
            valor += double.Parse(inputMoney.GetComponent<Text>().text);
            textTotalCofre.GetComponent<Text>().text = "R$" + valor.ToString();

        }
    }

    public void quebrarCofre()
    {
        
        valor = 0;
        textTotalCofre.GetComponent<Text>().text = "R$" + valor.ToString();

    }

}
