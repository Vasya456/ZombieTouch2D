using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    public static UIGameOver instance;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gameObject.SetActive(false);
    }

   
    void Update()
    {
        

    }

    public void GameOverText() 
    {
        gameObject.SetActive(true);

        DestroyEnemy.instance.DestroyEnemyPrefab();
        DestroyPerson.instance.DestroyPersonPrefab();
       
    }


}
