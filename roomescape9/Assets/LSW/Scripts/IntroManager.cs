using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class IntroManager : MonoBehaviour
{
    public static IntroManager Instance { get; private set; }

    public Text startText;
    public Text optionText;
    public Text exitText;

    public Color highlightColor = Color.yellow;
    public Color startHighlightColor = Color.black;

    private Color startOriginalColor;
    private Color optionOriginalColor;
    private Color exitOriginalColor;

    public Poster poster;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        startOriginalColor = startText.color;
        optionOriginalColor = optionText.color;
        exitOriginalColor = exitText.color;

        startText.GetComponent<Button>().onClick.AddListener(OpenStartUI);
        optionText.GetComponent<Button>().onClick.AddListener(OpenOptionUI);
        exitText.GetComponent<Button>().onClick.AddListener(OpenExitUI);
    }

    public void HighlightText(Text text)
    {
        if (text == startText)
            text.color = startHighlightColor;
        else
            text.color = highlightColor;
    }

    public void ResetTextColor(Text text)
    {
        if (text == startText)
            text.color = startOriginalColor;
        else if (text == optionText)
            text.color = optionOriginalColor;
        else if (text == exitText)
            text.color = exitOriginalColor;
    }

    public void OpenStartUI()
    {
        poster.OnPoster();
    }

    public void OpenOptionUI()
    {
        Debug.Log("Option UI opened");
    }

    public void OpenExitUI()
    {
        Debug.Log("Exit UI opened");
    }
}
