using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{
public float progress;
private Material material;

private void Start()
{
    material = GetComponent<Image>().material;
}

public void Update(){
    material.SetFloat("_BaseHeight",progress);
}
}
