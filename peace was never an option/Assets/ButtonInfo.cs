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


    // Update is called once per frame
    public void Update()
    {
        string Key = "shopItem_" + ItemID;
        PurchasedTxt.text = PlayerPrefs.GetInt(Key).ToString();
        CoinTxt.text = "Coins: " + ShopManager.GetComponent<ShopManagerScript>().coins.ToString();
    }
}
