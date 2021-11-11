﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    private GameManager gameManager;
    private itemManager itemManager;

    [SerializeField]
    public int score = 1;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        itemManager = GameObject.Find("Item Manager").GetComponent<itemManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            gameManager.IncreaseScore(score);
            Destroy(gameObject);
            itemManager.ReducePickup();
            Debug.Log("Nabrak");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
