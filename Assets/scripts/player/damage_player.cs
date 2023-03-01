using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage_player : MonoBehaviour
{
    private stats stats;
    private take_damage take_damage;

    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<stats>();
        take_damage = GetComponent<take_damage>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "damage_player":
                stats enemy_stats = other.gameObject.GetComponentInParent<stats>();
                stats.health -= take_damage.damage_me(enemy_stats.damage, stats.armor);
                stats.RB.AddForce(enemy_stats.push_force);
                print("acertou");
                break;
        }
    }
}
