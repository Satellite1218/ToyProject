using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sample
{
    public class HP_System : MonoBehaviour
    {
        public int MaxHP;
        [SerializeField] protected int hp;

        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                if(hp > MaxHP) hp = MaxHP;

                UpdateUI();
            }
        }


        protected virtual void UpdateUI()
        {
            Debug.Log("체력 UI 변동 갱신");

          
        }

        protected virtual void Awake()
        {
            
        }

        public void DecreaseHP(int damage = 1)
        {
            HP -= damage;
        }

        public void IncreaseHP(int value = 1)
        {
            HP += value;
        }


        public bool isDead()
        {
            return hp <= 0 ? true : false;
        }

        // Start is called before the first frame update
        void Start()
        {
            hp = MaxHP;
        }

    }
}
