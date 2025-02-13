using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private bool _isWorking;
    [SerializeField] private float _radius;
    [SerializeField] private float _moveDelay;

    private Vector3 _startPoint;
    private Vector3 _nextPosition;

    private void Awake()
    {
        _startPoint = transform.position;

        StartCoroutine(Run());
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _nextPosition, Time.deltaTime);
    }

    private IEnumerator Run()
    {
        var delay = new WaitForSeconds(_moveDelay);

        while(_isWorking)
        {
            SetRandomPosition();

            yield return delay;
        }
    }

    private void SetRandomPosition()
    {
        _nextPosition = _startPoint + new Vector3(GetRandomRadius(), GetRandomRadius(), 0);
    }

    private float GetRandomRadius() =>
        Random.Range(0, _radius);
}