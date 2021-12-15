using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImageScenes : MonoBehaviour
{

    public Sprite[] sprites;
    SpriteRenderer spriteRender;
   

    int index = 0;

    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        spriteRender.sprite = sprites[0];
    }

    public void NextChangeImage()
    {
        index++;
        spriteRender.sprite = sprites[index];
            
            
      
        
    }
}
