using System;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace SampleCommand
{
    [TransactionAttribute(TransactionMode.ReadOnly)]
    public class Sample : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                TaskDialog.Show("Title1", "Test");
                return Result.Succeeded;
            }
            catch (Exception e)
            {
                return Result.Failed;
            }
        }
    }
}