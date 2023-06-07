using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.IO;
using Autodesk.Revit.ApplicationServices;

namespace FamilyUpgrade
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
					familyUpgrade.UpgradeFamilies();

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
		public static string sourceDirectory = string.Empty;
		public static string targetDirectory = string.Empty;
		public static List<string> selectedFamilies = new List<string>();
		private TaskDialog noFamiliesDialog = new TaskDialog("Family Upgrade")
		{
			MainIcon = TaskDialogIcon.TaskDialogIconError,
			MainInstruction = "There are no selected families to upgrade",
			CommonButtons = TaskDialogCommonButtons.Ok,
			DefaultButton = TaskDialogResult.Ok
		};
		private TaskDialog noSourceDialog = new TaskDialog("Family Upgrade")
		{
			MainIcon = TaskDialogIcon.TaskDialogIconError,
			MainInstruction = "There is no source directory selected",
			CommonButtons = TaskDialogCommonButtons.Ok,
			DefaultButton = TaskDialogResult.Ok
		};
		private TaskDialog noDestinationDialog = new TaskDialog("Family Upgrade")
		{
			MainIcon = TaskDialogIcon.TaskDialogIconError,
			MainInstruction = "There is no destination directory selected",
			CommonButtons = TaskDialogCommonButtons.Ok,
			DefaultButton = TaskDialogResult.Ok
		};
		private TaskDialog upgradeDoneDialog = new TaskDialog("Family Upgrade")
		{
			MainIcon = TaskDialogIcon.TaskDialogIconInformation,
			MainInstruction = "The upgrade of selected families is ready",
			CommonButtons = TaskDialogCommonButtons.Ok,
			DefaultButton = TaskDialogResult.Ok
		};

		public FamilyUpgrade(Application revitApp)
		{
			_revitApp = revitApp;
		}

		public void UpgradeFamilies()
		{

			if (selectedFamilies.Count == 0) { noFamiliesDialog.Show(); Command.addinForm.BringToFront(); return;}
			if (sourceDirectory == string.Empty) { noSourceDialog.Show(); Command.addinForm.BringToFront(); return;}
			if (targetDirectory == string.Empty) { noDestinationDialog.Show(); Command.addinForm.BringToFront(); return;}


			// Get all the family files in the source directory
			string[] familyFiles = Directory.GetFiles(sourceDirectory, "*.rfa");

			foreach (string familyFile in selectedFamilies)
			{
				// Open the family file in a new document
				Document doc = _revitApp.OpenDocumentFile(Path.Combine(sourceDirectory, Path.GetFileName(familyFile)));

				// The document is automatically upgraded to the current version of Revit

				// Save the document to a new file in the target directory
				string targetFile = Path.Combine(targetDirectory, Path.GetFileName(familyFile));
				SaveAsOptions options = new SaveAsOptions();
				options.OverwriteExistingFile = true;
				doc.SaveAs(targetFile, options);

				// Close the document
				doc.Close(false);
			}
			
			upgradeDoneDialog.Show();
			Command.addinForm.Close();
			Process.Start(targetDirectory);
			sourceDirectory = string.Empty;
			targetDirectory = string.Empty;
			selectedFamilies.Clear();
		}
	}

}
