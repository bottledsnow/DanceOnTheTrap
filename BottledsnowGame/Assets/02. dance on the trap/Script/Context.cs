using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context
{
    private State m_state = null;

    public Context()
    {
        Debug.Log("Default context constructor called.");
    }
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
