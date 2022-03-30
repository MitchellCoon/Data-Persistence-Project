using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TMP_InputField currentNameText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "High Score: " + HighScoreManager.Instance.Name + ": " + HighScoreManager.Instance.HighScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void UpdateCurrentName()
    {
        HighScoreManager.Instance.UpdateCurrentName(currentNameText.text);
    }
}
