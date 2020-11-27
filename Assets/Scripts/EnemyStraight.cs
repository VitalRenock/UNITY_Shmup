using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStraight : Enemy
{
    public override void Move()
    {
        base.Move();
        transform.Translate(Vector3.down * _speedEnnemy);
    }
}
