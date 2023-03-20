using System.Collections.Generic;
using UnityEngine;

public class DemoKeyboard : MonoBehaviour
{
    private UnityEngine.UI.Button[] _buttons;

    private void OnEnable()
    {
        _buttons = GetComponentsInChildren<UnityEngine.UI.Button>();
    }

    private void OnDisable()
    {
        foreach (var btn in _buttons)
        {

        }
    }

    public void NoteOn(int noteNumber)
    {
        MySynth.noteOn(noteNumber, 1.0f);
    }

    public void NoteOff(int noteNumber)
    {
        MySynth.noteOff(noteNumber);
    }
}
