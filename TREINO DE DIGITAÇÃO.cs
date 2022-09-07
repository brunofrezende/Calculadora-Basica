using System;
using System.Collection.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using BaseX;
using FrooxEngine;
using HarmonyLib;
using UnityEngine;
using UnityEngine;
using UnityNeos;
using Component = FrooxEngine.Component;
using MeshRenderer = FrooxEngine.MeshRenderer;
using SkinnedMeshRenderer = FrooxEngine.SkinnedMeshRenderer;

namespace Thundaga 
{
    [HarmonyPatch(typeof(ComponentBase<Component>))]
    public static class ComponentBasePatch
    {
        [HarmonyPatch()]
    }
}