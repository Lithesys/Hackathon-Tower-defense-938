using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Close_Panel : MonoBehaviour
{
    public GameObject Panel;
    public void Close_panel()
    {
        Panel.SetActive(false);
    }
        public void Open_panel(){
        Panel.SetActive(true);
    }
}
