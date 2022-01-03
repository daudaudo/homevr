using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class StartScenePhraseRecognizedHandler : MonoBehaviour, PhraseRecognizedHandler
{
    public void handle(PhraseRecognizedEventArgs args)
    {
        switch(args.text)
        {
            default:
                Debug.Log(args.text);
                break;
        }
    }
}
