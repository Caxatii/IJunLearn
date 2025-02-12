using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Awake()
    {
        float destroyTime = 10;

        Destroy(gameObject, destroyTime);
    }

    private void FixedUpdate()
    {
        transform.Translate(transform.up * Time.fixedDeltaTime, Space.World);
    }
}