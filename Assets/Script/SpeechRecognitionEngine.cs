using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

/// <summary>
/// see here https://lightbuzz.com/speech-recognition-unity/
/// </summary>
public class SpeechRecognitionEngine : MonoBehaviour
{
    public string[] keywords;
    public ConfidenceLevel confidence = ConfidenceLevel.Rejected;
    protected PhraseRecognizer recognizer;

    public PhraseRecognizedHandler phraseRecognizedHandler;

    private void Start()
    {
        phraseRecognizedHandler = GetComponent<PhraseRecognizedHandler>();
        Debug.Log(phraseRecognizedHandler.ToString());
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
            Debug.Log( recognizer.IsRunning );
        }

        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
    }

    void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        if(phraseRecognizedHandler != null)
        {
            phraseRecognizedHandler.handle(args);
        }
    }

    private void Update()
    {

    }

    void OnDestroy()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}