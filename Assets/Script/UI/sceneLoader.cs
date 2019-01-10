using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour {

    public Button PlayButton;

    void Start()
    {
        Button Play = PlayButton.GetComponent<Button>();
        Play.onClick.AddListener(TaskOnClick);
    }

    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    void TaskOnClick()
    {
        SceneLoader(1);
    }
}
