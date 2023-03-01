using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage_enemy : MonoBehaviour
{
    private stats stats;
    private take_damage take_damage;
    // Start is called before the first frame update
    void Start()
    {
        take_damage = GetComponent<take_damage>();
        stats = GetComponent<stats>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "damage_enemy":
                bullet bullet;
                bullet = other.gameObject.GetComponent<bullet>();
                stats.health -= take_damage.damage_me(bullet.damage, stats.armor);
                stats.RB.AddForce(bullet.push_force);
                break;
        }
        print("acertou");
    }
}
