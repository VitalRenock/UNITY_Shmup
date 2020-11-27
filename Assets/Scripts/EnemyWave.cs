using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : Enemy
{
    public float _amplitude;

    public override void Move()
    {
        base.Move();
        transform.position = new Vector3(Mathf.Sin(transform.position.y) * _amplitude, transform.position.y - _speedEnnemy * Time.deltaTime, 0f);
    }
}
