﻿using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class PPSerialization {

	public static BinaryFormatter binaryFormatter = new BinaryFormatter ();

	public static void save(string key, object obj) {
		MemoryStream memoryStream = new MemoryStream ();
		binaryFormatter.Serialize (memoryStream, obj);
		string temp = System.Convert.ToBase64String (memoryStream.ToArray ());
		PlayerPrefs.SetString (key, temp);
	}

	public static object load(string key) {
		string temp = PlayerPrefs.GetString (key);
		if (temp == string.Empty) {
			return null;
		}
		MemoryStream memoryStream = new MemoryStream (System.Convert.FromBase64String(temp));
		return binaryFormatter.Deserialize(memoryStream);
	}
}
