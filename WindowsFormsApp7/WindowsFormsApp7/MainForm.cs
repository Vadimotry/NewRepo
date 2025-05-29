using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CalendarApp
{
    public partial class MainForm : Form
    {
        private Dictionary<DateTime, List<string>> events = new Dictionary<DateTime, List<string>>();
        private string dataFilePath = "calendar_data.txt";

        public MainForm()
        {
            InitializeComponent();
            LoadEvents();
            UpdateCalendar();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            dateLabel.Text = monthCalendar1.SelectionStart.ToShortDateString();
            UpdateEventsList();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateLabel.Text = monthCalendar1.SelectionStart.ToShortDateString();
            UpdateEventsList();
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(eventTextBox.Text))
            {
                DateTime selectedDate = monthCalendar1.SelectionStart;
                string eventText = eventTextBox.Text;

                if (!events.ContainsKey(selectedDate))
                {
                    events[selectedDate] = new List<string>();
                }

                events[selectedDate].Add(eventText);
                eventTextBox.Clear();
                UpdateEventsList();
                SaveEvents();
            }
            else
            {
                MessageBox.Show("Введите текст события", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            if (eventsListBox.SelectedIndex != -1 && events.ContainsKey(selectedDate))
            {
                events[selectedDate].RemoveAt(eventsListBox.SelectedIndex);
                UpdateEventsList();
                SaveEvents();
            }
        }

        private void UpdateEventsList()
        {
            eventsListBox.Items.Clear();
            DateTime selectedDate = monthCalendar1.SelectionStart;

            if (events.ContainsKey(selectedDate))
            {
                foreach (string eventText in events[selectedDate])
                {
                    eventsListBox.Items.Add(eventText);
                }
            }
        }

        private void UpdateCalendar()
        {
            monthCalendar1.RemoveAllBoldedDates();
            foreach (DateTime date in events.Keys)
            {
                monthCalendar1.AddBoldedDate(date);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void SaveEvents()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(dataFilePath))
                {
                    foreach (var pair in events)
                    {
                        foreach (string eventText in pair.Value)
                        {
                            writer.WriteLine($"{pair.Key:yyyy-MM-dd}|{eventText}");
                        }
                    }
                }
                UpdateCalendar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEvents()
        {
            if (File.Exists(dataFilePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(dataFilePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
                        {
                            if (!events.ContainsKey(date))
                            {
                                events[date] = new List<string>();
                            }
                            events[date].Add(parts[1]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearDateButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            if (events.ContainsKey(selectedDate))
            {
                if (MessageBox.Show("Удалить все события на выбранную дату?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    events.Remove(selectedDate);
                    UpdateEventsList();
                    SaveEvents();
                }
            }
        }
    }
}