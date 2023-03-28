using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTxt;
    public Text PurchasedTxt;
    public GameObject ShopManager;
    public CharacterCustomization CustomizeSprite;



    // Start is called before the first frame update
    void Start()
        {
            CustomizeSprite = Object.FindObjectOfType<CharacterCustomization>();
        }


    // Update is called once per frame
    public void Update()
    {
        PriceTxt.text = "Price: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[2,ItemID].ToString();
        PurchasedTxt.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3,ItemID].ToString();
        CustomizeSprite.Update();
    }


}
