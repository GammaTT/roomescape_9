using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    public GameObject optionPanel;
    public GameObject loadBtn;
    public GameObject saveBtn;

    public void OpenOptionUI()
    {
        optionPanel.SetActive(true);

        if (SceneManager.GetActiveScene().name == "IntroScene")
        {
            loadBtn.SetActive(true);
            saveBtn.SetActive(false);
        }
        else
        {
            loadBtn.SetActive(false);
            saveBtn.SetActive(true);
        }
    }

    public void CloseOptionUI()
    {
        optionPanel.SetActive(false);
    }
}
