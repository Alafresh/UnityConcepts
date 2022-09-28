using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{
    public Dictionary<string, string> dict = new Dictionary<string, string>();
    public Dictionary<string, PlayerData> playerDict = new Dictionary<string, PlayerData>();

    private void Start()
    {
        dict["avion"] = "Aeronave de ala fija";
        dict["barco"] = "Construccion que flota y navega en el agua";
        dict["mar"] = "Cuerpo de agua salada";

        dict.TryGetValue("avion", out string value);
        Debug.Log(value);

        foreach ( string def in dict.Values)
        {
            Debug.Log(def);
        }
        playerDict["JuanElPro"] = new PlayerData("Juan", 10);
        playerDict["Xmaster"] = new PlayerData("Pedro", 300);

        foreach (PlayerData player in playerDict.Values)
        {
            Debug.Log(player.name);
        }
    }
}

public class PlayerData
{
    public string name;
    public int score;

    public PlayerData(string nameP, int scoreP)
    {
        name = nameP;
        score = scoreP;
    }
}