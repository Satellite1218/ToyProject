using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Bullet : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public float speed = 5;

        // ���� x speed x time.deltaTime

        // Update is called once per frame
        void Update()
        {
            // ����
            Vector3 dir = Vector3.up;
            transform.position = transform.position + dir * speed * Time.deltaTime;
        }
    }
}
