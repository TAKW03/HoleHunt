using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class end : MonoBehaviour
{
    private Rigidbody rb;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "end")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene("Level02");
        }
    }


}
