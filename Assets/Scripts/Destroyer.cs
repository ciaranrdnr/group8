﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Menghancurakn object

        Destroy(collision.gameObject);
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
