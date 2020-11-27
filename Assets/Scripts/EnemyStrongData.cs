using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStrongData", menuName = "EnemyData/EnemyStrong")]
public class EnemyStrongData : EnemyData
{
    public float _angularSpeed;
    // Constructeur
    public EnemyStrongData()
    {
        _enemyType = EnemyType.Strong;
    }
}