using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationVector;
    [SerializeField] private Slider _slider;

    AudioSource _aSource;

    private void Start()
    {
        _aSource = GetComponent<AudioSource>();

        _slider.minValue = 0;
        _slider.maxValue = 1000f;
        _slider.value = 100f;
    }

    private void Update()
    {
        _rotationVector.y = _slider.value;
        transform.Rotate(_rotationVector * Time.deltaTime);
        _aSource.volume = _slider.value / 1000f;
    }
}
