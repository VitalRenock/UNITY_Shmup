using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveShoot : EnemyWave
{
    void Start()
    {
        Move();
    }

    public override void Move()
    {
        base.Move();
        Debug.Log(" but i'm little boy");
    }
}
