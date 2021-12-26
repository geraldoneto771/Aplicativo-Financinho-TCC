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
    public RectTransform bttNext, bttRota02, bttRota03, bttRota4, bttRota05, bttRota06, bttRota07, bttRota08, bttRota9, bttRota10, bttRota11, bttRota12, bttNext13, bttRota14, bttRota15, bttRota16, bttRota17, bttRota18, bttRota19, bttRota20, bttRota21, bttRota22, bttRota23, bttRota24, bttRota25, bttRota26;

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
        if (index == 54)
        {
            bttNext.DOAnchorPos(new Vector2(1204, -912), 0.25f);
            bttRota03.DOAnchorPos(new Vector2(597, -339), 0.25f);
            bttRota11.DOAnchorPos(new Vector2(-523, -331), 0.25f);

        }
        if (index == 59)
        {
            bttNext.DOAnchorPos(new Vector2(1204, -912), 0.25f);
            bttRota10.DOAnchorPos(new Vector2(-661, -411), 0.25f);
            bttRota15.DOAnchorPos(new Vector2(-87, -411), 0.25f);
            bttRota18.DOAnchorPos(new Vector2(586, -411), 0.25f);

        }

        switch (rotas)
        {
            case 1:
                    InicioGame();
                    break;
            case 2:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 3:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 4:
                index = 8;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota4.DOAnchorPos(new Vector2(-703, 2601), 0.25f);
                bttRota9.DOAnchorPos(new Vector2(-103, 2595), 0.25f);
                bttRota12.DOAnchorPos(new Vector2(530, 2624), 0.25f);
                rotas = 0;
                break;
            case 5:
                index = 55;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota05.DOAnchorPos(new Vector2(2656, 2632), 0.25f);
                bttRota14.DOAnchorPos(new Vector2(3458, 2632), 0.25f);
                rotas = 0;
                break;
            case 6:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 7:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 8:
                index = 46;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota08.DOAnchorPos(new Vector2(1190, 2632), 0.25f);
                bttRota17.DOAnchorPos(new Vector2(1960, 2632), 0.25f);
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
            case 10:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 11:
                index = 36;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota08.DOAnchorPos(new Vector2(1190, 2632), 0.25f);
                bttRota11.DOAnchorPos(new Vector2(-1538, 2632), 0.25f);
                bttRota03.DOAnchorPos(new Vector2(-1366, 2632), 0.25f);
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
            case 13:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 14:
                index = 40;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota05.DOAnchorPos(new Vector2(2656, 2632), 0.25f);
                bttRota14.DOAnchorPos(new Vector2(3458, 2632), 0.25f);
                rotas = 0;
                break;
            case 15:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 16:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 17:
                index = 32;
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                bttRota08.DOAnchorPos(new Vector2(1190, 2632), 0.25f);
                bttRota17.DOAnchorPos(new Vector2(1960, 2632), 0.25f);
                rotas = 0;
                break;
            case 18:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 19:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 20:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 21:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 22:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 23:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 24:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 25:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
                rotas = 0;
                break;
            case 26:
                bttNext.DOAnchorPos(new Vector2(814, -469), 0.25f);
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
        rotas = 2;
        NextChangeImage();
    }
    public void RotaTres()
    {
        rotas = 3;
        NextChangeImage();
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
        rotas = 6;
        NextChangeImage();
    }
    public void RotaSete()
    {
        rotas = 7;
        NextChangeImage();
    }
    public void RotaOito()
    {
        rotas = 8;
        NextChangeImage();
    }
    public void RotaNove()
    {
        rotas = 9;
        NextChangeImage();
    }
    public void RotaDez()
    {
        rotas = 10;
        NextChangeImage();
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
        rotas = 13;
        NextChangeImage();
    }
    public void RotaQuatorze()
    {
        rotas = 14;
        NextChangeImage();
    }
    public void RotaQuinze()
    {
        rotas = 15;
        NextChangeImage();
    }
    public void RotaDezesseis()
    {
        rotas = 16;
        NextChangeImage();
    }
    public void RotaDezessete()
    {
        rotas = 17;
        NextChangeImage();
    }
    public void RotaDezoito()
    {
        rotas = 18;
        NextChangeImage();
    }
    public void RotaDezonove()
    {
        rotas = 19;
        NextChangeImage();
    }
    public void RotaVinte()
    {
        rotas = 20;
        NextChangeImage();
    }
    public void RotaVinteUm()
    {
        rotas = 21;
        NextChangeImage();
    }
    public void RotaVinteDois()
    {
        rotas = 22;
        NextChangeImage();
    }
    public void RotaVinteTres()
    {
        rotas = 23;
        NextChangeImage();
    }
    public void RotaVinteQuatro()
    {
        rotas = 24;
        NextChangeImage();
    }
    public void RotaVinteCinco()
    {
        rotas = 25;
        NextChangeImage();
    }
    public void RotaVinteSeis()
    {
        rotas = 26;
        NextChangeImage();
    }

}
