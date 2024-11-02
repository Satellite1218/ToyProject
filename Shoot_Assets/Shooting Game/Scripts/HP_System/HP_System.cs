using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_System : MonoBehaviour
{
    [SerializeField] protected int hp;     //현재체력
    public int maxHP;   //최대체력

    public int HP
    {
        get { return hp; }
        set
        {
            hp = value; //HP값을 value로 변경

            if (hp >= maxHP)
            {
                hp = maxHP;  //최대 체력을 넘지 못하게
            }

            if (hp <= 0)
            {
                hp = 0; //체력이 음수로 떨어지지 않게
            }

            UpdateUI();        //HP변경시 체력 UI 갱신
        }
    }

    protected virtual void Awake()
    {
        
    }

    protected virtual void UpdateUI()
    {

    }

    public void DecreaseHP(int dmage = 1)
    {
        HP -= dmage;
    }

    public void IncreseHP(int value = 1)
    {
        HP += value;
    }

    public bool isDead()
    {
        return HP <= 0 ? true : false;
    }

    private void Start()
    {
        hp = maxHP;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            DecreaseHP();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            IncreseHP();
        }
    }
}
