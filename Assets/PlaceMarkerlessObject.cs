using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Kudan.AR{

	public class PlaceMarkerlessObject : MonoBehaviour {

		public KudanTracker _kudantracker;

		public void PlaceClick() {
			Vector3 position;
			Quaternion orientation;

			_kudantracker.FloorPlaceGetPose(out position, out orientation);
			_kudantracker.ArbiTrackStart(position, orientation);
		}
	}

}
