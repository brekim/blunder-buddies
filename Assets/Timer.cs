using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float totalTime = 181;

    private bool victoryCondition = false;
    private bool loseCondition = false;

    void Update()
    {
        if (victoryCondition == false && loseCondition == false)
        {
            if (totalTime > 0)
            {
                totalTime -= Time.deltaTime;

                int minutes = Mathf.FloorToInt(totalTime / 60);
                int seconds = Mathf.FloorToInt(totalTime % 60);
                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            else
            {
                loseCondition = true;
            }
        }

        if (loseCondition == true)
        {
            totalTime = 0;
            timerText.text = "You Lose";
        }

        if (victoryCondition == true)
        {
            timerText.text = "You Win!";
        }

    }

    public void onVictory()
    {
        victoryCondition = true;
    }
}
