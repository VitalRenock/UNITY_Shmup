using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDestroyable, IMoveable 
{
    [HideInInspector] public EnemyManager _manager;
    public float _speedEnnemy;

    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        Move();
        if(_manager.IsEnemyOffScreenDown(transform)) { Destroy(gameObject); }
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    public virtual void Move()
    {

    }

    protected virtual void Initialize()
    {
        _manager.PlaceOnTopOfScreen(transform);
    }
}
