﻿using System.Windows;

namespace ScrollingDataGridWithNoDataExample
{
    public partial class MainWindow : Window
    {
        public class Row
        {
            public string Column0 { get; set; }
            public string Column1 { get; set; }
            public string Column2 { get; set; }
            public string Column3 { get; set; }
            public string Column4 { get; set; }
            public string Column5 { get; set; }
            public string Column6 { get; set; }
            public string Column7 { get; set; }
            public string Column8 { get; set; }
            public string Column9 { get; set; }

            public Row(int index)
            {
                Column0 = $"value0-{index}";
                Column1 = $"value1-{index}";
                Column2 = $"value2-{index}";
                Column3 = $"value3-{index}";
                Column4 = $"value4-{index}";
                Column5 = $"value5-{index}";
                Column6 = $"value6-{index}";
                Column7 = $"value7-{index}";
                Column8 = $"value8-{index}";
                Column9 = $"value9-{index}";
            }
        }

        private const int rowCount = 1000;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRowsButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.BeginEdit();

            for (int i = 0; i < rowCount; ++i)
            {
                dataGrid.Items.Add(new Row(dataGrid.Items.Count));
            }

            dataGrid.CommitEdit();
        }

        private void DeleteRowsButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.BeginEdit();

            for (int i = 0; i < rowCount; ++i)
            {
                if (dataGrid.HasItems)
                {
                    dataGrid.Items.RemoveAt(dataGrid.Items.Count - 1);
                }
            }

            dataGrid.CommitEdit();
        }
    }
}
