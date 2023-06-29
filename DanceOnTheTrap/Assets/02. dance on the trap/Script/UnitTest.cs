using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitTest : MonoBehaviour
{
    private void Start()
    {
        UnitTest_implement();
        Vector3 vector = new Vector3(1, 2, 3);
    }
    private void UnitTest_implement()
    {
        Context context = new Context();
        context.SetState(new ConcreteStateA(context));
        context.Request(5);
        context.Request(15);
        context.Request(25);
        context.Request(35);
    }
}