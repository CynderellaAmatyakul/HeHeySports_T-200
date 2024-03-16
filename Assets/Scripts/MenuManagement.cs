using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagement : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    bool isMenu = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MenuFunction();
    }

    public void MenuFunction()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isMenu)
        {
            Menu.SetActive(true);
            isMenu = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isMenu)
        {
            Menu.SetActive(false);
            isMenu = false;
        }
    }
}
