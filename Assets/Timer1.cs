using UnityEngine;
using System.Collections;

public class Timer1 : MonoBehaviour
{

    public GameObject Character;      


    private Vector3 offset;         

    
    void Start()
    {
       
        offset = transform.position - Character.transform.position;
    }

   
    void LateUpdate()
    {
        
        transform.position = Character.transform.position + offset;
    }
}