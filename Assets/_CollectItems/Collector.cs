using UnityEngine;

/// <summary>
/// https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
/// </summary>
public class Collector : MonoBehaviour
{
    public float _speed; // Number of units to move each second.
    public TMPro.TextMeshProUGUI _labelCoins; // Text label to show the number of coins.

    private int _coinAmount; // Amount of coins.

    private void Update()
    {
        // Moves this object on the X axis by _speed units each second.
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // "other" is the collider that entered the Trigger assigned to this GameObject.

        // Checks if it's a Coin (by name).
        if(other.name == "Coin")
        {
            // Destroys the Coin GameObject.
            Destroy(other.gameObject);

            // Increments the coin amount by 1.
            _coinAmount++;

            // Updates the text label with the coin amount value.
            _labelCoins.text = _coinAmount.ToString();
        }
    }
}
