using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle3Controller : MonoBehaviour
{
    [SerializeField] private Transform[] picture;

    // Start is called before the first frame update
    void Start()
    {
        GameDataBase.puzzle3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (picture[0].rotation.z == 0 &&
            picture[1].rotation.z == 0 &&
            picture[2].rotation.z == 0 &&
            picture[3].rotation.z == 0 &&
            picture[4].rotation.z == 0 &&
            picture[5].rotation.z == 0 &&
            picture[6].rotation.z == 0)
        {
            Debug.Log("Win");

            GameDataBase.puzzle3 = true;
            GameDataBase.puzzle3Won = true;
        }
    }
}
