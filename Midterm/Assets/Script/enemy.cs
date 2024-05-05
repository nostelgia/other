using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform
    public float moveSpeed = 3f; // �̵� �ӵ�
    public float stoppingDistance = 2f; // �÷��̾���� �ּ� �Ÿ�

    void Update()
    {
        // �÷��̾� �������� �̵�
        if (player != null)
        {
            Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.LookAt(targetPosition); // �÷��̾ �ٶ󺸵��� ȸ��

            float distanceToPlayer = Vector3.Distance(transform.position, targetPosition);
            if (distanceToPlayer > stoppingDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            }
        }
    }
}
