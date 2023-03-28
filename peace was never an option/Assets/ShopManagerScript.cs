using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManagerScript : MonoBehaviour
{
    
    public int[,] shopItems = new int[5,5];
    
    public Text CoinsTXT;
    public int coins;
    //public int chosenItemID;
    public string PurchasedKey;
    //public int spriteNum;
    //public ButtonInfo UpdateSprite;


    void Start()
    {
        coins = PlayerPrefs.GetInt("coins");
        //chosenItemID = 0;

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


        for (int i = 1; i < shopItems.GetLength(1); i++) {
           string key = "shopItem_" + i;
           PlayerPrefs.SetInt(key, shopItems[3, i]);
        }


        //Sprites
        /*
        shopItems[4,1] = 0;
        shopItems[4,2] = 1;
        shopItems[4,3] = 2;
        shopItems[4,4] = 3;
        */


    }


    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        PurchasedKey = "shopItem_" + ButtonRef.GetComponent<ButtonInfo>().ItemID;

        if (coins>= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID] && coins>0 ){
            if (PlayerPrefs.GetInt(PurchasedKey) == 0)
            //shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID] == 0)
            {
                coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
                shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
                CoinsTXT.text = "Coins: " + coins.ToString();
                //chosenItemID = ButtonRef.GetComponent<ButtonInfo>().ItemID;


                PlayerPrefs.SetInt(PurchasedKey, shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]);

                //ButtonRef.GetComponent<ButtonInfo>().PurchasedTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
                //PurchasedTxt.text = PlayerPrefs.GetInt(PurchasedKey);
                PlayerPrefs.SetInt("coins",coins);
            }

        }

    }

    //to move back to main screen
    public void Back()
    {
        Debug.Log("checking");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

}

