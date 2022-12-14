using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

[Serializable]
public class Grupo
{
    public Image image;
    public Sprite sprite;
    public string name;
}

public class Groups : MonoBehaviour
{
    public static Groups Instance{get; private set;}
    public Grupo[] userGroups;
    public Grupo[] adminGroups;
    public Grupo[] sellerGroups;
    public GameObject editButtons;
    //public TMP_Text titleGroup;

    private void Awake()
    {
        if(Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    public void SetGroupList(bool enabledEditButtons, Grupo[] groupList, bool interactableGroup)
    {
        editButtons.SetActive(enabledEditButtons);
        foreach(Grupo g in groupList)
        {
            g.image.sprite = g.sprite;
            //g.image.transform.Find("Text").GetComponent<TMP_Text>().text = g.name;
            g.image.GetComponent<Button>().interactable = interactableGroup;
        }
    }

    /*public void SetNameGroup(TMP_Text text)
    {
        titleGroup.text = text.text;
    }*/
}
