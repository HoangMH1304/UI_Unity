using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject obj;

    public void OnClick()
    {
        Debug.Log("On Click");
    }

    public void TurnOn()
    {
        obj.SetActive(true);
    }
}
