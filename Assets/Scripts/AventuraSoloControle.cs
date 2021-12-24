using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class AventuraSoloControle : MonoBehaviour
{

    public Sprite[] sprites;
    SpriteRenderer spriteRender;
    int rotas;

    int index;
    public RectTransform bttRota4, bttRota9, bttRota12, bttNext;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        rotas = 0;
        bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
        spriteRender = GetComponent<SpriteRenderer>();
        spriteRender.sprite = sprites[0];
    }

    public void NextChangeImage()
    {
        index++;

        spriteRender.sprite = sprites[index];

        if (index == 7)
        {
            rotas = 1;
        }

        switch (rotas)
        {
            case 1:
                    InicioGame();
                    break;
                
        }
    }

   /* public void LoadScene(string name)
    {
        if (index >= 7)
        {
            //Carregar cena de acordo com seu nome
            SceneManager.LoadScene(name);
        }


    }*/

    public void InicioGame()
    {
        
        bttRota4.DOAnchorPos(new Vector2(-703, 309), 0.25f);
        bttRota9.DOAnchorPos(new Vector2(624, 387), 0.25f);
        bttRota12.DOAnchorPos(new Vector2(373, -140), 0.25f);
        bttNext.DOAnchorPos(new Vector2(1204, -912), 0.25f);
    }

    public void RotaDois()
    {

    }
    public void RotaTres()
    {

    }
    public void RotaQuarto()
    {

    }
    public void RotaQuinta()
    {

    }
    public void RotaSexta()
    {

    }
    public void RotaSete()
    {

    }
    public void RotaOito()
    {

    }
    public void RotaNove()
    {

    }
    public void RotaDez()
    {

    }
    public void RotaOnze()
    {

    }
    public void RotaDoze()
    {

    }
    public void RotaTreze()
    {

    }
    public void RotaQuatorze()
    {

    }
    public void RotaQuinze()
    {

    }
    public void RotaDezesseis()
    {

    }
    public void RotaDezessete()
    {

    }
    public void RotaDezoito()
    {

    }
    public void RotaDezonove()
    {

    }
    public void RotaVinte()
    {

    }
    public void RotaVinteUm()
    {

    }
    public void RotaVinteDois()
    {

    }
    public void RotaVinteTres()
    {

    }
    public void RotaVinteQuatro()
    {

    }
    public void RotaVinteCinco()
    {

    }
    public void RotaVinteSeis()
    {

    }

}
