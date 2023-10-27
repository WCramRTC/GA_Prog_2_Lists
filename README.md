# GA_Prog_2_Lists

### TL:DR - Quick Assignment Goals

[Used for Assignment : C# List - Info](https://www.c-sharpcorner.com/article/c-sharp-list/)  

**Part 1** - Create a list, add names, display names  
`List<type> nameOfList = new List<type>()`
1. Create a new wpf project, name it GA\_***YourName***\_List
2. `Designer: `  
	* Add a RichTextBox and give the `Run` a name. ( I might call it rtbDisplay. But your choice. )  
	* Add a Label ( give it a name of `lblCurrentCount`. You'll use this to display how many students are current in the list.
3. `Code:` - Create a global `List<string>`, the name should be `studentNames`. Initialize it.
4. In your `MainWindow.xaml.cs`, add 5 names to your `studentNames` list.
5. Write a method, `DisplayStudents` that, when called, displays all the names from your `studentsList` to the Rich Text Box. This should also display the `index` next to the name. Example  
> `0 - Will`  
> `1 - Dylan`  
> `2 - Hannah`  
> `3 - Kristyn`  

also inside the method add the line display `yourListName.Count` to your label.
		
6. Call your `DisplayStudents()` method in your `MainWindow()` method

***Result: The names you added to your list should display on your Rich Text Box and your label should display how many students there are.***  

--- 
**Part 2** - Add A new Student Name to the list, Redisplay Names  
`listName.Add(string)`
1. `Designer: ` -

	* Add a label ( Content = "Student Name" ) 
	* Textbox ( For the user to enter a student name )
	* Button ( Content = "Add Student ). Add a click event to the button. 
3. `Code:` - In your click event, take the Student Name from the text box, and add it to your `studentsList`. Then redisplay all your students in the Rich Text Box. This should all be done on a single button click.

***Result: The names you added to your list should display on your Rich Text Box***  

--- 
**Part 3** - Display a Student with their Index  
 `listName[index]`
1. `Designer: ` - 		
	* Label ( "Enter an index" )
	* Textbox ( to take an index )
	* Button ( Content = "Display Student Name" ). Add a click event.
2. `Code:` - In your click event, take the number from your textbox, parse it into an int	
( ***Indexs are ALWAYS whole numbers*** ). 
3. Then using the index display the associated student name in a `MessageBox.Show()`.

***Result: When the button is clicked, a message box displaying the students name should appear*** 

---
**Part 4** - Remove a Student By Index  
 `listName.RemoveAt(index)`
1. `Designer: ` - 
	* Button ( Content = "Remove by index" ) and a click event.
	* You will use the same Text Box from Part 3 to get the index.
2. `Code:` - In your click event, take the number from your textbox, parse it into an int  
( ***Indexs are ALWAYS whole numbers*** ). 
3. Then use that index to remove the assoicated student from the list. Redisplay all students with your `DisplayStudents()` method.

***Result: When the button is clicked, your list of students, minus the one you just removed, should appear.*** 

***Extra Credit \:*** Add another button to remove by name. Use your first text box used to add a student.
  `listName.Remove(name)`

 ---
**Part 5** - Add Student at Index   
  `listName.Insert(index, Name)`
1. `Designer: ` -
	* Button ( Content = "Add Student At Index" ) and add a click event.
	* You will use your TextBoxes for Student Name and Index for this Part.
2. `Code:` - In your click event, take the number from your textbox, parse it into an int.
3. On Click you should get the Student Name in your text box, and the index, and add the Student name to the correct location in the list. 
4. Redisplay all students with your `DisplayStudents()` method.

 ***Result: When the button is clicked, your list of students, including the new one at the selected index, should appear.*** 

---
**Part 6** - Remove All Students
 `listName.Clear()`
1. `Designer: ` - 
	 * Button ( Content = "Clear list" ) and add a click event.
2. `Code:` - In your click event, clear the list.
 3. Redisplay all students with your `DisplayStudents()` method.

 ***Result: When clicked, your RichTextBox should appear empty, and your count should be 0.***

 ---
 **Submission : Submit your GitHub Repo URL**
---
## Control

### How it works

## Step By Step