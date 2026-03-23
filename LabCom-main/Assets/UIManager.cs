using UnityEngine;

public class UIManager : MonoBehaviour
{
    
    public GameObject emailPanel;
    public GameObject terminalPanel;

    void Start()
    {
        emailPanel.SetActive(false);
        terminalPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            emailPanel.SetActive(true);
        }
    }

    public void OnClickNext()
    {
        emailPanel.SetActive(false);
        terminalPanel.SetActive(true);
    }
}