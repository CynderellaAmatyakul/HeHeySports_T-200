using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Puzzle2Controller : MonoBehaviour
{
    string code = "310032";
    string nr = null;
    int nrIndex = 0;
    public Text uiText;

    [SerializeField] private GameObject winText;

    void Start()
    {
        GameDataBase.puzzle2 = false;
        if (GameDataBase.puzzle1Won)
        {
            winText.SetActive(true);
        }
        else
        {
            winText.SetActive(false);
        }
    }

    public void CodeFunction(string numbers)
    {
        if (nrIndex < 6)
        {
            nrIndex++;
            nr = nr + numbers;
            uiText.text = nr;
        }
    }

    public void Enter()
    {
        if (nr == code)
        {
            Debug.Log("Correct");

            GameDataBase.puzzle2 = true;
            GameDataBase.puzzle2Won = true;
            winText.SetActive(true);
        }
        else
        {
            Debug.Log("Wrong");

            uiText.text = "WRONG";

            StartCoroutine(ClearCode());
        }
    }

    public void Delete()
    {
        nrIndex = 0;
        nr = null;
        uiText.text = nr;
    }

    IEnumerator ClearCode()
    {
        yield return new WaitForSeconds(1.5f);

        uiText.text = "6 digit code...";
    }
}
