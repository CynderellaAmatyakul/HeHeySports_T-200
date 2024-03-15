using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] Keys;

    private void Start()
    {
        Keys[0].SetActive(false);
        Keys[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameDataBase.puzzle1Won)
        {
            Keys[0].SetActive(true);
        }

        if (GameDataBase.puzzle2Won)
        {
            Keys[1].SetActive(true);
        }
    }
}
