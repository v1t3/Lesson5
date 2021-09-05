using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private List<GameObject> allHats = new List<GameObject>();
    [SerializeField] private List<Renderer> rendererList = new List<Renderer>();

    [SerializeField] private Slider sizeSlider;
    
    [SerializeField] private Text nameField;

    private void Start()
    {
        SetSliderValue(transform.localScale.x);
    }

    public void SetHat(int index)
    {
        for (int i = 0; i < allHats.Count; i++)
        {
            if (i == index)
            {
                allHats[i].SetActive(true);
            }
            else
            {
                allHats[i].SetActive(false);
            }
        }
    }

    public void SetMaterial(Material material)
    {
        foreach (var rendererItem in rendererList)
        {
            rendererItem.material = material;
        }
    }

    private void SetSliderValue(float value)
    {
        sizeSlider.value = value;
    }

    public void SetSize(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    public void SetName(string value)
    {
        nameField.text = value;
    }
}