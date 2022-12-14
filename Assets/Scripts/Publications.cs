using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Publications : MonoBehaviour
{
    public static Publications Instance{get; private set;}

    public Sprite lupa;
    public Sprite edit;
    public Image[] eventButton;
    public GameObject editButtons;

    private void Awake()
    {
        if(Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }
    public void SetEventButton(bool enabledEditButtons, Sprite icon)
    {
        editButtons.SetActive(enabledEditButtons);  
        foreach(Image i in eventButton)
            i.sprite = icon;
    }

    
}
