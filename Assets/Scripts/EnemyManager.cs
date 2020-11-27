using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType { Wave, Straight, Strong }

public class EnemyManager : MonoBehaviour
{
    private float _lastTime;
    public float _spawnDelay;

    public EnemyData[] _enemies;

    Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        if (Time.time > _lastTime + _spawnDelay)
        {
            SpawnEnemy();
            _lastTime = Time.time;
        }
    }

    void SpawnEnemy()
    {
        CreateEnemy(GetRandomEnemy());
    }

    GameObject CreateEnemy(EnemyData data)
    {
        GameObject enemyGO = new GameObject(data._name);
        enemyGO.layer = LayerMask.NameToLayer("Enemy");
        SpriteRenderer enemySr = enemyGO.AddComponent<SpriteRenderer>();
        enemySr.sprite = data._sprite;
        enemySr.color = data._color;
        enemyGO.AddComponent<CircleCollider2D>();

        switch (data._enemyType)
        {
            case EnemyType.Wave:
                EnemyWaveData waveData = (EnemyWaveData)data;
                EnemyWave enemyWave = enemyGO.AddComponent<EnemyWave>();
                enemyWave._manager = this;
                enemyWave._speedEnnemy = waveData._speed;
                enemyWave._amplitude = waveData._amplitude;
                break;

            case EnemyType.Straight:
                EnemyStraightData straightData = (EnemyStraightData)data;
                EnemyStraight enemyStraight = enemyGO.AddComponent<EnemyStraight>();
                enemyStraight._manager = this;
                enemyStraight._speedEnnemy = straightData._speed;

                break;

            case EnemyType.Strong:
                EnemyStrongData strongData = (EnemyStrongData)data;
                EnemyStrong enemyStrong = enemyGO.AddComponent<EnemyStrong>();
                enemyStrong._manager = this;
                enemyStrong._speedEnnemy = strongData._speed;
                enemyStrong._angularSpeed = strongData._angularSpeed;
                break;

            default:
                Destroy(enemyGO);
                Debug.LogWarning(data.GetType().ToString() + "In not implemented inside the 'CreateEnemy()' of " + this.name);
                break;
        }
        return enemyGO;
    }

    EnemyData GetRandomEnemy()
    {
        return _enemies[Random.Range(0, _enemies.Length)];
    }

    public void PlaceOnTopOfScreen(Transform enemyTransform)
    {
        float screenHalfWidth = _camera.orthographicSize * _camera.aspect;
        float randomX = Random.Range(-screenHalfWidth, screenHalfWidth);
        float y = _camera.orthographicSize + 1;

        Vector3 spawnPosition = new Vector3(_camera.transform.position.x + randomX, _camera.transform.position.y + y, 0f);
        enemyTransform.position = spawnPosition;
    }

    public bool IsEnemyOffScreenDown(Transform enemyTransform)
    {
        return (enemyTransform.position.y < _camera.transform.position.y - _camera.orthographicSize - 1);
    }
}
