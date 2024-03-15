using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotation : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameDataBase.puzzle1)
        {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
