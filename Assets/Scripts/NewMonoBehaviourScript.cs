using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private void Awake()
    {
        Debug.Log(message: "Awake");
    }
    private void Start()
    {
        Debug.Log(message: "Start");
    }
    private void OnEnable()
    {
        Debug.Log(message: "OnEnable");
    }
    private void OnDestroy()
    {
        Debug.Log(message: "OnDestroy");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(message: "碰到地板");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(message:"進入偵測區域");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(message:"離開偵測區域");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
