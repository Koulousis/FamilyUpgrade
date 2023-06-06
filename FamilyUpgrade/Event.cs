using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.IO;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;

namespace FamilyUgrade
{
	public class Event : IExternalEventHandler
	{
		public delegate void AfterEventRaised();
		public event AfterEventRaised OnAfterEventRaised;

		public string GetName()
		{
			return "Event";
		}

		public void Execute(UIApplication app)
		{
			UIDocument uiDoc = app.ActiveUIDocument;
			Document doc = uiDoc.Document;

			switch (AddinForm.EventFlag)
			{
				case EventRaised.Event1:
					FamilyUpgrade familyUpgrade = new FamilyUpgrade(doc.Application);
					familyUpgrade.UpgradeFamilies(@"C:\path\to\source\directory", @"C:\path\to\target\directory");

					AddinForm.EventFlag = EventRaised.NoEvent;
					break;
				case EventRaised.Event2:
					TaskDialog.Show("Event2", "Event2 Raised.");
					OnAfterEventRaised?.Invoke();
					AddinForm.EventFlag = EventRaised.NoEvent;
					break;
			}
		}
	}
	
	public class FamilyUpgrade
	{
		private Application _revitApp;

		public FamilyUpgrade(Application revitApp)
		{
			_revitApp = revitApp;
		}

		public void UpgradeFamilies(string sourceDirectory, string targetDirectory)
		{
			// Get all the family files in the source directory
			string[] familyFiles = Directory.GetFiles(sourceDirectory, "*.rfa");

			foreach (string familyFile in familyFiles)
			{
				// Open the family file in a new document
				Document doc = _revitApp.OpenDocumentFile(familyFile);

				// The document is automatically upgraded to the current version of Revit

				// Save the document to a new file in the target directory
				string targetFile = Path.Combine(targetDirectory, Path.GetFileName(familyFile));
				SaveAsOptions options = new SaveAsOptions();
				options.OverwriteExistingFile = true;
				doc.SaveAs(targetFile, options);

				// Close the document
				doc.Close(false);
			}
		}
	}

}
