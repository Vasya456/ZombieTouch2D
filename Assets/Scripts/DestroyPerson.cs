using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPerson : MonoBehaviour
{
    public static DestroyPerson instance;

    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        SpawnManager.instance.GameOver();
        
        UIGameOver.instance.GameOverText();
    }

    public void DestroyPersonPrefab()
    {
        gameObject.SetActive(false);
    }


}
