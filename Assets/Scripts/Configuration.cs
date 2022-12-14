using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Configuration : MonoBehaviour
{
    public Grupo[] groupList;
    public bool enabledEditButtons;
    public bool interactableGroup;
    public Sprite icon;

    public void SetConfiguration(string type)
    {
        if(type =="administrador")
        {
            groupList = Groups.Instance.adminGroups.Clone() as Grupo[];
            enabledEditButtons = true;
            interactableGroup = true;
            icon = Publications.Instance.edit;
        }
        else if(type =="usuario")
        {
            groupList = Groups.Instance.userGroups.Clone() as Grupo[];
            enabledEditButtons = false;
            interactableGroup = true;
            icon = Publications.Instance.lupa;
        }
        else if(type =="vendedor")
        {
            groupList = Groups.Instance.sellerGroups.Clone() as Grupo[];
            enabledEditButtons = true;
            interactableGroup = false;
            icon = null;
        }
        Groups.Instance.SetGroupList(enabledEditButtons, groupList,interactableGroup);
        Publications.Instance.SetEventButton(enabledEditButtons, icon);
    }

    public void ScreenOn(CanvasGroup canvas)
    {
        canvas.alpha = 1;
        canvas.blocksRaycasts = true;
        canvas.interactable = true;
        canvas.ignoreParentGroups = false;
    }

    public void ScreenOff(CanvasGroup canvas)
    {
        canvas.alpha = 0;
        canvas.blocksRaycasts = false;
        canvas.interactable = false;
        canvas.ignoreParentGroups = false;
    }
}
