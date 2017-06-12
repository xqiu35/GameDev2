using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BattleEvent : GameEvent {

    private UnityAction eventAction;
    private string thisEventName = "Battle";
    private Collider other;
    public TriggerType triggerType;

    void OnEnable()
    {
        base.eventName = thisEventName;
        base.action = new UnityAction(Battle);
        base.type = triggerType;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HeroBase>())
        {
            this.other = other;
        }
    }

    void Battle()
    {
        if(other!=null)
        {
            Debug.Log(other.name);
        }
    }
}
