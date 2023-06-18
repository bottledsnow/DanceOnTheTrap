using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStateA : State
{
    public ConcreteStateA(Context context):base(context)
    {
        Debug.Log("ConcreteStateA.ConcreteStateA()");
    }

    public override void Handle(int Value)
    {
        Debug.Log("ConcreteStateA.Handle()" + Value);
        if (Value > 10)
        {
            m_Context.SetState(new ConcreteStateB(m_Context));
        }
    }
}

public class ConcreteStateB : State
{
    public ConcreteStateB(Context context) : base(context)
    {
        Debug.Log("ConcreteStateB.ConcreteStateB()");
    }
    public override void Handle(int Value)
    {
        Debug.Log("ConcreteStateB.Handle()" + Value);
        if (Value > 20)
        {
            m_Context.SetState(new ConcreteStateC(m_Context));
        }
    }
}

public class ConcreteStateC : State
{
    public ConcreteStateC(Context context) : base(context)
    {
        Debug.Log("ConcreteStateC.ConcreteStateC()");
    }
    public override void Handle(int Value)
    {
        Debug.Log("ConcreteStateC.Handle()" + Value);
        if (Value > 30)
        {
            m_Context.SetState(new ConcreteStateA(m_Context));
        }
    }
}
