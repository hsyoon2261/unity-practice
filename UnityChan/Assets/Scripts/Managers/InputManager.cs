using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public Action KeyAction = null;
    
    public void OnUpdate()
    {
        if (Input.anyKey == false)
            return;
        if(KeyAction != null) //null 이 아니면 이벤트 발생시켜 
            KeyAction.Invoke();
    }
}
