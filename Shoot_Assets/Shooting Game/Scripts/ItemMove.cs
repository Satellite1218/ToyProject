using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class ItemMove : MonoBehaviour
    {
        public float speed;

        int randomDir;

        private void Start()
        {
            randomDir = Random.Range(1, 3);

            randomDir = randomDir == 1 ? 1 : -1;
        }

        private void Update()
        {
            // �ӷ� * ���� * �ð�

            Vector3 dir = new Vector3(randomDir, -1, 0);

            transform.position += dir * speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player"))
            {
                PlayerHP player = other.GetComponent<PlayerHP>();
                player.IncreaseHP();

                Destroy(gameObject);
            }
        }
    }
}
