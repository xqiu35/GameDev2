using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnEvent : GameEvent
{
    public GameObject spawnObject;
    public SpawnPoint spawnPoint;
    public TriggerType triggerType;

    private UnityAction eventAction;
    private string thisEventName = "Spawn";

    void OnEnable()
    {
        base.eventName = thisEventName;
        base.action = new UnityAction(Spawn);
        base.type = triggerType;
    }

    void Spawn()
    {
        Instantiate(spawnObject, spawnPoint.transform.position, Quaternion.identity);
    }
}
