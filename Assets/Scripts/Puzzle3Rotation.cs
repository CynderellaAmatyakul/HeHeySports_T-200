using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3Rotation : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameDataBase.puzzle3)
        {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
