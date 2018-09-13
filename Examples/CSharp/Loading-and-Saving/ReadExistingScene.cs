﻿using System;
using System.IO;
using System.Collections;
using Aspose.ThreeD;

namespace Aspose._3D.Examples.CSharp.Loading_Saving
{
    class ReadExistingScene
    {
        public static void Run()
        {
            // ExStart:ReadExistingScene
            // The path to the documents directory.
            string MyDir = RunExamples.GetDataDir();

            // Initialize a Scene class object
            Scene scene = new Scene();
            // Load an existing 3D document
            scene.Open(MyDir + "document.fbx");

            // ExEnd:ReadExistingScene
            Console.WriteLine("\n3D Scene is ready for the modification, addition or processing purposes.");
        }
    }
}
