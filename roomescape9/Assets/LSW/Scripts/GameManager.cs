using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject optionPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (optionPanel.activeSelf) 
        {
            Time.timeScale = 0; 
        }
        else
        {
            Time.timeScale = 1; 
        }
    }
}
