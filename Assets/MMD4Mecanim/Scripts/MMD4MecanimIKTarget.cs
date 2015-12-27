// - Don't upload model data, motion data, this code in github or public space without permission.
// - Don't modify this code without permission.
using UnityEngine;
using System.Collections;

public class MMD4MecanimIKTarget : MonoBehaviour
{
	public MMD4MecanimModel	model;
	public bool				ikEnabled = true;
	public float			ikWeight = 1.0f;

	Transform _transform;
	public Matrix4x4 localToWorldMatrix
	{
		get {
			if( _transform == null ) {
				_transform = this.transform; // Performance Efficient: Cache reference to transform.
			}

			return _transform.localToWorldMatrix;
		}
	}
}
