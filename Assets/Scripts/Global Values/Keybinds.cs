using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class K
{
    private static Dictionary<string, KeyCode> keybinds = new() {
        { "Forwards", KeyCode.W },
        { "Backwards", KeyCode.S },
        { "Left", KeyCode.A },
        { "Right", KeyCode.D },


    };

    private static void SetKeybind(string name, KeyCode key) {
        //todo
    } //updates key in dictionary

    public static KeyCode GetKeybind(string name) {
        if (keybinds.TryGetValue(name, out var key)) {
            return key;
        }
        else {
            throw new System.Exception($"Keybind of name {name} not found!");
        }
    }

    public static void InitKeybindsFromPlayerprefs()
    {
        //todo
    } //updates dictionary to whatever is saved
}
