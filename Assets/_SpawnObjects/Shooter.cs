using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform _prefab; // Object to instantiate.

    private void Start()
    {
        // Call method Shoot immediately (0) and on every second afterwards (1).
        InvokeRepeating(nameof(Shoot), 0, 1);
    }

    private void Shoot()
    {
        // Instantiate _prefab at this object position with the prefab rotation values.
        Instantiate(_prefab, transform.position, _prefab.rotation);
    }
}
