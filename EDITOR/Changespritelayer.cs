using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Changespritelayer : ScriptableWizard
{
    private SpriteRenderer sprite;
    public string Replace_Layer = "Default";
    public string New_Layer_Name = "Main";

    public GameObject[] OldObjects;

    [MenuItem("Custom/Change Sprite Layer")]
    static void CreateWizard()
    {
        var selectedGameObjects = ScriptableWizard.DisplayWizard<Changespritelayer>("Sprites", "Replace");
        selectedGameObjects.OldObjects = Selection.gameObjects;
    }

    void OnWizardCreate()
    {
        foreach (GameObject go in OldObjects)
        {
            sprite = go.GetComponent<SpriteRenderer>();

            if (sprite)
            {
                string oldname = sprite.sortingLayerName;
                if (oldname == Replace_Layer) sprite.sortingLayerName = New_Layer_Name;
            }
        }
    }
 
    // Use this for initialization
    void Start () {
		
	}
}
