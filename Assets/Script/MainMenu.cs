using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Open_map()
    {
        SceneManager.LoadScene("Map 1_1");
    }
}
