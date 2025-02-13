using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(transform.up * Time.fixedDeltaTime, Space.World);
    }
}