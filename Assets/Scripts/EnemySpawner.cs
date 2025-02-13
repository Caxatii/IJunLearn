using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private bool _isWorking;
    [SerializeField] private float _delay;

    [SerializeField] private Enemy _prefab;
    [SerializeField] private Transform[] _points;

    private void Start()
    {
        StartCoroutine(Run());
    }

    private IEnumerator Run()
    {
        var delay = new WaitForSeconds(_delay);

        while (_isWorking)
        {
            Spawn();

            yield return delay;
        }
    }

    private void Spawn()
    {
        Transform point = _points[Random.Range(0, _points.Length)];

        Enemy enemy = Instantiate(_prefab);
        enemy.SetTarget(new Vector2(GetRandom(), GetRandom()));
        enemy.transform.position = point.position;
    }

    private float GetRandom() =>
        Random.Range(-1f, 1f);
}