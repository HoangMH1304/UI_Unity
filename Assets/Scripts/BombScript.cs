using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombScript : MonoBehaviour
{
    public GameObject MyImage;

    public void OnClick()
    {
        Debug.Log("On Click");
    }

    public void OnMouseOver() 
    {
        Debug.Log("On Over");
    }

    public void OnExit()
    {
        Debug.Log("On Exit");
    }

    public void TurnRed()
    {
        // MyImage.GetComponent<Image>().color = new Color32(255,0,0,255);
        MyImage.GetComponent<Image>().color = Color.green;
    } 
}
