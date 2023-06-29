using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RotationTest : MonoBehaviour
{
    [SerializeField] private GameObject Cube;
    [SerializeField] private Transform Center;
    [SerializeField] private Transform LookAtPoint;
    [SerializeField] private Vector3 Elur;



    private void TransformRotate(Vector3 vector)
    {
        Cube.transform.Rotate(vector, 90f);
    }
    private void TransformRotate()
    {
        Cube.transform.Rotate(Elur);
    }

    private void TrasformRotateAround()
    {
        Cube.transform.RotateAround(Center.position, Vector3.up, 90f);
    }
    private void TrasformLookAt()
    {
        Cube.transform.LookAt(LookAtPoint);
    }

    public void Handle()
    {
        TransformRotate();
    }
}
