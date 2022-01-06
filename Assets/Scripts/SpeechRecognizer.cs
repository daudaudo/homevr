using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static SpeechRecognizerPlugin;

public class SpeechRecognizer : MonoBehaviour, ISpeechRecognizerPlugin
{
    StartScenePhraseRecognizedHandler script;

    private SpeechRecognizerPlugin plugin = null;

    private void Start()
    {
        script = this.gameObject.GetComponent<StartScenePhraseRecognizedHandler>();
        plugin = SpeechRecognizerPlugin.GetPlatformPluginVersion(this.gameObject.name);
        plugin.SetLanguageForNextRecognition("en-US");
        plugin.SetContinuousListening(true);
        plugin.SetMaxResultsForNextRecognition(5);
        plugin.StartListening();
    }

    private void StartListening()
    {
        plugin.StartListening();
    }

    public void OnResult(string recognizedResult)
    {
        char[] delimiterChars = { '~' };
        string[] result = recognizedResult.Split(delimiterChars);
        script.handle(result, result.Length);
    }

    public void OnError(string recognizedError)
    {
        ERROR error = (ERROR)int.Parse(recognizedError);
        switch (error)
        {
            case ERROR.UNKNOWN:
                Debug.Log("<b>ERROR: </b> Unknown");
                break;
            case ERROR.INVALID_LANGUAGE_FORMAT:
                Debug.Log("<b>ERROR: </b> Language format is not valid");
                break;
            default:
                break;
        }
    }
}
