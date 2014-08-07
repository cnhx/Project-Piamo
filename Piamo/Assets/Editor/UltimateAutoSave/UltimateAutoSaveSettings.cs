// Ultimate Auto Save
// 2013 by Torsten Fock-Herde
// tf@zappadong.de
// www.zappadong.de

using UnityEngine;
using System.Collections;

public class UltimateAutoSaveSettings
{
	private bool _enableSave;	
	public  bool enableSave { get; set; }

	private bool _saveScene;
	public  bool saveScene { get; set; }
	
	private bool _saveAssets;
	public  bool saveAssets { get; set; }	
	
	private bool _saveOnTime;
	public  bool saveOnTime { get; set; }
	
	private int _saveInterval;
	public  int saveInterval { get; set; }
	
	private bool _saveOnPlay;
	public  bool saveOnPlay { get; set; }
	
	private bool _saveAsCopy;
	public  bool saveAsCopy { get; set; }
	
	private string _savePath;
	public  string savePath { get; set; }
	
	private string _suffix;
	public  string suffix { get; set; }
	
	private bool _enableDebug;
	public  bool enableDebug { get; set; }
}
