using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    [SerializeField] private Transform[] picture;
    [SerializeField] private GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        GameDataBase.tutorial = false;
        if (GameDataBase.tutorialWon)
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
            picture[2].rotation.z == 0 )
        {
            GameDataBase.tutorial = true;
            GameDataBase.tutorialWon = true;
            winText.SetActive(true);
        }
    }
}
