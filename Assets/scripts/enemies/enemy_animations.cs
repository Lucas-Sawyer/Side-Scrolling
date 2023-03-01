using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_animations : MonoBehaviour
{
    private Animator anim;
    private stats stats;
    private attack_player attack_player;
    private GameObject damage_collider;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        attack_player = GetComponent<attack_player>();
        stats = GetComponent<stats>();
        damage_collider = transform.GetChild(1).gameObject;
        damage_collider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("velocity", (int)stats.RB.velocity.x);

        if (attack_player.attack && attack_player.can_attack)
        {
            anim.Play("attack");
        }
    }

    public void deal_damage()
    {
        damage_collider.SetActive(true);
    }

    public void end_attack()
    {
        attack_player.can_attack = false;
        attack_player.time = 0;
        damage_collider.SetActive(false);
    }
}
