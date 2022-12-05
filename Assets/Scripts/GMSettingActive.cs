using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMSettingActive : MonoBehaviour
{
    public GameObject GM;

    public void GMActivation()
    {
        if (!GM.activeSelf)
        {
            GM.SetActive(true);
        }
    }
}
