using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeSummary : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI summaryText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
