using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int coins;
    public PlayerData(LogicScript logic)
    {
        coins = logic.coins;
    }
}
