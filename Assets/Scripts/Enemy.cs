using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform _target;

    private void Update()
    {
        if (_target == null)
            return;

        Move();
    }

    public void SetTarget(Transform target)
    {
        _target = target;
        transform.up = (Vector2)GetDirection();
    }

    private void Move()
    {
        transform.position += GetDirection() * Time.deltaTime;
    }

    private Vector3 GetDirection()
    {
        return (_target.position - transform.position).normalized;
    }
}