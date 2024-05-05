using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // 이동 속도

    void Update()
    {
        // 사용자의 입력을 받아 이동 벡터 계산
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // 이동 벡터를 현재 위치에 더하여 새로운 위치 계산
        transform.Translate(movement, Space.World);

    }
}
