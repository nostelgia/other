using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // �̵� �ӵ�

    void Update()
    {
        // ������� �Է��� �޾� �̵� ���� ���
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // �̵� ���͸� ���� ��ġ�� ���Ͽ� ���ο� ��ġ ���
        transform.Translate(movement, Space.World);
<<<<<<< HEAD

=======
>>>>>>> a4b6843e3429cb91edf98e8bd1ae9af3aae6effe
    }
}
