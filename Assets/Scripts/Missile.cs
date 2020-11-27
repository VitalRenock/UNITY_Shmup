using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float _missileSpeed = 0;
    public float _lifeTime = 0.5f;
    public LayerMask _hitLayer;

    void Start()
    {
        Destroy(gameObject,_lifeTime);
    }

    void Update()
    {
        transform.Translate(Vector2.up* _missileSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_hitLayer == (_hitLayer | (1<< collision.gameObject.layer)))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
