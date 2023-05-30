using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;


public enum TypeTag
{
    Player,
    Trap,
    Checkpoint,
    Finish,
    Trigger,
}

public class TriggerEvent : MonoBehaviour
{
    public TypeTag targetTag;
    public UnityEvent<GameObject> OnTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == targetTag.ToString())
        {
            OnTrigger?.Invoke(collision.gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
