using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyWaveData", menuName = "EnemyData/EnemyWave")]
public class EnemyWaveData : EnemyData
{
    // Constructeur
    public EnemyWaveData()
    {
        _enemyType = EnemyType.Wave;
    }
    public float _amplitude;
}