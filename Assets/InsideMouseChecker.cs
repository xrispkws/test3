using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideMouseChecker : MonoBehaviour
{
    [SerializeField]
    private GameObject image;
    private RectTransform rect_transform;
    private void Start()
    {
        rect_transform = image.GetComponent<RectTransform>();
    }

    private void Update()
    {
        CheckIsMouseInside();
        CheckIsMouseInside2();
    }

    void CheckIsMouseInside()
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(rect_transform, Input.mousePosition) == true)
        {
            Debug.Log("해당 rect_transform 위에 마우스가 포인팅 되어 있습니다.");
        }
    }

    void CheckIsMouseInside2()
    {
        if (rect_transform.rect.Contains(rect_transform.InverseTransformPoint(Input.mousePosition)))
        {
            Debug.Log("해당 rect_transform 위에 마우스가 포인팅 되어 있습니다.");
        }
    }
}
