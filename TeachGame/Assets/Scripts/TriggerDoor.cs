﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField] Animator myDoor = null;

    [SerializeField] bool openTrigger = false;
    [SerializeField] bool closeTrigger = false;
    [SerializeField] string OpenName = "DoorOpen";
    [SerializeField] string CloseName = "CloceDoor";
    // Start is called before the first frame update

    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(openTrigger)
            {
                myDoor.Play(OpenName,0,0.0f);
                //gameObject.SetActive(false);
            }
            if(closeTrigger)
            {
                //collider.enabled = true;
                myDoor.Play(CloseName,0,0.0f);
                //gameObject.SetActive(false);
            }
        }
    }
}