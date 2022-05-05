using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    [Header("ũ��ӵ� ����")]
    [SerializeField][Range(1f, 5f)] float scaleSpeed = 1f;

    void Update()
    {
        //ũ��(��� C / Ȯ�� V)
        if (Input.GetKey(KeyCode.C))
        {
            transform.localScale = new Vector3
            (transform.localScale.x - 1f * scaleSpeed * Time.deltaTime,
            transform.localScale.y - 1f * scaleSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.V))
        {
            transform.localScale = new Vector3
            (transform.localScale.x + 1f * scaleSpeed * Time.deltaTime,
            transform.localScale.y + 1f * scaleSpeed * Time.deltaTime, 0);
        }

        Zoom(); 
    }

    public void Zoom()
    {
        var scroll = Input.mouseScrollDelta;
        transform.localScale = new Vector3

(transform.localScale.x - 3f * scaleSpeed * Time.deltaTime * scroll.y,
            transform.localScale.y - 3f * scaleSpeed * Time.deltaTime * scroll.y, 0);

    }
}