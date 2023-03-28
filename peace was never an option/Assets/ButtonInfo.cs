using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTxt;
    public Text PurchasedTxt;
    public Text CoinTxt;
    public GameObject ShopManager;
   //public CharacterCustomization CustomizeSprite;



    // Start is called before the first frame update
    void Start()
        {
            //CustomizeSprite = Object.FindObjectOfType<CharacterCustomization>();
        }


    // Update is called once per frame
    public void Update()
    {
        //PlayerPrefs.SetInt("Item1", ShopManager.GetComponent<ShopManagerScript>().shopItems[3,1]);
        //PlayerPrefs.SetInt("Item2", ShopManager.GetComponent<ShopManagerScript>().shopItems[3,2]);
        //PlayerPrefs.SetInt("Item3", ShopManager.GetComponent<ShopManagerScript>().shopItems[3,3]);
        //PlayerPrefs.SetInt("Item4", ShopManager.GetComponent<ShopManagerScript>().shopItems[3,4]);


        PriceTxt.text = "Price: " + PlayerPrefs.GetInt("Item"+  GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObjectGetComponent<ButtonInfo>().ItemID.ToString());

        PurchasedTxt.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3,ItemID].ToString();
        //PurchasedTxt.text = PlayerPrefs.getInt(PurchasedKey);
        CoinTxt.text = "Coins: " + ShopManager.GetComponent<ShopManagerScript>().coins.ToString();
        //CustomizeSprite.Update();
    }


}
