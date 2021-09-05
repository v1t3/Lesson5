using UnityEngine;
using UnityEngine.UI;

public class Size : MonoBehaviour
{
    [SerializeField] private Slider sizeSlider;

    private void Start()
    {
        SetSliderValue(transform.localScale.x);
    }

    private void SetSliderValue(float value)
    {
        sizeSlider.value = value;
    }

    public void SetSize(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }
}