using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Controller : MonoBehaviour
{
    [SerializeField] private Transform[] picture;
    [SerializeField] private GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        GameDataBase.puzzle1 = false;
        if (GameDataBase.puzzle1Won)
        {
            winText.SetActive(true);
        }
        else
        {
            winText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (picture[0].rotation.z == 0 &&
            picture[1].rotation.z == 0 &&
            picture[2].rotation.z == 0 &&
            picture[3].rotation.z == 0 &&
            picture[4].rotation.z == 0 &&
            picture[5].rotation.z == 0)
        {
            GameDataBase.puzzle1 = true;
            GameDataBase.puzzle1Won = true;
            winText.SetActive(true);
        }
    }
}
