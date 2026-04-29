using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPDial : MonoBehaviour
{
    private Quaternion currentRotation;
    private Quaternion targetRotation;
    public float speed = 5;

    public enum CPValues { Zero = 0, One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Eleven = 11, Twelve = 12, Thirteen = 13, Fourteen = 14, Fifteen = 15 }

    private void Update()
    {
        if (currentRotation != targetRotation)
        {
            float step = speed * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, step);
        }
    }

    public void SetTargetRotation(Quaternion targetRotation)
    {
        this.targetRotation = targetRotation;
    }

    public void SetTargetRotation(CPValues value)
    {
        switch (value)
        {
            case CPValues.Zero:
                targetRotation = Quaternion.Euler()
                break;
            case CPValues.One:
                break;
            case CPValues.Two:
                break;
            case CPValues.Three:
                break;
            case CPValues.Four:
                break;
            case CPValues.Five:
                break;
            case CPValues.Six:
                break;
            case CPValues.Seven:
                break;
            case CPValues.Eight:
                break;
            case CPValues.Nine:
                break;
            case CPValues.Ten:
                break;
            case CPValues.Eleven:
                break;
            case CPValues.Twelve:
                break;
            case CPValues.Thirteen:
                break;
            case CPValues.Fourteen:
                break;
            case CPValues.Fifteen:
                break;
        }
    }
}
