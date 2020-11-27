using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : ScriptableObject
{
    [HideInInspector]
    public EnemyType _enemyType;

    public string _name;
    public float _speed;
    public Sprite _sprite;
    public Color _color;
}
