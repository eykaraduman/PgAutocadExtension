using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using AcAp = Autodesk.AutoCAD.ApplicationServices.Application;

namespace PgAcadToolsAddin
{
    public class Initialization : IExtensionApplication
    {
        public void Initialize()
        {
            AcAp.Idle += OnIdle;
        }

        private void OnIdle(object sender, EventArgs e)
        {
            var doc = AcAp.DocumentManager.MdiActiveDocument;
            if (doc != null)
            {
                AcAp.Idle -= OnIdle;
#if ACAD2012
                doc.Editor.WriteMessage("\nPgAcadTools.AutoCAD.2012 loaded.");
#elif ACAD2013
                doc.Editor.WriteMessage("\nPgAcadTools.AutoCAD.2013 loaded.");
#elif ACAD2014
                doc.Editor.WriteMessage("\nPgAcadTools.AutoCAD.2014 loaded.");
#elif ACAD2015
                doc.Editor.WriteMessage("\nPgAcadTools.AutoCAD.2015 loaded.");
#elif ACAD2016
                doc.Editor.WriteMessage("\nPgAcadTools.AutoCAD.2016 loaded.");
#elif ACAD2017
                doc.Editor.WriteMessage("\nPgAcadTools.AutoCAD.2017 loaded.");
#endif
            }
        }

        public void Terminate()
        { }
    }
}
