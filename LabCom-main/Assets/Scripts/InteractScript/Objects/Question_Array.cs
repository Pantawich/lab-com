using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class JavaQuizManager : MonoBehaviour
{
    [Header("UI References")]
    public TMP_Text codeDisplay;
    public TMP_InputField userInput;
    public TMP_Text progressText;
    public GameObject successScreen;
    public Slider progressBar;

    [Header("Puzzle Data")]
    public string[] codeSnippets;      // Array of code text
    public string[] correctAnswers;    // Array of correct words/syntax
    
    private int currentIndex = 0;

    void Start()
    {
        UpdateUI();
    }

    public void CheckAnswer()
    {
        if (userInput.text.Trim() == correctAnswers[currentIndex])
        {
            NextQuestion();
        }
        else
        {
            userInput.text = ""; 
            Debug.Log("Wrong syntax!");
            ScreenShake.ShakeScreen(0.2f, 0.3f);
        }
    }

    void NextQuestion()
    {
        currentIndex++;
        userInput.text = "";

        if (currentIndex < codeSnippets.Length)
        {
            UpdateUI();
        }
        else
        {
            ShowVictory();
        }
    }

    void UpdateUI()
    {
        if (codeSnippets.Length > 0 && currentIndex < codeSnippets.Length)
        {
            codeDisplay.text = codeSnippets[currentIndex];
            progressText.text = $"Question: {currentIndex + 1} / {codeSnippets.Length}";
            progressBar.value = (float)currentIndex / codeSnippets.Length;
        }
        userInput.ActivateInputField();
    }

    void ShowVictory()
    {
        progressBar.value = 1f;
        successScreen.SetActive(true);
    }
}