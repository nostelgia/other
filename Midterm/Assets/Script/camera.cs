using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float rotationSpeed = 100f; // 회전 속도

    void Update()
    {
        // 사용자의 입력을 받아 회전 각도 계산
        float rotation = 0f;
        if (Input.GetKey(KeyCode.O))
        {
            rotation = -1f;
        }
        else if (Input.GetKey(KeyCode.P))
        {
            rotation = 1f;
        }

        // 회전 각도를 현재 각도에 더하여 새로운 회전 각도 계산
        transform.Rotate(Vector3.up, rotation * rotationSpeed * Time.deltaTime);
    }
}
