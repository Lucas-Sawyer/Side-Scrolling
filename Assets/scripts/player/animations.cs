using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour
{

    private Animator anim;
    private movement_control movement_control;
    private attack attack;
    private int int_move;

    public bool armed;

    // Start is called before the first frame update
    void Start()
    {
        attack = GetComponent<attack>();
        anim = GetComponent<Animator>();
        movement_control = GetComponent<movement_control>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("movement", (int)movement_control.direction);
        if (!armed)
        {
            anim.runtimeAnimatorController = Resources.Load("animations/player/unarmed/unarmed") as RuntimeAnimatorController;
            anim.SetBool("punch", attack.punching);
        }
        else anim.runtimeAnimatorController = Resources.Load("animations/player/armed/armed") as RuntimeAnimatorController;
    }

    public void get_armed()
    {
        armed = true;
    }
}
