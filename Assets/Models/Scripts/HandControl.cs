using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandControl : MonoBehaviour
{
    ActionBasedController controller;
    public Hand hand;
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
     hand.SetGrip(controller.selectAction.action.ReadValue<float>());
     hand.SetTrigger(controller.activateAction.action.ReadValue<float>());   
    }
}
