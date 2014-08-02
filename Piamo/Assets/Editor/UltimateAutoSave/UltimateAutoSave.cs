// Ultimate Auto Save
// 2013 by Torsten Fock-Herde
// tf@zappadong.de
// www.zappadong.de

using UnityEditor;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[InitializeOnLoad]
public class UltimateAutoSave : EditorWindow
{
	static bool enableSave = false;
	static bool saveScene = true;
	static bool saveAssets = true;
	
	static bool saveOnTime = true;
	static int saveInterval;
	static float nextSave;
	
	static bool saveOnPlay = true;
	
	static bool saveAsCopy = false;
	static string savePath;
	static string suffix;
	static bool enableDebug = true;
	
	static UltimateAutoSaveSettings settings;
	
	static string xmlPath;
	
	// setup
    static UltimateAutoSave()
    {
		settings = new UltimateAutoSaveSettings();
		
		// check if xml file is there and get the path to it
		string[] xmlPaths = Directory.GetFiles(Application.dataPath + "/Editor", "UltimateAutoSaveSettings.xml", SearchOption.AllDirectories);
		if(xmlPaths.Length > 0)
		{
			xmlPath = xmlPaths[0];
			xmlPath = xmlPath.Replace(@"\","/");
			
			LoadSettings(xmlPath);
		}
		else
		{
			enableSave 		= true;
			saveScene 		= true;
			saveAssets 		= true;
			saveOnTime 		= true;
			saveInterval 	= 1;
			saveOnPlay 		= true;	
			saveAsCopy 		= false;		
			savePath 		= Application.dataPath;	
			suffix 			= "_bak";
			enableDebug 	= true;
			xmlPaths = Directory.GetFiles(Application.dataPath + "/Editor", "UltimateAutoSaveSettings.cs", SearchOption.AllDirectories);
			if(xmlPaths.Length > 0)
			{
				xmlPath = xmlPaths[0];
				xmlPath = xmlPath.Replace(@"\","/");
				int index = xmlPath.LastIndexOf("/");
				xmlPath = xmlPath.Substring(0, index+1); 
				xmlPath = xmlPath + "UltimateAutoSaveSettings.xml";
				UpdateSettings();
				WriteSettings(xmlPath);
			}
		}

        EditorApplication.update += Update;
		EditorApplication.playmodeStateChanged += PlayModeStateChanged;
		DebugLog("UltimateAutoSave Ready");
    }
	
	// Add menu item to the Window menu
	[MenuItem("Edit/Project Settings/Ultimate Auto Save")]
	public static void ShowWindow()
	{
		//Show existing window instance. If one doesn't exist, make one.
		EditorWindow.GetWindow(typeof(UltimateAutoSave));
	}
	
	static void LoadSettings(string path)
	{
		settings = LoadXml<UltimateAutoSaveSettings>(path);		
		enableSave 		= settings.enableSave;
		saveScene 		= settings.saveScene;
		saveAssets 		= settings.saveAssets;
		saveOnTime 		= settings.saveOnTime;
		saveInterval 	= settings.saveInterval;
		saveOnPlay 		= settings.saveOnPlay;	
		saveAsCopy 		= settings.saveAsCopy;		
		savePath 		= settings.savePath;	
		suffix 			= settings.suffix;
		enableDebug 	= settings.enableDebug;			
	}
	
	static void WriteSettings(string path)
	{			
		DebugLog("Save UltimateAutoSave Settings to " + path);
		SaveXml<UltimateAutoSaveSettings>(path, settings);
	}
	
	static void UpdateSettings()
	{
		settings.enableSave 	= enableSave;
		settings.saveScene 		= saveScene;
		settings.saveAssets 	= saveAssets;
		settings.saveOnTime 	= saveOnTime;
		settings.saveInterval 	= saveInterval;
		settings.saveOnPlay 	= saveOnPlay;	
		settings.saveAsCopy 	= saveAsCopy;		
		settings.savePath 		= savePath;	
		settings.suffix 		= suffix;
		settings.enableDebug 	= enableDebug;		
	}
	
	public static void SaveXml<T>(string filename, T value)
	{
		XmlSerializer ser = new XmlSerializer(typeof(T));
		//using (FileStream stream = File.OpenWrite(filename))
		using (FileStream stream =  new FileStream(filename, FileMode.Create))
		{
			ser.Serialize(stream, value);
		}
	}

	public static T LoadXml<T>(string filename)
	{
		XmlSerializer ser = new XmlSerializer(typeof(T));
		using (FileStream stream = File.OpenRead(filename))
		{
			return (T)ser.Deserialize(stream);
		}
	}

	static void DebugLog(string log)
	{
		if(enableDebug == true)
			Debug.Log(log);
	}
	
	static void Save()
	{
		if(Application.isPlaying)return;
		
		if(enableSave == false)return;
		
		string savePathAndFilename; 
		
		if(saveAsCopy == true)
		{
			// add suffix to filename
			savePathAndFilename = savePath + "/" + Path.GetFileNameWithoutExtension(EditorApplication.currentScene);
			savePathAndFilename = savePathAndFilename + suffix + ".unity";
		}
		else
		{
			//savePathAndFilename = savePath + "/" + Path.GetFileName(EditorApplication.currentScene);
			savePathAndFilename = EditorApplication.currentScene;
		}

		DebugLog(savePathAndFilename);
		
		if(saveScene == true)
		{
			EditorApplication.SaveScene(savePathAndFilename, saveAsCopy);
			DebugLog("Scene Auto Saved");			
		}
		
		if(saveAssets == true)
		{
			EditorApplication.SaveAssets();
			DebugLog("Assets Auto Saved");			
		}
	}
	
	static void PlayModeStateChanged()
	{
		// Save On Play
		if(saveOnPlay == true)
		{
			if(EditorApplication.isPlayingOrWillChangePlaymode == true)
			{
				Save();
			}
		}
	}
	
    static void Update()
    {
		// Save On Time
		if(EditorApplication.timeSinceStartup > nextSave)
		{
			nextSave = (float)EditorApplication.timeSinceStartup+saveInterval*60;	
			if(saveOnTime == true)Save();	
		}			
    }

	void OnGUI()
	{		
		GUILayout.Label ("Base Settings", EditorStyles.boldLabel);
		//enableSave = EditorGUILayout.BeginToggleGroup ("Enable Auto Save",      enableSave);
		enableSave = EditorGUILayout.BeginToggleGroup (new GUIContent("Enable Auto Save", "Enable or Disable the entire auto save"),      enableSave);
		 
		saveScene  = EditorGUILayout.Toggle (new GUIContent("Save Scene", "Save your scene with every auto save"),            saveScene);
		saveAssets = EditorGUILayout.Toggle (new GUIContent("Save Assets", "Save every unsaved asset with every auto save"), saveAssets);
		EditorGUILayout.Space();
		
		GUILayout.Label ("Save Settings", EditorStyles.boldLabel);
		saveOnTime = EditorGUILayout.BeginToggleGroup (new GUIContent("Save On Time", "Save at regular, predefined intervals"), saveOnTime);
			saveInterval = EditorGUILayout.IntSlider ("Save Interval In Minutes", saveInterval, 1, 30);
		EditorGUILayout.EndToggleGroup ();
	
		saveOnPlay   = EditorGUILayout.BeginToggleGroup (new GUIContent("Save On Play", "Save everytime when you hit \"Play\""),  saveOnPlay);	
		EditorGUILayout.EndToggleGroup ();
		EditorGUILayout.Space();
		
		GUILayout.Label ("Advanced Settings", EditorStyles.boldLabel);	
		saveAsCopy 	  = EditorGUILayout.BeginToggleGroup (new GUIContent("Save Scene As Copy", "Save the scene as copy, at a predefined path, with a predefined suffix"),  saveAsCopy);
		//savePath = EditorGUILayout.TextField (new GUIContent("Local Save Path", "Click at \"Set Save Path\" to choose a path"), savePath);
		EditorGUILayout.LabelField("Local Save Path", savePath);
		
		if (GUILayout.Button(new GUIContent("Set Save Path", "Click to choose a path")))
		{
			string folderPath = EditorUtility.OpenFolderPanel("Choose Local Save Path", Application.dataPath, "");
			if(folderPath != "")
			{
				if(folderPath.Contains(Application.dataPath))
				{
					string s = folderPath.Substring(folderPath.LastIndexOf("Assets"));
					savePath = s;
				}
				else
				{
					EditorUtility.DisplayDialog("Please choose the project asset folder or one of its subfolders!", "", "Ok", "");
					savePath = Application.dataPath;
				}
			}
			else
			{
				savePath = Application.dataPath;
			}
		}	
		suffix = EditorGUILayout.TextField (new GUIContent("Suffix", "The suffex will be appended to your scene filename for backup purposes") , suffix);
		EditorGUILayout.EndToggleGroup ();
		enableDebug = EditorGUILayout.BeginToggleGroup(new GUIContent("Logging", "Enable Ultimate Auto Save to log info into the console"),  enableDebug);	
		EditorGUILayout.EndToggleGroup ();
		EditorGUILayout.EndToggleGroup ();
		EditorGUILayout.Space();
		// Save Settings Button
		if(GUILayout.Button(new GUIContent("Save Ultimate Auto Save Settings", "Save all settings to a xml file located in your UltimateAutoSave folder")))
		{
			UpdateSettings();
			WriteSettings(xmlPath);
		}
	}
}