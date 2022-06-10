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
            Debug.Log("�ش� rect_transform ���� ���콺�� ������ �Ǿ� �ֽ��ϴ�.");
        }
    }

    void CheckIsMouseInside2()
    {
        if (rect_transform.rect.Contains(rect_transform.InverseTransformPoint(Input.mousePosition)))
        {
            Debug.Log("�ش� rect_transform ���� ���콺�� ������ �Ǿ� �ֽ��ϴ�.");
        }
    }
}
