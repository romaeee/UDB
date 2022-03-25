using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEditor;
using System;

[System.Serializable]
public class CardManager //: MonoBehaviour
{
    public enum Type { Car, Plane, Bike };
    public Type ItemType;

    public string Name;
    public string Mass;
    public string Capacities;
    public string Speed;

    
    public string Other;   
}



