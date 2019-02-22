﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollapse : MonoBehaviour
{
    public GameObject EVE;
    public float offset;
    public float deleteTime;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Player")
        {
            var instantiateEffect = GameObject.Instantiate(EVE, transform.position + new Vector3(0f, offset, 0f), Quaternion.identity) as GameObject;
            Destroy(instantiateEffect, deleteTime);
            Destroy(this.gameObject, 0.1f);
        }
    }
}