using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace ClassStudy
{
    public class PlayerMove : MonoBehaviour
    {
        // ��ǥ
        // �÷��̾ �����δ�.
        // ���� : ���Ʒ�,���� ������ 
        // �ӵ� : ���� x �ӷ�

        [Header("�Ӽ�")]
        public float speed=5; // �̵� �ӷ�


        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 dir = new Vector3(horizontal, vertical, 0);
            dir.Normalize();

            transform.position = transform.position + dir * speed * Time.deltaTime;
        }



 
    }
}
