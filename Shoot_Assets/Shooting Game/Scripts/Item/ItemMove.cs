using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class ItemMove : MonoBehaviour
    {

        [Header("�Ӽ�")]
        public float speed = 0.8f;
        private Vector3 dir;    // ��� �������� �Լ����� ���� ����� �� �ִ�.

        public GameObject[] explosionFactory; // 1. Smoke, 2. fire �ܺο��� ������� �������� �������ش�.

        int rand;

        private void Start()
        {
            int randValue = UnityEngine.Random.Range(0, 10); //  

            if (randValue < 3) // 30%
            {
                GameObject player = GameObject.Find("Player");

                dir = player.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }


            rand = UnityEngine.Random.Range(1, 3);

            rand = rand == 1 ? 1 : -1;
        }

        // Update is called once per frame
        void Update()
        {
            dir = new Vector3(rand, -1, 0);

            transform.position += dir * speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DeadZone")) return;

            if (other.CompareTag("Player"))
            {
                PlayerHP player = other.GetComponent<PlayerHP>();
                player.IncreseHP();

                 Destroy(this.gameObject);
            }



            // ���� ���ֹ�����.
        }
    }
}
