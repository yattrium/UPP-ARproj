using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    public GameObject OpenedPanel;

    public void CloseP()
    {
        OpenedPanel.SetActive(false);
    }

}
