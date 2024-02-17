using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZones : MonoBehaviour
{

    public EventTrigger.TriggerEvent scoreTrigger;


    private void OnCollisionEnter2D(Collision2D this_collision)
    {
        // Check if collision was with ball
        if (this_collision.gameObject.name == "Ball")
        {

            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);


        }

    }



}