using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Translate(transform.up * Time.fixedDeltaTime, Space.World);
    }
}