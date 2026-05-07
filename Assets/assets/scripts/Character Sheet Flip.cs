using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheetFlip : MonoBehaviour
{

    public Animator anima;
    public bool flipped = false;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        flipped = !flipped;
        if (flipped == true) 
            anima.SetBool("Flipped", true);
        else if (flipped == false)
            anima.SetBool("Flipped", false);
    }
}
