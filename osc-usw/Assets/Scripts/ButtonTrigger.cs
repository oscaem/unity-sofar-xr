using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    GameObject LaunchButton;
    GameObject EnvironmentBaked;
    GameObject EnvironmentUnbaked;

    void Start()
    {
        LaunchButton = GameObject.Find("LaunchButton");
        LaunchButton.SetActive(false);
        EnvironmentBaked = GameObject.Find("EnvironmentBaked");
        //EnvironmentBaked.SetActive(true);
        EnvironmentUnbaked = GameObject.Find("EnvironmentUnbaked");
        EnvironmentUnbaked.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchButton.SetActive(true);
            EnvironmentBaked.SetActive(false);
            EnvironmentUnbaked.SetActive(true);
        
        }
    
    }
}
