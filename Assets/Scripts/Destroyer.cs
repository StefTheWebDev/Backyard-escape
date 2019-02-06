using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Destroyer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Fall")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Destroy(gameObject);
        }
        if (coll.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            Destroy(gameObject);
        }
        if (coll.gameObject.tag == "Finish2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            Destroy(gameObject);
        }

        if (coll.gameObject.tag == "end1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
            Destroy(gameObject);
        }






    }
}
