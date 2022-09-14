using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine;

public class CosultManager : MonoBehaviour
{

    public const string PATH_PRICE = "C:/Ruleta/Price.json";

    public const string PATH_USER = "C:/Ruleta/User.json";

    public List<Price> PriceRoulette = new List<Price>();

    public List<User> User = new List<User>();
    private void Awake()
    {
        if (File.Exists(PATH_PRICE))
        {
            StreamReader streamReader = new StreamReader(PATH_PRICE, Encoding.UTF8);
            string json = streamReader.ReadToEnd();
            Debug.Log(json);
            var rootObject = JsonUtility.FromJson<Root>(json);

            PriceRoulette = rootObject.Price;
            Debug.Log(PriceRoulette.Count);
        }

        if (File.Exists(PATH_USER))
        {
            StreamReader streamReader = new StreamReader(PATH_USER, Encoding.UTF8);
            string json = streamReader.ReadToEnd();
            Debug.Log(json);
            var rootObject = JsonUtility.FromJson<RootUser>(json);

            User = rootObject.User;
            Debug.Log(User.Count);
        }
    }
}

[Serializable]
public class Price
{
    public int id;
    public string price;
    public int candPrice;
}

[Serializable]
public class Root
{
    public List<Price> Price;

    Root()
    {
        Price = new List<Price>();
    }
}

[Serializable]
public class User
{
    public int id;
    public string name;
    public int candGiro;
}

[Serializable]
public class RootUser
{
    public List<User> User;
    RootUser()
    {
        User = new List<User>();
    }
}


