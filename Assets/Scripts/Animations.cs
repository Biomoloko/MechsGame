using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator anim;
    void Start()
    {

    }

    void Update()
    {

    }

    public void AnimLogic(float horRotForTurn, float vertMoveForWalk)
    {
        if (vertMoveForWalk > 0)
        {
            anim.SetBool("Walk", true);
            anim.SetFloat("Speed", 1.05f);
        }
        else if (vertMoveForWalk < 0)
        {
            anim.SetBool("Walk", true);
            anim.SetFloat("Speed", -1.05f);
        }
        else
        anim.SetBool("Walk", false);

        if (horRotForTurn > 0 || horRotForTurn < 0)
            anim.SetBool("Turn", true);
        else
            anim.SetBool("Turn", false);

    }
}
