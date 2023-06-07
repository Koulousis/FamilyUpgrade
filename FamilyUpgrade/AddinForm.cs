using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;

namespace FamilyUpgrade
{
	public partial class AddinForm : Form
	{
		private ExternalCommandData _commandData;
		private readonly ExternalEvent _formEvent;
		private Event _revitEvent;
		public static EventRaised EventFlag = EventRaised.NoEvent;

		public AddinForm(ExternalCommandData commandData, ExternalEvent formEvent, Event revitEvent)
		{
			InitializeComponent();
			_commandData = commandData;
			_formEvent = formEvent;
			_revitEvent = revitEvent;
		}

		public void Event1()
		{
			EventFlag = EventRaised.Event1;
			_formEvent.Raise();
		}

		public void Event2()
		{
			EventFlag = EventRaised.Event2;
			_formEvent.Raise();
			_revitEvent.OnAfterEventRaised += AfterEvent2;
		}

		public void AfterEvent2()
		{
			TaskDialog.Show("AfterEvent2", "Event2 after raise.");
		}

		private void selectFamilies_Click(object sender, EventArgs e)
		{
			FamilyUpgrade.selectedFamilies.Clear();

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = @"C:\"; // you can adjust this as per your needs
				openFileDialog.Filter = "Revit Family (*.rfa)|*.rfa"; // filter files
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;
				openFileDialog.Multiselect = true; // allow multiple file selection
				
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					// Get the path of specified file
					sourceFolderTextBox.Text = Path.GetDirectoryName(openFileDialog.FileName);
					FamilyUpgrade.sourceDirectory = Path.GetDirectoryName(openFileDialog.FileName);
            
					// Get the file names
					foreach (var file in openFileDialog.FileNames)
					{
						FamilyUpgrade.selectedFamilies.Add(Path.GetFileName(file));
					}
				}
			}
		}

		private void chooseDestinationFolder_Click(object sender, EventArgs e)
		{
			using (var folderBrowserDialog = new FolderBrowserDialog())
			{
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					// Get the path of the selected folder
					destFolderTextBox.Text = folderBrowserDialog.SelectedPath;
					FamilyUpgrade.targetDirectory = folderBrowserDialog.SelectedPath;
				}
			}
		}

		private void upgradeBtn_Click(object sender, EventArgs e)
		{
			Event1();
		}
	}

	public enum EventRaised : byte
	{
		NoEvent,
		Event1,
		Event2
	}

	
}
