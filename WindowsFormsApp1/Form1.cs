using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<String> activityLog = new List<String>();
        List<VideoFile> vfiles = new List<VideoFile>();
        List<VideoFile> orderedfiles = new List<VideoFile>();

        VideoFile selectedFile;
        public Form1()
        {
            InitializeComponent();
        }
        public String activityString(String componentName,String componentAction) {
            String activity = componentName + " : " + componentAction;
            activityLog.Add(activity);
            return activity;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void preview() {
            foreach (VideoFile file in orderedfiles) {
                //Console.WriteLine(txfFilesRename.Text);
                if (!txfFilesRename.Text.Equals(""))
                {
                   file.setTempName(txfFilesRename.Text);
                }
                file.setEpisodeSuffix(chkEpisodeSuffix.Checked);
                if (file.isEdited())
                {
                    file.setNumber(file.getTempNumber());
                }
                Console.WriteLine(file.formatName());
                    //file.setName(file.getTempName());

            }
            int counter = 0;
            foreach (ListViewItem item in tblOrdered.Items) {
                //item.SubItems[0].Text = vfiles[counter].getNumber()+"";
                //item.SubItems[1].Text = vfiles[counter].getName();
                item.SubItems[0].Text = orderedfiles[counter].getTempNumber() + "";
                //Console.WriteLine(vfiles[counter].formatName());
                item.SubItems[1].Text = orderedfiles[counter].formatName();

                counter++;
            }
        }
        private void btnEditClick(object sender, EventArgs e)
        {
            //lblEpisodeNumber.Text = activityString("Button1","Clicked");
            if (tblOrdered.FocusedItem != null)
            {
                int sel = tblOrdered.FocusedItem.Index;
                selectedFile = orderedfiles[sel];
                selectedFile.setEdited();
                int tempNum = (int)nudEpisodeNumber.Value;
                selectedFile.setTempNumber(tempNum);
            }
            recompileList();
        }

        public class VideoFile {
            String name;
            String tempname;
            String extension;
            String folder;
            String tempfolder;
            String path;
            String temppath;
            bool edited;
            int number;
            int tempnumber;


            bool episodesuffix;
            bool seasonSuffix;
            public VideoFile(String file,int number) {
                //this.path = file;
                String[] str = file.Split('\\');
                String[] fileName = (str[str.Length-1]).Split('.');

                this.setName(fileName[0]);
                this.tempname = this.name;
                this.number = number;
                this.tempnumber = number;
                this.setExt(fileName[1]);

                this.setPath(file);
                this.temppath = path;

                this.setFolder(str[str.Length - 2]);
                this.tempfolder = this.folder;
            }
            //Mutator Methods
            public void setName(String name) {this.name = name;}
            public void setExt(String extension) {this.extension = extension;}
            public void setNumber(int number) {this.number = number;}
            public void setFolder(String folder) {this.folder = folder;}
            public void setPath (String path) {this.path = path; }
            public void setEdited() {this.edited = true;}

            public void setTempNumber(int number) {this.tempnumber = number;}
            public void setTempName(String name) { this.tempname = name; }
            public void setTempFolder(String folder) { this.tempfolder = folder; }
            public void setTempPath(String path) {this.temppath = path;}

            public void setEpisodeSuffix(bool input) { this.episodesuffix = input; }
            public void setSeasonSuffix(bool input) { this.seasonSuffix = input; }
            public String formatName() {
                String finalstr = "";
                string suffix = "";
                if (this.episodesuffix)
                    suffix += " - Episode";
                finalstr = this.tempname + suffix + " " +this.tempnumber;
                return (finalstr);
            }

            //Accessor Methods
            
            //String name
            public String getName() {return this.name;}
            //String extension;
            public String getExt() {return this.extension;}
            //int number;
            public int getNumber() {return this.number;}
            //String folder;
            public String getFolder() { return this.folder; }
            //String path;
            public String getPath() { return this.path; }
            //bool edited;
            public bool isEdited() {return this.edited;}

            //int tempnumber;
            public int getTempNumber(){return this.tempnumber;}
            //String tempname;
            public String getTempName() { return this.tempname; }
            //String tempfolder;
            public String getTempFolder() { return this.tempfolder; }
            //String temppath;
            public String getTempPath() { return this.temppath; }
            //bool episodesuffix;
            public bool hasEpisodeSuffix() { return this.episodesuffix; }
            //bool seasonSuffix;
            public bool hasSeasonSuffix(){ return this.seasonSuffix;}

        }
        private void btnOpenFolderClick(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    String[] files = Directory.GetFiles(fbd.SelectedPath);
                    tblFiles.Columns.Add("Episode", 50);
                    tblFiles.Columns.Add("Name", 400);

                    tblOrdered.Columns.Add("Temp Episode", 50);
                    tblOrdered.Columns.Add("Temp Name", 400);
                    int count = 1;
                    foreach(String s in files) {
                        vfiles.Add(new VideoFile(s,count));
                        count++;
                    }
                    foreach (VideoFile file in vfiles)
                    {
                        addListItem(false,createNewListViewItem(false,file));
                        count++;
                    }
                    //System.Windows.Forms.MessageBox.Show(allFileNames,"Message");
                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }
        public void addListItem(bool ordered,ListViewItem item) {
            if(ordered)
                tblOrdered.Items.Add(item);
            else
                tblFiles.Items.Add(item);
        }
        public ListViewItem createNewListViewItem(bool ordered,VideoFile file) {
            string episode;
            string name;
            if (!ordered)
            {
                episode = file.getNumber() + "";
                name = file.getName();
            }
            else
            {
                episode = file.getTempNumber() + "";
                name = file.formatName();
            }
            return new ListViewItem(new[] { episode, name});
        }
        public void swapListItems(int a,int  b)
        {
            //VideoFile temp = new VideoFile("dud\dud.dud", vfiles.Count+1);
            VideoFile temp = vfiles[a];
            vfiles[a] = vfiles[b];
            vfiles[b] = temp;
        }
        public void recompileList() {
            //tblFiles.DataSource = null;
            tblFiles.Items.Clear();
            tblOrdered.Items.Clear();
            //tblFiles.Clear();
            foreach (VideoFile file in vfiles)
            {
                addListItem(false,createNewListViewItem(false,file));
            }
            foreach (VideoFile file in orderedfiles)
            {
                addListItem(true, createNewListViewItem(true,file));
            }
            //vfiles.Sort();
        }

        private void tblFilesSelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = tblFiles.FocusedItem.Index;
            selectedFile = vfiles[sel];
            lblEpisodeNumber.Text = selectedFile.getName();
            nudEpisodeNumber.Value = selectedFile.getNumber();
            if (!txfFilesRename.Text.Equals(""))
            {
                selectedFile.setTempName(txfFilesRename.Text);
            }
            
        }

        private void btnPreviewClick(object sender, EventArgs e)
        {
            preview();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddFileClick1(object sender, EventArgs e)
        {

        }

        private void BtnShiftLeft_Click(object sender, EventArgs e)
        {
            if (tblOrdered.FocusedItem != null)
            {
                int sel = tblOrdered.FocusedItem.Index;
                selectedFile = orderedfiles[sel];
                selectedFile.setNumber(vfiles.Count + 1);
                vfiles.Add(selectedFile);
                orderedfiles.Remove(selectedFile);
                //tblFiles.FocusedItem.Remove();
                recompileList();

                //tblOrdered.Focus = tblOrdered.Items.Count;
            }
        }

        private void BtnShiftRight_Click(object sender, EventArgs e)
        {
            if (tblFiles.FocusedItem != null) {
                int sel = tblFiles.FocusedItem.Index;
                selectedFile = vfiles[sel];
                selectedFile.setTempNumber(orderedfiles.Count + 1);
                orderedfiles.Add(selectedFile);
                vfiles.Remove(selectedFile);
                //tblFiles.FocusedItem.Remove();
                recompileList();
                
                //tblOrdered.Focus = tblOrdered.Items.Count;
            }
        }

        private void TblOrdered_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = tblOrdered.FocusedItem.Index;
            selectedFile = orderedfiles[sel];
            lblEpisodeNumber.Text = selectedFile.getTempName();
            nudEpisodeNumber.Value = selectedFile.getTempNumber();
            if (!txfFilesRename.Text.Equals(""))
            {
                selectedFile.setTempName(txfFilesRename.Text);
            }
        }
    }
}
