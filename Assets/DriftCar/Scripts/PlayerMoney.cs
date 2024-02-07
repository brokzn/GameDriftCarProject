using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public Text playerMoney;

    public static int moneyAmount = 0; // переменная для хранения денег игрока

    void Start()
    {
        // При загрузке игры пытаемся загрузить количество денег из сохранения
        if (PlayerPrefs.HasKey("MoneyAmount"))
        {
            moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        }
        DontDestroyOnLoad(this.gameObject); // не уничтожать объект при загрузке новой сцены
    }

    public static void AddMoney(int amount)
    {
        moneyAmount += amount;
        SaveMoney();
    }

    public static void SubtractMoney(int amount)
    {
        moneyAmount -= amount;
        SaveMoney();
    }

    private static void SaveMoney()
    {
        // Сохраняем количество денег в PlayerPrefs
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        PlayerPrefs.Save(); // Сохраняем изменения
    }
    void Update()
    {
        playerMoney.text = moneyAmount.ToString();
    }
}
