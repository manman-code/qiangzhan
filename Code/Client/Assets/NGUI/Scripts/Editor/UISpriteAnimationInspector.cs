﻿//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2014 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;
using UnityEditor;

/// <summary>
/// Inspector class used to edit UISpriteAnimations.
/// </summary>

[CustomEditor(typeof(UISpriteAnimation))]
public class UISpriteAnimationInspector : Editor
{
	/// <summary>
	/// Draw the inspector widget.
	/// </summary>

	public override void OnInspectorGUI ()
	{
		NGUIEditorTools.DrawSeparator();
		NGUIEditorTools.SetLabelWidth(80f);
		UISpriteAnimation anim = target as UISpriteAnimation;

		int fps = EditorGUILayout.IntField("Framerate", anim.framesPerSecond);
		fps = Mathf.Clamp(fps, 0, 60);

		if (anim.framesPerSecond != fps)
		{
			NGUIEditorTools.RegisterUndo("Sprite Animation Change", anim);
			anim.framesPerSecond = fps;
			EditorUtility.SetDirty(anim);
		}

		string namePrefix = EditorGUILayout.TextField("Name Prefix", (anim.namePrefix != null) ? anim.namePrefix : "");

		if (anim.namePrefix != namePrefix)
		{
			NGUIEditorTools.RegisterUndo("Sprite Animation Change", anim);
			anim.namePrefix = namePrefix;
			EditorUtility.SetDirty(anim);
		}

		bool loop = EditorGUILayout.Toggle("Loop", anim.loop);

		if (anim.loop != loop)
		{
			NGUIEditorTools.RegisterUndo("Sprite Animation Change", anim);
			anim.loop = loop;
			EditorUtility.SetDirty(anim);
		}

        bool PixelPerfect = EditorGUILayout.Toggle("PixelPerfect", anim.PixelPerfect);

        if (anim.PixelPerfect != PixelPerfect)
        {
            NGUIEditorTools.RegisterUndo("Sprite PixelPerfect", anim);
            anim.PixelPerfect = PixelPerfect;
            EditorUtility.SetDirty(anim);
        }

        float Interval = EditorGUILayout.FloatField("Interval", anim.Interval);
        if (anim.Interval != Interval)
        {
            NGUIEditorTools.RegisterUndo("Sprite Animation Change", anim);
            anim.Interval = Interval;
            EditorUtility.SetDirty(anim);
        }
	}
}