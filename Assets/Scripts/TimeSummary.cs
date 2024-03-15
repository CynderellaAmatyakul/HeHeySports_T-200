using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeSummary : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI summaryText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameDataBase.time -= GameDataBase.remainingTime;
        int minutes = Mathf.FloorToInt(GameDataBase.time / 60);
        int seconds = Mathf.FloorToInt(GameDataBase.time % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (GameDataBase.puzzle3Won)
        {
            summaryText.text = "You Escaped!";
        }
        else if (GameDataBase.gameOver)
        {
            summaryText.text = "You die in the dangeon";
        }
    }
}
