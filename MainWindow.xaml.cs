using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GA_Prog_2_Lists
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Global List
        List<string> studentNames = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
            // Calling my Preload() method
            Preload();
            DisplayStudents();

        } // Main Window


        // Part 1
        // Calling this method clears the rich text box and displays all students names
        public void DisplayStudents()
        {
            rtbDisplay.Text = ""; // Used to clear the display before redisplaying names

            for (int i = 0; i < studentNames.Count; i++)
            {
                rtbDisplay.Text += $"{i} - {studentNames[i]}\n"; // Formatted to display index and student name
            }

            lblCount.Content = $"Count: {studentNames.Count}"; // Updates Current List Count
        } // DisplayStudents()

        // I create a preload method that I fill with stuff I want to run when the program loads. Then call it from MainWindow()
        // This keeps the MainWindow() a lot cleaner
        public void Preload()
        {
            studentNames.Add("Will");
            studentNames.Add("Hannah");
            studentNames.Add("Dylan");
            studentNames.Add("Kristyn");
            studentNames.Add("Josh");
            studentNames.Add("Manjula");

        } // Preload()

        // Part 2
        // Click Event : Adds Student When Clicked
        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string studentName = txtNewStudent.Text; // Grab student name

            studentNames.Add(studentName); // Add the student name to list

            DisplayStudents(); // Redisplay Info

        } // btnAddStudent

        // Part 3
        // Click Event : When clicked, a Message Box appears with the students name
        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {
            string indexString = txtIndex.Text; // Getting the users selection
            int index = int.Parse(indexString); // Parsing value to int

            string selectedStudent = studentNames[index]; // Saving the selected student

            MessageBox.Show(selectedStudent); // Displaying Student
        } // btnDisplayStudent_Click

        // Part 4
        // Click Event : Removes Student at index
        private void btnRemoveAtIndex_Click(object sender, RoutedEventArgs e)
        {
            string indexString = txtIndex.Text; // Getting the users selection
            int index = int.Parse(indexString); // Parsing value to int

            studentNames.RemoveAt(index); // Passing index of student to remove

            DisplayStudents(); // Redisplay updated list of students

        } // btnRemoveAtIndex_Click

        // Part 5
        // Click Event : Adds Student at Index
        private void btnAddStudentAtIndex_Click(object sender, RoutedEventArgs e)
        {
            string studentName = txtNewStudent.Text; // Grab student name

            string indexString = txtIndex.Text; // Getting the users selection
            int index = int.Parse(indexString); // Parsing value to int

            studentNames.Insert(index, studentName); // Insert student name at index

            DisplayStudents(); // Redisplay Students

        } // btnAddStudentAtIndex_Click

        // Part 6
        // Click Event : Clear List
        private void btnClearList_Click(object sender, RoutedEventArgs e)
        {
            studentNames.Clear(); // Clearing the list of all names

            DisplayStudents(); // Redisplaying the list ( which should now be empty )


        } // btnClearList_Click

    } // class

} // namespace
