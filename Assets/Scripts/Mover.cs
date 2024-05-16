using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;
    [SerializeField] private float _distance = 0.5f;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        Vector3 newPosition = transform.position + transform.forward * _speed * Time.deltaTime;

        transform.position = newPosition;
    }
}