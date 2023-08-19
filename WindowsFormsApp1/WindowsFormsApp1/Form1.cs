using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> forbiddenProcesses = new List<string>();
        private const string blacklistFilePath = "blacklist.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBlacklist();
            UpdateListView();
        }

        private void LoadBlacklist()
        {
            try
            {
                if (File.Exists(blacklistFilePath))
                {
                    string json = File.ReadAllText(blacklistFilePath);
                    forbiddenProcesses = JsonConvert.DeserializeObject<List<string>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке черного списка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBlacklist()
        {
            try
            {
                string json = JsonConvert.SerializeObject(forbiddenProcesses, Formatting.Indented);
                File.WriteAllText(blacklistFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении черного списка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListView()
        {
            listViewBlacklist.Items.Clear();
            foreach (var processName in forbiddenProcesses)
            {
                listViewBlacklist.Items.Add(processName);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string processName = textBoxProcessName.Text.Trim();
            if (!string.IsNullOrEmpty(processName))
            {
                if (!forbiddenProcesses.Contains(processName))
                {
                    forbiddenProcesses.Add(processName);
                    SaveBlacklist();
                    UpdateListView();
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewBlacklist.SelectedItems.Count > 0)
            {
                string selectedProcess = listViewBlacklist.SelectedItems[0].Text;
                forbiddenProcesses.Remove(selectedProcess);
                SaveBlacklist();
                UpdateListView();
            }
        }

        private void buttonStartMonitoring_Click(object sender, EventArgs e)
        {
            timerMonitoring.Start();
            buttonStartMonitoring.Enabled = false;
            buttonStopMonitoring.Enabled = true;
        }

        private void buttonStopMonitoring_Click(object sender, EventArgs e)
        {
            timerMonitoring.Stop();
            buttonStartMonitoring.Enabled = true;
            buttonStopMonitoring.Enabled = false;
        }

        private void timerMonitoring_Tick(object sender, EventArgs e)
        {
            foreach (var processName in forbiddenProcesses)
            {
                var processes = Process.GetProcessesByName(processName);
                foreach (var process in processes)
                {
                    try
                    {
                        process.Kill();
                        textBoxLog.AppendText($"Закрыт запрещенный процесс: {process.ProcessName}\r\n");
                    }
                    catch (Exception ex)
                    {
                        textBoxLog.AppendText($"Ошибка при попытке закрыть процесс {process.ProcessName}: {ex.Message}\r\n");
                    }
                }
            }
        }
    }
}
