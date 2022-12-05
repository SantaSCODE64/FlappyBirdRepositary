using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValuesChanging : MonoBehaviour
{
    public ValuesChanging Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    public float jumpValue { get; set; }

    
}
