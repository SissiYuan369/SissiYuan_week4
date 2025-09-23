using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FortuneTellerSimpleEN : MonoBehaviour
{
   
    public TextMeshProUGUI fortuneText;

    
    public Button getFortuneButton;

    
    public TextMeshProUGUI instructionText;

    
    string[] partA = {
        "The stars whisper that",
        "A quiet omen says",
        "Fate suggests that",
        "Soon you'll find that",
        "By moonlight it is revealed that"
    };

    string[] partB = {
        "an unexpected ally",
        "a lucky break",
        "a door you overlooked",
        "a message from far away",
        "a challenge you can handle",
        "a spark of inspiration"
    };

    string[] partC = {
        "will change your plans",
        "will guide your next step",
        "arrives when you pause",
        "asks you to be patient",
        "opens before you knock",
        "brings laughter to your day"
    };

    void Start()
    {
        
        if (getFortuneButton != null)
            getFortuneButton.onClick.AddListener(ShowFortune);

        
        if (instructionText != null)
            instructionText.text = "Press SPACE to receive your fortune.";

        
        ShowFortune();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
            ShowFortune();
    }

    void ShowFortune()
    {
        if (fortuneText == null) return; 
        string sentence = Pick(partA) + " " + Pick(partB) + " " + Pick(partC) + ".";
        fortuneText.text = sentence;
    }

    string Pick(string[] arr)
    {
        int i = Random.Range(0, arr.Length);
        return arr[i];
    }
}

