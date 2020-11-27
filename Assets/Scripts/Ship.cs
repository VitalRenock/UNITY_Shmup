using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    Vector2 _direction;
    public float _speed = 10;
    public float _projectileSpeed = 20;

    Camera _camera;
    float _horizontalLimit;
    float _maxHorizontalLimit;
    float _minHorizontalLimit;
    Vector2 _minMaxHorizontalLimit;

    public GameObject _projectilePrefab;

    float _lastShootTime=0;
    public float _shootDelay=0.3f;

    public LayerMask _hitLayer;

    void Start()
    {
        _camera = Camera.main;
        _horizontalLimit = _camera.orthographicSize * _camera.aspect;
        _lastShootTime = -_shootDelay;
    }

    void Update()
    { 
        // Get Input
        _direction = new Vector2(Input.GetAxis("Horizontal"),  0);

        // Move Ship
        transform.Translate(_direction.normalized * _speed * Time.deltaTime);

        // Correction Position Ship
        _minHorizontalLimit = _camera.transform.position.x - _horizontalLimit;
        _maxHorizontalLimit = _camera.transform.position.x + _horizontalLimit;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,_minHorizontalLimit,_maxHorizontalLimit),transform.position.y,transform.position.z);

        //Shoot
        if (Input.GetMouseButton(0) && Time.time > _lastShootTime + _shootDelay)
        {
            GameObject GO= Instantiate(_projectilePrefab, transform.position, Quaternion.identity);
            Missile projectile = GO.GetComponent<Missile>();
            projectile._missileSpeed = _projectileSpeed;
            projectile._lifeTime = 5;
            _lastShootTime = Time.time;
            projectile._hitLayer = _hitLayer;
        }

        if (Input.GetMouseButton(1)) { Time.timeScale = 0.25f; }
        else { Time.timeScale = 1f; }        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, Input.mousePosition);
    }
}