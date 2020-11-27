using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStraightData", menuName = "EnemyData/EnemyStraight")]
public class EnemyStraightData : EnemyData
{
    // Constructeur
    public EnemyStraightData()
    {
        _enemyType = EnemyType.Straight;
    }
}
