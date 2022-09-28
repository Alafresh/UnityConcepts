using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
public class CreateFolders : EditorWindow
{
    private static string projectName = "PROJECT_NAME";
    [MenuItem("Assets/Create Default Folders")]
    private static void SetUpFolders()
    {
        CreateFolders window = ScriptableObject.CreateInstance<CreateFolders>();
        window.position = new Rect(Screen.width / 2, Screen.height / 2, 400, 150);
        window.ShowPopup();
    }
    private static void CreateAllFolders()
    {
        List<string> folders = new List<string>
         {
         "Art",
         "Audio",
         "Code",
         "Level",
         "ThirdParty",
         "Settings"
         };
        foreach (string folder in folders)
        {
            if (!Directory.Exists("Assets/" + folder))
            {
                Directory.CreateDirectory("Assets/" + projectName + "/" + folder);
            }
        }
        List<string> artFolders = new List<string>
         {
         "Animations",
         "Materials",
         "Textures",
         "Sprites",
         "Fonts"
         };
        foreach (string subfolder in artFolders)
        {
            if (!Directory.Exists("Assets/" + projectName + "/Art/" + subfolder))
            {
                Directory.CreateDirectory("Assets/" + projectName + "/Art/" + subfolder);
            }
        }
        List<string> audioFolders = new List<string>
         {
         "Ambx",
         "Musx",
         "Sfx"
         };
        foreach (string subfolder in audioFolders)
        {
            if (!Directory.Exists("Assets/" + projectName + "/Audio/" + subfolder))
            {
                Directory.CreateDirectory("Assets/" + projectName + "/Audio/" + subfolder);
            }
        }
        List<string> codeFolders = new List<string>
         {
         "Scripts",
         "Shaders"
         };
        foreach (string subfolder in codeFolders)
        {
            if (!Directory.Exists("Assets/" + projectName + "/Code/" + subfolder))
            {
                Directory.CreateDirectory("Assets/" + projectName + "/Code/" + subfolder);
            }
        }
        List<string> levelFolders = new List<string>
         {
         "Prefabs",
         "Scenes",
         "TileMap"
         };
        foreach (string subfolder in levelFolders)
        {
            if (!Directory.Exists("Assets/" + projectName + "/Level/" + subfolder))
            {
                Directory.CreateDirectory("Assets/" + projectName + "/Level/" + subfolder);
            }
        }
        AssetDatabase.Refresh();
    }
    void OnGUI()
    {
        EditorGUILayout.LabelField("Insert the Project name used as the root folder");
        projectName = EditorGUILayout.TextField("Project Name: ", projectName);
        this.Repaint();
        GUILayout.Space(70);
        if (GUILayout.Button("Generate!"))
        {
            CreateAllFolders();
            this.Close();
        }
    }
}