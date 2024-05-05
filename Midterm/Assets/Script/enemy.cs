using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform
    public float moveSpeed = 3f; // 이동 속도
    public float stoppingDistance = 2f; // 플레이어와의 최소 거리

    void Update()
    {
        // 플레이어 방향으로 이동
        if (player != null)
        {
            Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.LookAt(targetPosition); // 플레이어를 바라보도록 회전

            float distanceToPlayer = Vector3.Distance(transform.position, targetPosition);
            if (distanceToPlayer > stoppingDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            }
        }
    }
}
