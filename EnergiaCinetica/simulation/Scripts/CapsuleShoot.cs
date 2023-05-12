using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleShoot : MonoBehaviour
{
    public CapsuleBehavior weapon;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            weapon.Fire();
    }
}
