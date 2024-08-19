using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace Riz.UI
{
    public class Riz_UI_Menus : MonoBehaviour
    {
        [MenuItem("Riz/UI Tools/Create UI Group")]
        public static void CreateUIGroup()
        {
            GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Fader.prefab");
            if (uiGroup)
            {
                GameObject createdGroup = (GameObject)Instantiate(uiGroup);
                createdGroup.name = "Fader";
            }
            else
            {
                EditorUtility.DisplayDialog("UI Tools Warning", "Cannot Find UI Group Prefab", "OK");
            }
        }
    }
}

