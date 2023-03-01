using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw_prefab : MonoBehaviour
{
    public void spaw(GameObject prefab, Vector3 spaw)
    {
        Instantiate(prefab, spaw, Quaternion.identity);
    }
}
