using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadPirates : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Pirates");
    }
}
