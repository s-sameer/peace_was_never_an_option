using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
    //public SpriteRenderer spriteRenderer;
    //public Sprite newSprite;
    // Start is called before the first frame update


    public ShopManagerScript NumSprite;
    public int spriteNum;

    public Sprite[] spriteList = new Sprite[4];
    public Sprite Goose;
    public Sprite KnifeGoose;
    public Sprite LumberjackGoose;
    public Sprite ShooterGoose;

    void Start()
    {
        //Sprites
        spriteList[0] = Goose;
        spriteList[1] = KnifeGoose;      
        spriteList[2] = LumberjackGoose;
        spriteList[3] = ShooterGoose;

        NumSprite = NumSprite.GetComponent<ShopManagerScript>();
        spriteNum = NumSprite.getSpriteNum();

    }

    // Update is called once per frame
    public void Update()
    {

        this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteList[spriteNum];
       
    }


   



}
