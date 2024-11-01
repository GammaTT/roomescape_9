using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject storyPanel;

    public void OnClickStoryPanel()
    {
        storyPanel.SetActive(false);
    }
}
