using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.CompareTag("Player1"))
        {
            
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {

        }
        else if (collision.gameObject.CompareTag("Player3"))
        {

        }*/

        Destroy(collision.gameObject);
    }
}
