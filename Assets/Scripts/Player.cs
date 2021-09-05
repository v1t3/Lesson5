using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private List<GameObject> allHats = new List<GameObject>();
    [SerializeField] private List<Renderer> rendererList = new List<Renderer>();

    [SerializeField] private Text nameField;

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

    public void SetName(string value)
    {
        nameField.text = value;
    }
}