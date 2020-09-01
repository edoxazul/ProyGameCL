using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        setAnimationTo(number);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void setAnimationTo(int number)
    {
        anim.SetInteger("character", number);
    }
}
