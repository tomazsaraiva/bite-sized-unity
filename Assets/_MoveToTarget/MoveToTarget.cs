using UnityEngine;

/// <summary>
/// https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html
/// </summary>
public class MoveToTarget : MonoBehaviour
{
    public Transform _target; // Object to move towards
    public float _speed; // Number of units to move each second

    private void Update()
    {
        // Moves this object towards _target by _speed units each second
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}