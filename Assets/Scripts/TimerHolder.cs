using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerHolder : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        GameDataBase.remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(GameDataBase.remainingTime / 60);
        int seconds = Mathf.FloorToInt(GameDataBase.remainingTime % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (GameDataBase.remainingTime <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
