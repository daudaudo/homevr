using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public interface PhraseRecognizedHandler
{
    void handle(PhraseRecognizedEventArgs args);
}
