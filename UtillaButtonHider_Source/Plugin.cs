using System;
using BepInEx;
using UnityEngine;
using Utilla;

namespace UtillaButtonHider
{
	/// <summary>
	/// This is your mod's main class.
	/// </summary>

	/* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
	[ModdedGamemode]
	[BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{
		public static bool inRoom;
		public static GameObject Object;

		void OnEnable() {
			Utilla.Events.GameInitialized += OnGameInitialized;
			Object = GameObject.Find("Level/forest/lower level/UI/Selector Buttons/anchor/");
			Object.transform.GetChild(3).gameObject.GetComponent<MeshRenderer>().enabled = false; // button
			Object.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.SetActive(false); // arrow for that same button
			Object.transform.GetChild(4).gameObject.GetComponent<MeshRenderer>().enabled = false; // button
			Object.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.SetActive(false); // arrow for that same button
		}

		void OnDisable() {
			Utilla.Events.GameInitialized -= OnGameInitialized;
			Object = GameObject.Find("Level/forest/lower level/UI/Selector Buttons/anchor/");
			Object.transform.GetChild(3).gameObject.GetComponent<MeshRenderer>().enabled = true; // button
			Object.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.SetActive(true); // arrow for that same button
			Object.transform.GetChild(4).gameObject.GetComponent<MeshRenderer>().enabled = true; // button
			Object.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.SetActive(true); // arrow for that same button
		}

		void OnGameInitialized(object sender, EventArgs e)
		{
			Object = GameObject.Find("Level/forest/lower level/UI/Selector Buttons/anchor/");
			Object.transform.GetChild(3).gameObject.GetComponent<MeshRenderer>().enabled = false; // button
			Object.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.SetActive(false); // arrow for that same button
			Object.transform.GetChild(4).gameObject.GetComponent<MeshRenderer>().enabled = false; // button
			Object.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.SetActive(false); // arrow for that same button
		}
	}
}
