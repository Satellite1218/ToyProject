using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    [RequireComponent(typeof(EnemyHP))]
    public class Enemy : MonoBehaviour
    {   

        [Header("�Ӽ�")]
        public float speed = 5;
        private Vector3 dir;    // ��� �������� �Լ����� ���� ����� �� �ִ�.

        public GameObject[] explosionFactory; // 1. Smoke, 2. fire �ܺο��� ������� �������� �������ش�.

        [Header("Enemy HP System")]
        public EnemyHP hpController;

        private void Awake()
        {
            hpController = GetComponent<EnemyHP>();
        }

        private void Start()
        {
            int randValue = UnityEngine.Random.Range(0, 10); //  

            if(randValue < 3) // 30%
            {
                GameObject player = GameObject.Find("Player");

                dir = player.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }

        }

        // Update is called once per frame
        void Update()
        {
            transform.position += dir * speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DeadZone")) return;

            if (other.CompareTag("Bullet"))
            {
                GameObject fire = Instantiate(explosionFactory[1]);
                fire.transform.position = transform.position;

                hpController.DecreaseHP();

                Destroy(other.gameObject);

                if (hpController.isDead())
                    Destroy(gameObject); // �浹�� ��� ���ֹ�����.
            }

            if (other.CompareTag("Player"))
            {
                PlayerHP player = other.GetComponent<PlayerHP>();
                player.DecreaseHP();

                GameObject smoke = Instantiate(explosionFactory[0]);
                smoke.transform.position = transform.position;

                if(player.isDead())
                    Destroy(other.gameObject);
            }


          
              // ���� ���ֹ�����.
        }
    }
}
