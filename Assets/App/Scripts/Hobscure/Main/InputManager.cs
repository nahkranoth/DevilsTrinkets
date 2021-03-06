﻿using UnityEngine;
using System.Collections;

public class InputManager {

    public bool GetButton(string name)
    {
        return Input.GetButton(name);
    }

    public bool GetButtonDown(string name)
    {
        return Input.GetButtonDown(name);
    }


    public bool GetButtonUp(string name)
    {
        return Input.GetButtonUp(name);
    }
}
