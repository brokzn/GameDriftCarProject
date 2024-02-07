using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RaceManager : MonoBehaviour
{
    public Transform startLine;
    public Transform finishLine;
    public Text raceStartText;
    public Text timerText;
    public GameObject carStop;


    public Canvas EndRaceCanvas;




    public Text endracetimerText;



    private bool raceStarted = false;
    private float raceTime = 0f;



    int currentMoney = PlayerMoney.moneyAmount;
    public Text totalmoneyEarn;

    public Text PlayerAllMoney;

    void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        EndRaceCanvas.enabled = false;
        raceStartText.text = "Заедз начнется через:  5";
        yield return new WaitForSeconds(1f);
        raceStartText.text = "Заедз начнется через:  4";
        yield return new WaitForSeconds(1f);
        raceStartText.text = "Заедз начнется через:  3";
        yield return new WaitForSeconds(1f);
        raceStartText.text = "Заедз начнется через:  2";
        yield return new WaitForSeconds(1f);
        raceStartText.text = "Заедз начнется через:  1";
        yield return new WaitForSeconds(1f);
        raceStartText.text = "Поехали!";
        yield return new WaitForSeconds(1f);
        raceStartText.text = "";
        carStop.SetActive(false);
        StartRace();
    }


    string FormatRaceTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);
        int milliseconds = Mathf.FloorToInt((timeInSeconds * 1000) % 1000);

        return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }



    void Update()
    {
        
        if (raceStarted)
        {
            raceTime += Time.deltaTime;
            timerText.text = "Время заезда: " + FormatRaceTime(raceTime);

        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == finishLine)
        {
            FinishRace();
        }
    }

    void StartRace()
    {
        raceStarted = true;
    }

    void FinishRace()
    {
        raceStarted = false;
        PlayerMoney.AddMoney(100);
        totalmoneyEarn.text = "Денег заработано: 100";
        PlayerAllMoney.text = "Всего денег: " + PlayerMoney.moneyAmount.ToString();
        timerText.text = " ";
        EndRaceCanvas.enabled = true;
        endracetimerText.text = "Время заезда - " + FormatRaceTime(raceTime);
        Time.timeScale = 0;
    }
}
