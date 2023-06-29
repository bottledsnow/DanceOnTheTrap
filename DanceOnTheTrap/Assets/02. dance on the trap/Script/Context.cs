using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context
{
    private State m_state = null;
    public void Request(int Value)
    {
        m_state.Handle(Value);
    }

    public void SetState(State state)
    {
        Debug.Log("Context.SetState()" + state);
        m_state = state;
    }
}
