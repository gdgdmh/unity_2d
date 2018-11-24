using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StgDestroyArea : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("test");
        //Debug.LogAssertion("test");
        Destroy(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
        //Destroy(collision.gameObject);
    }
}
