using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTxt;
    public Text PurchasedTxt;
    public Text CoinTxt;
    public GameObject ShopManager;




    // Start is called before the first frame update
    void Start()
        {

        /*
        // access the ItemID field
        int ItemId = ShopManager.GetComponent<ShopManagerScript>().ItemID;

        for (int i = 1; i < ShopManager.GetComponent<ShopManagerScript>().shopItems.GetLength(1); i++) {
                if (i == ItemID) {  // Only set PurchasedTxt for the current item
                    string key = "shopItem_" + i;
                    PurchasedTxt.text = PlayerPrefs.GetInt(key, ShopManager.GetComponent<ShopManagerScript>().shopItems[3, i]).ToString();
                }
            }

        */

        }


    // Update is called once per frame
    public void Update()
    {

        //PriceTxt.text = "Price: " + PlayerPrefs.GetInt("Item"+  GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObjectGetComponent<ButtonInfo>().ItemID.ToString());

        //PurchasedTxt.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3,ItemID].ToString();
        string Key = ShopManager.GetComponent<ShopManagerScript>().PurchasedKey;
        PurchasedTxt.text = PlayerPrefs.GetInt(Key).ToString();
        CoinTxt.text = "Coins: " + ShopManager.GetComponent<ShopManagerScript>().coins.ToString();
    }


}

