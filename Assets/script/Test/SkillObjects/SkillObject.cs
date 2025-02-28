﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkillType
{
    Apple,
    Banana,
    Bomb,
}

[CreateAssetMenu(fileName = "new skill object", menuName = "Skill")]
public class SkillObject : ScriptableObject
{
    public int id;
    public string SkillName;
    public SkillType type;
    public Sprite sprite;

    public int amount;
    public float coolDown;

    [TextArea(10, 15)]
    public string description;
}
