using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class ScriptableObjectsMenu : MonoBehaviour
{
    [MenuItem("Scriptable Objects/Create/Card")]
    private static void CreateNewCard()
    {
        // Create a new instance of CardData
        CardData card = ScriptableObject.CreateInstance<CardData>();

        // Ensure the Cards directory exists
        string directoryPath = Application.dataPath + "/Cards";
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Generate a unique filename for the card
        string cardName = "Card_" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".asset";
        string assetPath = Path.Combine("Assets/Cards", cardName);

        // Create the asset
        AssetDatabase.CreateAsset(card, assetPath);

        // Refresh the AssetDatabase to make sure the new asset is visible in the editor
        AssetDatabase.Refresh();

        // Optionally, select the newly created asset in the Project window
        Selection.activeObject = card;
    }
}
