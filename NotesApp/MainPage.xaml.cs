﻿
namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(_fileName))
                TextEditor.Text = File.ReadAllText(_fileName);
        }
        private void SaveButton_Clicked(object sender, EventArgs e)
           
        {
            // Save the file.
            File.WriteAllText(_fileName, TextEditor.Text);
            DisplayAlert("OK", "Arquivo Salvo", "Valeu");
            
        }
        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            // Delete the file.
            if (File.Exists(_fileName))
                File.Delete(_fileName);
            TextEditor.Text = string.Empty;
        }
    }

}
