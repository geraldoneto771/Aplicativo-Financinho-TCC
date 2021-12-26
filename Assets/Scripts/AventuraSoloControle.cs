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
    public RectTransform bttRota4, bttRota9, bttRota12, bttNext, bttRota08, bttRota17, bttRota11, bttRota05, bttRota14;

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
   

        

        if (index == 7)
        {
            rotas = 1;
        }

        if (index == 23)
        {
            bttNext.DOAnchorPos(new Vector2(1204, -912), 0.25f);
            bttRota08.DOAnchorPos(new Vector2(597, -339), 0.25f);
            bttRota17.DOAnchorPos(new Vector2(-523, -331), 0.25f);

        }
        if (index == 35)
        {
            bttNext.DOAnchorPos(new Vector2(1204, -912), 0.25f);
            bttRota08.DOAnchorPos(new Vector2(597, -339), 0.25f);
            bttRota11.DOAnchorPos(new Vector2(-523, -331), 0.25f);

        }
        if (index == 39)
        {
            bttNext.DOAnchorPos(new Vector2(1204, -912), 0.25f);
            bttRota05.DOAnchorPos(new Vector2(597, -339), 0.25f);
            bttRota14.DOAnchorPos(new Vector2(-523, -331), 0.25f);

        }

        switch (rotas)
        {
            case 1:
                    InicioGame();
                    break;
            case 4:
                index = 8;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota4.DOAnchorPos(new Vector2(-703, 2601), 0.25f);
                bttRota9.DOAnchorPos(new Vector2(-103, 2595), 0.25f);
                bttRota12.DOAnchorPos(new Vector2(530, 2624), 0.25f);
                rotas = 0;
                break;
            case 9:
                index = 16;
                
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota4.DOAnchorPos(new Vector2(-703, 2601), 0.25f);
                bttRota9.DOAnchorPos(new Vector2(-103, 2595), 0.25f);
                bttRota12.DOAnchorPos(new Vector2(530, 2624), 0.25f);
                rotas = 0;
                break;
            case 11:
                index = 36;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota08.DOAnchorPos(new Vector2(1190, 2632), 0.25f);
                bttRota11.DOAnchorPos(new Vector2(-1538, 2632), 0.25f);
                rotas = 0;
                break;
            case 12:
                index = 24;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota4.DOAnchorPos(new Vector2(-703, 2601), 0.25f);
                bttRota9.DOAnchorPos(new Vector2(-103, 2595), 0.25f);
                bttRota12.DOAnchorPos(new Vector2(530, 2624), 0.25f);
                rotas = 0;
                break;
            case 17:
                index = 32;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota08.DOAnchorPos(new Vector2(1190, 2632), 0.25f);
                bttRota17.DOAnchorPos(new Vector2(1960, 2632), 0.25f);
                rotas = 0;
                break;
            case 14:
                index = 40;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota05.DOAnchorPos(new Vector2(2656, 2632), 0.25f);
                bttRota14.DOAnchorPos(new Vector2(3458, 2632), 0.25f);
                rotas = 0;
                break;

        }
        spriteRender.sprite = sprites[index];
        print(index);
        
    }

    public void LoadScene(string name)
    {
        if (index == 45)
        {
            //Carregar cena de acordo com seu nome
            SceneManager.LoadScene(name);
        }


    }

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
    public void RotaQuarta()
    {
        rotas = 4;
        NextChangeImage();
        
    }
    public void RotaQuinta()
    {
        rotas = 5;
        NextChangeImage();
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
        rotas = 9;
        NextChangeImage();
    }
    public void RotaDez()
    {

    }
    public void RotaOnze()
    {
        rotas = 11;
        NextChangeImage();
    }
    public void RotaDoze()
    {
        rotas = 12;
        NextChangeImage();
    }
    public void RotaTreze()
    {

    }
    public void RotaQuatorze()
    {
        rotas = 14;
        NextChangeImage();
    }
    public void RotaQuinze()
    {

    }
    public void RotaDezesseis()
    {

    }
    public void RotaDezessete()
    {
        rotas = 17;
        NextChangeImage();
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
