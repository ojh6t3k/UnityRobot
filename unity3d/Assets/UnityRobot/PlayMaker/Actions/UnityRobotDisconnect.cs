﻿using UnityEngine;
using System;
using System.Collections;
using UnityRobot;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("UnityRobot")]
	[Tooltip("Disconnect UnityRobot")]
	public class UnityRobotDisconnect : FsmStateAction
	{
		[RequiredField]
		public UnityRobot.UnityRobot unityRobot;
		
		public override void OnEnter()
		{
			if(unityRobot != null)
				unityRobot.Disconnect();
			
			Finish();
		}
	}
}
