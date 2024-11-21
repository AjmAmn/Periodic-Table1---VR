using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementPanelManager : MonoBehaviour
{
    public GameObject[] elementPanels;

    // This function will be called when a button is clicked
    public void ShowPanel(int panelIndex)
    {
        // Hide all panels
        HideAllPanels();

        // Show the selected panel based on the button clicked
        if (panelIndex >= 0 && panelIndex < elementPanels.Length)
        {
            elementPanels[panelIndex].SetActive(true);
        }
    }

    // Function to hide all panels
    private void HideAllPanels()
    {
        foreach (GameObject panel in elementPanels)
        {
            panel.SetActive(false);
        }
    }
}

