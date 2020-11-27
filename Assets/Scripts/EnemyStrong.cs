using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStrong : Enemy
{
    public float _angularSpeed;

    public override void Move()
    {
        base.Move();
        transform.Translate(Vector3.down * _speedEnnemy);
        transform.Rotate(new Vector3(1f, 0f, 0f));
    }

}
