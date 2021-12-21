using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AventuraSoloControle : MonoBehaviour
{

    public Sprite[] sprites;
    SpriteRenderer spriteRender;

    int index;
    

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        spriteRender = GetComponent<SpriteRenderer>();
        spriteRender.sprite = sprites[0];
    }

    public void NextChangeImage()
    {
        index++;

        spriteRender.sprite = sprites[index];

    }

    public void LoadScene(string name)
    {
        if (index >= 7)
        {
            //Carregar cena de acordo com seu nome
            SceneManager.LoadScene(name);
        }


    }

}
