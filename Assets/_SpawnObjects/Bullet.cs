using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speed; // Units to move per second.

    private void Update()
    {
        // Moves this object _speed units per second on the Z axis.
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
