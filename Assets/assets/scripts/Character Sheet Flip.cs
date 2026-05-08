using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheetFlip : MonoBehaviour
{
    private Camera cam;
    public Vector3 offset = new Vector3(-0.247999996f, 5.96000004f, -1.83200002f); // Position relative to camera
    public Quaternion rotationOffset = new Quaternion(0, 0.858942568f, 0.512072027f, 0); // Extra rotation if needed
    public float smoothSpeed = 5f; // Adjust for faster/slower movement
    public Animator anima;

    public bool flipped = false;
    public bool Inspect = false;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        anima = GetComponent<Animator>();
        anima.SetBool("Flipped", false);
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButtonDown(1) && !Inspect)
        {
            flipped = !flipped;
            if (flipped)
                anima.SetBool("Flipped", true);
            else if (!flipped)
                anima.SetBool("Flipped", false);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Inspect = !Inspect;

            if (Inspect && cam)
            {
                anima.enabled = false;
                // Calculate target position and rotation
                Vector3 targetPosition = cam.transform.position + (cam.transform.rotation * offset);
                Quaternion targetRotation = cam.transform.rotation * rotationOffset;

                // Smoothly interpolate from current state to target state
                transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothSpeed);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * smoothSpeed);
            }
            else anima.enabled = true;
        }
    }

}
