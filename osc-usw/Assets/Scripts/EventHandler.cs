using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Valve.VR.InteractionSystem;

public class EventHandler : MonoBehaviour
{
    public PlayableDirector timeline;

    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }
    public void OnButtonPress()
    {
        timeline.Play();
    }
}
