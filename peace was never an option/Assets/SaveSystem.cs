using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem
{
    public static void saveCoins(LogicScript logic)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data.ds";
        FileStream stream = new FileStream(path, FileMode.Create);
    }
}
