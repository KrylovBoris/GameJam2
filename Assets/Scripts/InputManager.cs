﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InputManager : MonoBehaviour
{
    Vector3 inputMovement;
    private Movement movSystem;
    private Aim aimSystem;
    private Attack attackSystem;

    void Awake()
    {
        movSystem = GetComponent<Movement>();
        aimSystem = GetComponent<Aim>();
        attackSystem = GetComponent<Attack>();
    }

    // Update is called once per frame
    void Update()
    {
        inputMovement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movSystem.MovementVector = inputMovement;
        aimSystem.FaceForwardDirection(Input.mousePosition);
        if (Input.GetButtonDown("BaseAttack")) attackSystem.BaseAttack();
        if (Input.GetButtonDown("AltAttack")) attackSystem.AltAttack();
    }
}

