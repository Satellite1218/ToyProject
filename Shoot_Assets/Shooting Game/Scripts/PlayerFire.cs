using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class PlayerFire : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public GameObject bulletFactory; // �Ѿ��� ������ ����
        public Transform bulletPos;      // �Ѿ��� ������ ��ġ

        // �÷��̾��� �Է� Input class
        // ���� ����.      GameObject.Instatiate();

        // Update is called once per frame
        void Update()
        {
            // �÷��̾��� ���콺 ���� Ŭ�� �Է�
            if(Input.GetButtonDown("Fire1"))
            {
                InstantBullet();
            }

            // �÷��̾��� �����̽� ��
            if(Input.GetKeyDown(KeyCode.Space))
            {
                InstantBullet();
            }
        }

        void InstantBullet()
        {
            GameObject bullet = Instantiate(bulletFactory); // �Ѿ��� �����Ѵ�.
            bullet.transform.position = bulletPos.position;
        }
    }
}
