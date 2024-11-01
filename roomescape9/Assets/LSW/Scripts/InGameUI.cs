using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : MonoBehaviour
{
    public GameObject storyPanel;
    public GameObject optionPanel;
    public GameObject saveButton;
    public GameObject loadButton;

    private void Start()
    {
        
    }

    public void OnClickStoryPanel()
    {
        storyPanel.SetActive(false);
    }

    public void OnClickCloseBtn()
    {
        optionPanel.SetActive(false);
    }

}
