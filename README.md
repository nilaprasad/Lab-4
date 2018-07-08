# Lab 4
Design two C# projects as follows.

Project 1) Windows Forms Control Library Project

Design a user-defined control for Windows forms that can be used as a “PIN PAD”. Your control should have ten number buttons “0-9”, a button to “Get Access”, a button to “Clear Input” and a button to “Cancel Input”. In addition your control should also have a text box which PasswordChar property is set to “*”. Please note that the number buttons are used to enter a pin number up to 6 digits into the text box.

Your user control class should have the following public string properties:
 - FilePath, a property that is used to access the string variable that stores a path of the file  which contains user names and their corresponding pin numbers,
 - AccessCode, a read only property which is used to access the Text property of the text box,  i.e., to read the value entered into the text box,
 - UserName, a read only property that is used to access the string variable that stores a username.
 
Create the two events (i.e. private event fields and public event properties) named AccessOK and AccessNO for the user control class. You can use the standard System.EventHandler delegate type or your own delegate type for these two events. Please note that these events are raised when the “Get Access” button is clicked. The AccessOK event will be raised if the pin number entered into the text box is found in the file, while the AccessNO event will be raised if the pin entered is not found in the file. The user should be limited to three attempts to enter in a pin. Please note also that each user should be assigned a different pin, which is saved into a file along with the user name.

Project 2) Windows Forms Application

Design a Windows Forms application that uses two forms as follows:
 First Form:

Contains previously designed user control in Project 1 to obtain an access code (i.e., pin number) from the user. There are two different kinds of users: management and personnel. This form will create and use appropriate event handlers to handle the AccessOK and AccessNO events defined in the user control class. If the manager’s access code “123456” is entered, the second form will be shown and the first form hidden. If the personnel access code is entered, the “ACCESS GRANTED” message will be shown and the date and time when the access was granted will be saved into a second file along with the user name. The user should be limited to
three attempts to get the access granted.

 Second Form:
This form is used by the management to assign/add and delete access codes (i.e., pin numbers and corresponding user names) for the authorized personnel that will be saved into the first file. This form should also enable the management to search the second file for the personnel who were granted access on a specific date and time (e.g., 08/02/2017 after 8 a.m.)
