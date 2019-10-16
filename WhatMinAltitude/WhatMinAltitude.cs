using UnityEngine;

namespace WhatMinAltitude
{
	[KSPAddon(KSPAddon.Startup.Instantly, once: true)]
	public class WhatMinAltitude : MonoBehaviour
	{
		public void Awake()
		{
			KSP.UI.Screens.DebugToolbar.Screens.Cheats.SetOrbit.safetyEnvelope = 1.0;
		}
	}
}
