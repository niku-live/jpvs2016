using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour 
{
  
  public float speed = 0.2f;

  void Start () 
  {  
  }
  
  void Update () 
  {
    Vector2 offset = new Vector2(Time.time * speed, 0f);
    GetComponent<Renderer>().material.mainTextureOffset = offset;﻿
  }
  
}
