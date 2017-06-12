using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEvent : MonoBehaviour {

    protected string eventName { get; set; }
    protected UnityAction action { get; set; }
    protected TriggerType type { get; set; }

    public string getName()
    {
        return eventName;
    }

    public UnityAction getAction()
    {
        return action;
    }

    public TriggerType getTriggerType()
    {
        return type;
    }
}
