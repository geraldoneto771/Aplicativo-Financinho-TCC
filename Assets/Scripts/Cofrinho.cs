using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Cofrinho : MonoBehaviour
{
    private double valor;
    public GameObject inputMoney;
    public GameObject textTotalCofre;
    public GameObject PanelTemCerteza;
    public GameObject PanelTemCertezaCofre;


    public void OpenPanelTemCerteza()
    {
        bool isActive = PanelTemCerteza.activeSelf;
        if (PanelTemCerteza != null)
        {
            PanelTemCerteza.SetActive(!isActive);

        }
        else
        {
            PanelTemCerteza.SetActive(isActive);

        }


    }

    public void OpenPanelTemCertezaCofre()
    {
        bool isActive = PanelTemCertezaCofre.activeSelf;
        if (PanelTemCertezaCofre != null)
        {
            PanelTemCertezaCofre.SetActive(!isActive);

        }
        else
        {
            PanelTemCertezaCofre.SetActive(isActive);

        }


    }

    public void addMoney()
    {
        bool isActive = PanelTemCerteza.activeSelf;

        try
        {
            if ((double.Parse(inputMoney.GetComponent<Text>().text)) <= 0)
            {
                Debug.Log("Entre com um valor maior que zero!");
            }
            else if ((double.Parse(inputMoney.GetComponent<Text>().text)) > 0)
            {
                valor += double.Parse(inputMoney.GetComponent<Text>().text);
                textTotalCofre.GetComponent<Text>().text = "R$" + valor.ToString();

                if (PanelTemCerteza != null)
                {
                    PanelTemCerteza.SetActive(!isActive);

                }
                else
                {
                    PanelTemCerteza.SetActive(isActive);

                }


            }
        }
        catch (Exception e)
        {
            Debug.Log("Entre com um valor!");
        }
    }

    public void quebrarCofre()
    {
        bool isActive = PanelTemCertezaCofre.activeSelf;
        valor = 0;
        textTotalCofre.GetComponent<Text>().text = "R$" + valor.ToString();
        if (PanelTemCertezaCofre != null)
        {
            PanelTemCertezaCofre.SetActive(!isActive);

        }
        else
        {
            PanelTemCertezaCofre.SetActive(isActive);

        }

    }

}
