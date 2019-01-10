using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitButton : MonoBehaviour
{

    public Button ExitButton;

    void Start()
    {
        Button Exit = ExitButton.GetComponent<Button>();
        Exit.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.Quit();
    }
}