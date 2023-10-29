# GA_Prog_2_Lists

### What are Lists

> A ```List<T>``` is an object in C# that holds a collection of similar typed objects, just like an array. But a list has features built in that make it easier to work with.
> * A List will automatically grow in size as you add more items, so it doesn't run out of space.
> * The `.Add()` method will automatically place the new item at the end of the list
> * The `.Remove(object)`, `.RemoveAt(index)`and `RemoveRange(start, count)` easily let you remove items depending on location, value, or a range of elements.
> * `.Clear()` will empty all elements from a list
> * A list will maintain element integreity. Meaning if you remove an item from index 5, everything after 5 will be moved forward a space, so there are no gaps left in between.  

#### How To Initialize
To Initialize a list : `List<T> listName = new List<T>();`  
Example : `List<string> names = new List<string>;`

#### How to add to a list
How to : `listName.Add(object);`  
Example: `names.Add("Will");`

You will use the `.Add(object)` method to add to a list. These are placed in ascending order. ( First item is at index 0, next item at index 1, etc... unless `.InsertInto(index, object)` is used.

#### How to add at index
How to : `listName.Insert(index, object);`  
Example : `names.Insert(3, "Kristyn");`  

This will insert the name Kristyn at index 3.

#### How to access an element ( Value ) in the list
How to : `listName[index]`  
Example: `string firstName = names[0];`

You access elements in the list the same way you do an array.

#### Get current number of elements
How to : `listName.Count;`  
Example: `int count = names.Count;`

Using the `.Count` property returns how many elements you've added. So if you add the names `Bob, Jackie, Will`, then the count will be 3. This is used with the for loop.

```
    for(int i = 0; i < listName.Count; i++ ) {
        // Code to run
    }
```

#### How to remove

There are 3 ways to remove items from a list

**Remove(object)**
How To : `listName.Remove(object);`  
Example : `names.Remove("Will");`

This will remove the 1st instance of the exact object. If it's a string it's case sensitive.

**RemoveAt(index)**  
How To : `listName.RemoveAt(index);`  
Example : `names.RemoveAt(0);`

Removes the first item.

**RemoveRange(startIndex, count)**  
How To : `listName.RemoveRange(index,count);`  
Example : `names.RemoveRange(4, 3);`

Remove range takes a starting index, and then a count. So if you say `RemoveRange(3,2)`, then it will start at index 3, and remove 3 and 4.

#### **Clear list**
How To : `listName.Clear();`  
Example : `names.Clear();`

Calling clear on your list removes ALL items from the list. Becareful with this one.

---

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

### **Part 1: Create a List, Add Names, Display Names**

1. Create a new WPF Application with a name of GA\_***YourName***\_List
2. Add Controls
    * Add a Rich Text Box ( Name=`rtbDisplay` )
    * Add a Label ( Content=`Current Count`, Name=`lblCount` ).  
    *We are giving Label a name, because we will change it with code*

`Designer`
```xml
    <Label x:Name="lblCount" Content="Current Count" HorizontalAlignment="Left" Margin="701,20,0,0" VerticalAlignment="Top"/>
    <RichTextBox Margin="505,62,23,62">
        <FlowDocument>
            <Paragraph>
                <Run x:Name="rtbDisplay"/>
            </Paragraph>
        </FlowDocument>
    </RichTextBox>
```


3. In the `Code`. Create a global list.
    * This is a list placed at the top of your MainWindow. It is not in a method, but in the class namespace. This makes the list have the `Scope` of the entire class. Meaning any method can have access to it.

4. Create a new method called `DisplayStudents()`. This method will do 3 things.
* Clear the rich text box ( rtbDisplay.Text = "") 
* Loop through the list of students, and append the index and their name to the box, displaying the list.
* Display the current Count on the label, letting the user know how many students there is.

```csharp
    private void DisplayStudents()
    {

        rtbDisplay.Text = ""; // Clear the Rich Text Box

        // Loop through List
        for (int i = 0; i < studentNames.Count; i++)
        {
        // Append Index, name, and new line to rtbDisplay
            rtbDisplay.Text += $"{i} - {studentNames[i]}\n";
        }

        // Display current student count
        lblCurrentCount.Content = $"Student Count: {studentNames.Count}";
    }
```

5. Add 5 names to your list in the `MainWindow` method, and call your `DisplayStudents()` method.

`Code`
```csharp
    public partial class MainWindow : Window
    {
        List<string> studentNames = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            studentNames.Add("Will");
            studentNames.Add("Dylan");
            studentNames.Add("Hannah");
            studentNames.Add("Kristyn");
            studentNames.Add("Samantha");

            DisplayStudents();
        }


    }
```

***Result***  
When your code runs, you should see the names from the list display

---

### **Part 2 : Add a New Student Name to the List, Redisplay Names**

1. Add a label, text box, and button to the designer.

`Designer`
```xml
    <Label Content="Student Name" />
    <TextBox Name="txtStudentName" />
    <Button Content="Add Student" Name="btnAddStudent" Click="btnAddStudent_Click"/>
```

2. `Click Event` : When the button is clicked, grab the name from the `txtStudentName` text box, and `studentNames.Add(name)` to the list. Then redisplay the names with your `DisplayStudents()` method

>   `.Add(name)` is used to add an object to your list

`Code`
```csharp
    private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
    {
        studentNames.Add(txtStudentName.Text);
        DisplayStudents();
    }
```

***Result***  
When you type in a name and click the button, the name should appear on the list.

---

### **Part 3 :  Display a Student with their Index**

1. Add a label, a text box to take an index, and a button.

`Designer`
```xml
    <Label Content="Enter an index" />
    <TextBox Name="txtIndex" />
    <Button Content="Display Student Name" Name="btnDisplayStudent" Click="btnDisplayStudent_Click"/>
```

2. `Click Event` : 
    1. Take the number from the text box and try to parse it. Here we use a `int.TryParse()`. This allows us to parse for a number, without having it crash if it fails.
    2. Write a condition that checks if the value is in range.   
    `index >= 0 && index < studentNames.Count`  
    This checks that the index is greater than 0, and that it is no longer than the last index in the list.  
    3. Inside our condition, use a `MessageBox.Show(studentNames[index])` to show the selected student.
    4. You can have an else that appears if the index is invalid.
>   `studentNames[index]` passing the index access the value at that inde in the list

`Code`
```csharp
    private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
{
    // Validate Value
    int index = -1;
    bool isANumber = int.TryParse(txtIndex.Text, out int index)

    // Check if the number is between 0 and the last index in the list
    if ( isANumber && index >= 0 && index < studentNames.Count)
    {
        MessageBox.Show(studentNames[index]);
    }
    else
    {
        MessageBox.Show("Invalid index");
    }
}
```

***Result***  
If you type in a valid index number and click the button, the associated name should pop up in a MessageBox.

---

### **Part 4 : Remove a Student By Index**

1. Add a button and click event to remove an item by index. We're using the same text box used on **Part 3** to ask for an index.

`Designer`
```xml
    <Button Content="Remove by Index" Name="btnRemoveByIndex" Click="btnRemoveByIndex_Click"/>
```

2. Using the same logic as in **Part 3**, validate that the index is a valid number in range. If the number is valid then call `studentNames.RemoveAt(index)` and pass in the index to the method call. Afterwards call `DisplayStudents()`;
>   `.RemoveAt(index)` removes the object at the select index from the list

`Code`
```csharp
    private void btnRemoveByIndex_Click(object sender, RoutedEventArgs e)
    {
          // Validate Value
    int index = -1;
    bool isANumber = int.TryParse(txtIndex.Text, out int index)

    // Check if the number is between 0 and the last index in the list
    if ( isANumber && index >= 0 && index < studentNames.Count)
    {
            studentNames.RemoveAt(index);
            DisplayStudents();
        }
        else
        {
            MessageBox.Show("Invalid index");
        }
    }
```

***Result***  
If the user enters a valid index, when the button is clicked, the element at that index should be removed and the list displayed on the Rich Text Box will be updated.

---

### **Part 5**

1. Add a button and click event to the designer. This will be to *Add A Student at an Index*. We are using the `txtStudentName` and `txtIndex` text boxes already on the form.

`Designer`
```xml
<Button Content="Add Student At Index" Name="btnAddAtIndex" Click="btnAddAtIndex_Click"/>
```

2. Validate the index similar to ***Part 3 and Part 4***. 
3. Inside the condition use `studentNames.Insert(index, txtStudentName.Text);`.
>   `InsertInto(index, object)` is used to insert a new object at a specific index

`Code`
```csharp
private void btnAddAtIndex_Click(object sender, RoutedEventArgs e)
{
           // Validate Value
    int index = -1;
    bool isANumber = int.TryParse(txtIndex.Text, out int index)

    // Check if the number is between 0 and the last index in the list
    if ( isANumber && index >= 0 && index < studentNames.Count)
    {
        studentNames.Insert(index, txtStudentName.Text);
        DisplayStudents();
    }
    else
    {
        MessageBox.Show("Invalid index");
    }
}
```

***Result***  
You should be able to add a name AT a partiular index if this works correctly.

---

### **Part 6**

1. Add a button that we will use to clear our list and call `DisplayStudents()`.

`Designer`
```xml
<Button Content="Clear List" Name="btnClear" Click="btnClear_Click"/>
```

2. Inside the button call `students.Clear()`. Followed by `DisplayStudents();`.
>   `.Clear()` will empty a list of all its elements.

`Code`
```csharp
private void btnClear_Click(object sender, RoutedEventArgs e)
{
    studentNames.Clear();
    DisplayStudents();
}
```

***Result***  
The entire list will clear. You should see an empty rich text box, and the label with the count should say 0.

---

## Submission

When done, submit your GitHub Repo URL into the text box and hit submit.