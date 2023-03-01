using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_smoke : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 0.7f);
    }
}
