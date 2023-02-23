using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public static DestroyEnemy instance;


    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Destroy(gameObject);

        UIScore.instance.AddPoint();
               
    }
    
    public void DestroyEnemyPrefab()
    {
        gameObject.SetActive(false);
    }
}

