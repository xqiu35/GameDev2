using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventController : MonoBehaviour {

    public GameEvent [] events;

    void OnDisable()
    {
        foreach (GameEvent thisEvent in events)
        {
            EventManager.StopListening(thisEvent.getName(), thisEvent.getAction());
        }
    }

    void Start()
    {
        StartListening();
        TriggerEvents(TriggerType.OnStart);
    }

    void OnTriggerEnter(Collider other)
    {
        TriggerEvents(TriggerType.OnTrigger);
    }

    void Update()
    {
        foreach (GameEvent thisEvent in events)
        {
            if (thisEvent.getTriggerType() == TriggerType.OnUpdate)
            {
                EventManager.StartListening(thisEvent.getName(), thisEvent.getAction());
            }
        }
    }

    void StartListening()
    {
        foreach (GameEvent thisEvent in events)
        {
            EventManager.StartListening(thisEvent.getName(), thisEvent.getAction());
        }
    }

    void TriggerEvents(TriggerType triggerType)
    {
        foreach (GameEvent thisEvent in events)
        {
            if (thisEvent.getTriggerType() == triggerType)
            {
                EventManager.TriggerEvent(thisEvent.getName());
            }
        }
    }
}
