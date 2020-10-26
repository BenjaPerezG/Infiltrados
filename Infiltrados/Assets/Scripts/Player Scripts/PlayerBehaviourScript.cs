using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{

    private PlayerPhysicsController PhysicsController;
    private InputController InputController;
    private PlayerStateController StateController;
    private PlayerLightsController LightsController;

    [SerializeField]
    private int _viewRadius;

    // Start is called before the first frame update
    void Start()
    {
        PhysicsController = GetComponent<PlayerPhysicsController>();
        InputController = GetComponent<InputController>();
        StateController = GetComponent<PlayerStateController>();
        LightsController = GetComponent<PlayerLightsController>();
    }

    // Update is called once per frame
    void Update()
    {
        PhysicsController.movementVector = InputController.CheckMovement();
        LightsController.ManageLight(StateController.isBlind);
    }

    private void FixedUpdate()
    {
        PhysicsController.Move();
    }


}
