using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed { get; set; } = 4f;

    public int Bust = 100;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -1, -3);
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxisRaw("Horizontal");
        //
        //transform.Translate(new Vector3(horizontal,0 ,0) * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.right * Speed * Time.deltaTime * 2);
            }
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.left * Speed * Time.deltaTime * 2);
            }
        }
        
    }
}
