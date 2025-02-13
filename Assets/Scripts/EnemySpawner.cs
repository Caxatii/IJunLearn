using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private bool _isWorking;
    [SerializeField] private float _delay;

    [SerializeField] private Enemy _prefab;
    [SerializeField] private Target _target;

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
        Enemy enemy = Instantiate(_prefab);
        enemy.SetTarget(_target.transform);
        enemy.transform.position = transform.position;
    }

    private float GetRandom() =>
        Random.Range(-1f, 1f);
}