using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _direction;

    private void Update()
    {
        if (_direction == null)
            return;

        Move();
    }

    public void SetTarget(Vector2 target)
    {
        _direction = target.normalized;
        transform.up = target;
    }

    private void Move()
    {
        transform.position += _direction * Time.deltaTime;
    }
}