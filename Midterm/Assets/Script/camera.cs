using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float rotationSpeed = 100f; // ȸ�� �ӵ�

    void Update()
    {
        // ������� �Է��� �޾� ȸ�� ���� ���
        float rotation = 0f;
        if (Input.GetKey(KeyCode.O))
        {
            rotation = -1f;
        }
        else if (Input.GetKey(KeyCode.P))
        {
            rotation = 1f;
        }

        // ȸ�� ������ ���� ������ ���Ͽ� ���ο� ȸ�� ���� ���
        transform.Rotate(Vector3.up, rotation * rotationSpeed * Time.deltaTime);
    }
}
