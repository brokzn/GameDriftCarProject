using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public Text playerMoney;

    public static int moneyAmount = 0; // ���������� ��� �������� ����� ������

    void Start()
    {
        // ��� �������� ���� �������� ��������� ���������� ����� �� ����������
        if (PlayerPrefs.HasKey("MoneyAmount"))
        {
            moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        }
        DontDestroyOnLoad(this.gameObject); // �� ���������� ������ ��� �������� ����� �����
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
        // ��������� ���������� ����� � PlayerPrefs
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        PlayerPrefs.Save(); // ��������� ���������
    }
    void Update()
    {
        playerMoney.text = moneyAmount.ToString();
    }
}
