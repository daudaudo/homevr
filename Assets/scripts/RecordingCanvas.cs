using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using KKSpeech;

public class RecordingCanvas : MonoBehaviour
{
  StartScenePhraseRecognizedHandler script;
  void Start()
  {
    script = this.gameObject.GetComponent<StartScenePhraseRecognizedHandler>();
    if (SpeechRecognizer.ExistsOnDevice())
    {
      SpeechRecognizerListener listener = GameObject.FindObjectOfType<SpeechRecognizerListener>();
      listener.onFinalResults.AddListener(OnFinalResult);
      listener.onPartialResults.AddListener(OnPartialResult);
      SpeechRecognizer.RequestAccess();
      SpeechRecognizer.StartRecording(true);
    }
  }

  public void OnFinalResult(string result)
  {
    script.handle(result);
    SpeechRecognizer.StartRecording(true);
  }

  public void OnPartialResult(string result)
  {
    script.handle(result);
    SpeechRecognizer.StartRecording(true);
  }

  void FixedUpdate(){
    SpeechRecognizer.StartRecording(true);
  }
}
