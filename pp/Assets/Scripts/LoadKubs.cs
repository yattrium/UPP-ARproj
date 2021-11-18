using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadKubs : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Kubies");
    }
}
