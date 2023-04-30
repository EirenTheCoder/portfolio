using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Gatito))]
public class GatitoEditor : Editor
{
    public override void OnInspectorGUI()
    {

        Color col;
        /*  base.OnInspectorGUI();
          EditorGUILayout.HelpBox("Hey there!°-°",MessageType.Warning);
          EditorGUILayout.HelpBox("Hey there!°-°", MessageType.Info);


          EditorGUILayout.HelpBox("Hey there!°-°", MessageType.None);

          EditorGUILayout.HelpBox("Hey there!°-°", MessageType.Error);*/
      //Para conectar con el Gatito
        Gatito gatito = target as Gatito;
      //gatito.experience =  EditorGUILayout.IntField("Experience", gatito.experience);
        gatito.experience = EditorGUILayout.IntSlider("Experience :", gatito.experience,0,1000);
      EditorGUILayout.LabelField("TEST", gatito.experience.ToString());
    
        EditorGUILayout.Space();
    

    if(gatito.experience>5)  EditorGUILayout.HelpBox("Ya es muy alto! °-°", MessageType.Info);

        col =   EditorGUILayout.ColorField("Color",Color.white);



    }

}
