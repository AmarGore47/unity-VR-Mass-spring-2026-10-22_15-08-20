using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WelcomeManager : MonoBehaviour
{
    [Header("UI References")]
    public TMP_InputField nameInputField; // Jo input field banaya
    public TextMeshProUGUI welcomeMessageText; // "Welcome ___ Simulation" text
    public GameObject welcomePanel; // Pura welcome card jise hide karna hai

    // Jab player Start button dabaye
    public void OnStartSimulationClicked()
    {
        string playerName = nameInputField.text;

        if (string.IsNullOrEmpty(playerName))
        {
            playerName = "Student"; // Default naam agar khali chhod diya
        }

        // Welcome text update karo
        welcomeMessageText.text = "Welcome " + playerName + " to Physics VR Lab!";

        // Welcome panel ko hata do taaki lab saaf dikhe
        if (welcomePanel != null)
        {
            welcomePanel.SetActive(false);
        }
    }
}