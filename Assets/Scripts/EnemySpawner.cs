using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private bool _isWorking;
    [SerializeField] private float _delay;

    [SerializeField] private Enemy _prefab;
    [SerializeField] private Transform[] _points;

    private IEnumerator Start()
    {
        var delay = new WaitForSeconds(_delay);

        while(_isWorking)
        {
            Spawn();

            yield return delay;
        }
    }

    private void Spawn()
    {
        int min = -179;
        int max = 179;

        Transform point = _points[Random.Range(0, _points.Length)];

        Enemy enemy = Instantiate(_prefab);
        enemy.transform.position = point.position;
        enemy.transform.rotation = Quaternion.Euler(0, 0, Random.Range(min, max));
    }
}