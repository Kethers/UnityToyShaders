using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NahidaFaceScript : MonoBehaviour
{
	public Transform HeadTrans;
	public Transform HeadFwd;
	public Transform HeadRight;
	private Material[] faceMaterials;

	private void Start()
	{
		// faceMaterials = new Material[9];
	}

	private void Update()
	{
		Vector3 fwdVec = HeadFwd.position - HeadTrans.position;
		Vector3 rightVec = HeadRight.position - HeadTrans.position;

		fwdVec = fwdVec.normalized;
		rightVec = rightVec.normalized;

		Vector4 fwdVec4 = new Vector4(fwdVec.x, fwdVec.y, fwdVec.z);
		Vector4 rightVec4 = new Vector4(rightVec.x, rightVec.y, rightVec.z);

		// for (int i = 0; i < faceMaterials.Length; i++)
		// {
		// 	Material mat = faceMaterials[i];
		// 	mat.SetVector("_ForwardVector", fwdVec4);
		// 	mat.SetVector("_RightVector", rightVec4);
		// }
	}
}