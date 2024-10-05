using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("NoneDisable"))
        {
            return;
        }

        if (collision.collider.CompareTag("Disable"))
        {
            Debug.Log(collision.gameObject.name);
            collision.gameObject.SetActive(false);
        }
    }
}
