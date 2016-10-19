/*
*	This Script is an test script to specific Scenes to build
*/

using UnityEngine;
using System.Collections;
using UnityEditor;

class AddScene
{
	static void PerformBuild ()
	{
		string[] scenes = { "Assets/MainScene.unity" };
		//AssetDatabase.Refresh ();
		//BuildPipeline.BuildPlayer(scenes);
	}
}
