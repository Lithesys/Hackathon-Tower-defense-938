using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health_Count : MonoBehaviour
{
    public TMP_Text Health;
    public int health = 30;
    // Start is called before the first frame update
    void Start()
    {
        Health.text = health.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
