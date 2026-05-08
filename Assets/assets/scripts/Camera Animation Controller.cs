using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimationController : MonoBehaviour
{
    public Animator anima;
    public int Position = 1;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    void Update()
    {
        InputHandler();
    }

    private void InputHandler()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Position = 1;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            Position = 2;
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            Position = 3;
        anima.SetInteger("Position", Position);
    }
}
