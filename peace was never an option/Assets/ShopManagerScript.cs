using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{
    
    public int[,] shopItems = new int[5,5];
    
    public Text CoinsTXT;
    public int coins;
    public LogicScript logic;
    //public int spriteNum;
    //public ButtonInfo UpdateSprite;


    void Start()
    {

        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
        coins = logic.coins;

        //IDs
        shopItems [1,1] =1;
        shopItems [1,2] =2;
        shopItems [1,3] =3;
        shopItems [1,4] =4;

        //Price
        shopItems [2,1] =5;
        shopItems [2,2] =5;
        shopItems [2,3] =5;
        shopItems [2,4] =5;


        //Purchased
        shopItems [3,1] =0;
        shopItems [3,2] =0;
        shopItems [3,3] =0;
        shopItems [3,4] =0;

        //Sprites
        /*
        shopItems[4,1] = 0;
        shopItems[4,2] = 1;
        shopItems[4,3] = 2;
        shopItems[4,4] = 3;
        */

        //UpdateSprite = Object.FindObjectOfType<ButtonInfo>();
    }

    
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins>= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID] && coins>0 ){
            if (shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID] == 0){
                coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
                shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
                CoinsTXT.text = "Coins: " + coins.ToString();
                ButtonRef.GetComponent<ButtonInfo>().PurchasedTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
                //spriteNum = shopItems[4, ButtonRef.GetComponent<ButtonInfo>().ItemID];
                //UpdateSprite.Update();
            }
            
        }

    }

   //public int getSpriteNum(){
   // return spriteNum;
//}

}
