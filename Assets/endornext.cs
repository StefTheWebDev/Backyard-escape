using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Endornext : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "end")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            Destroy(gameObject);
        }







    }
}