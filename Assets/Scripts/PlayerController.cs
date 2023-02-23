using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

   [SerializeField] private float _speed = 10;



    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }




    void Update()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Zone")
        {
            Debug.Log("Save");
            
        }   
    
    }

   
}
