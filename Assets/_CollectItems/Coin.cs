using UnityEngine;

public class Coin : MonoBehaviour
{
    public float _rotateSpeed; // Number of degrees to rotate per second.
    
    void Update()
    {
        // Rotates around the Z axis by _rotateSpeed degrees per seconds.
        transform.Rotate(Vector3.forward * _rotateSpeed * Time.deltaTime);
    }
}
