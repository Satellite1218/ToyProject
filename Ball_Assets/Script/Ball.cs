using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    //BellSpowner spowner = 

    public enum Color { Red, Black, Yellow }
    public Color color;

    public float Speed = 5.0f;

    public void OnInitialized()
    {
        int RandomIndex = Random.Range(0, 3);

        color = (Color)RandomIndex;
        Speed = 5.0f;
        SetSpeedByColor();
    }

    public void SetSpeedByColor()
    {
        switch(color)
        {
            case Color.Red:
                Speed = Speed * 2f;
                break;
            case Color.Black:
                Speed = Speed * 1.2f; 
                break;
            case Color.Yellow:
                Speed = Speed * 1f;
                break;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.gameObject.SetActive(false);
        }
        else if(collision.collider.CompareTag("NoneDisable"))
        {

            Destroy(this.gameObject);
        }
    }
}
