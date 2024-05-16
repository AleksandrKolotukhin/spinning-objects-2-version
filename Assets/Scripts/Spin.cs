using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _spinSpeed = 5f;

    private void Update()
    {
        transform.Rotate(0, _spinSpeed * Time.deltaTime, 0);
    }
}
