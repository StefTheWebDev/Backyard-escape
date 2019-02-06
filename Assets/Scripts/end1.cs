using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class End1 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "end1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            Destroy(gameObject);
        }







    }
}
