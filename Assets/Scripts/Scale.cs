using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private float _scaleIncrement = 0.001f;

    private void Update()
    {
        transform.localScale += new Vector3(_scaleIncrement, _scaleIncrement, _scaleIncrement);
    }
}