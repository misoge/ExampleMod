// Copyright 2024. Misoge. All Rights Reserved.
// ####### Your copyright here #######

#nullable enable

using HarmonyLib;
using ModContainer;

namespace ExampleMod
{
    public class ExampleMod : Mod
    {
        public override int LoadOrder => -1;

        public ExampleMod()
        {
            Metadata = Metadata with
            {
                ModeType = ModeType.None,
                PackageId = "com.example.mod",
                Name = "Example Mod",
                Description = "An example mod for ModContainer.",
                Author = "Your Name",
                Version = "1.0.0",
                Tags = new[] { "example", "mod" },
                Dependencies = new string[] { },
                OptionalDependencies = new string[] { }
            };

            var harmony = new Harmony(Metadata.PackageId);
            harmony.PatchAll();
        }
    }
}