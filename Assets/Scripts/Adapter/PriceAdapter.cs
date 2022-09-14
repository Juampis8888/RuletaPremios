using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PriceAdapter : MonoBehaviour
{
    public TextMeshProUGUI Price;

    public TextMeshProUGUI CandPrime;

    public void Parent(Transform Parent)
    {
        transform.SetParent(Parent);
    }

    public void Location(float topY)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, topY, 0);
    }
}
