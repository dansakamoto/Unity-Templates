/*==============================================================================
Drop this on a Vuforia image target object to run some code when it's detected.
This is basically the example code from here, minus the audio playback:
https://developer.vuforia.com/forum/faq/unity-how-can-i-play-audio-when-targets-get-detected
==============================================================================*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class RunCodeOnImageTargetDetect : MonoBehaviour, ITrackableEventHandler
{
	private TrackableBehaviour mTrackableBehaviour;

	void Start()
	{
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{

			//
			// DO SOMETHING WHEN TARGET IS DETECTED
			//

		}
		else
		{
			//
			// DO SOMETHING ELSE WHEN TARGET IS LOST
			//
		}
	}   
}