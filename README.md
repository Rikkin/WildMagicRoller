# WildMagicRoller
First self-made small project to try out some C# Coding, by making tools for dnd5e.
Want to learn:  Mvvm and storing in Xml files

WildMagicRoller in its first stage, will be a form where you can input a number,
or roll a random number by simulating a d100 roll, and getting the corresponding
wild magic associated with the result. Also has added funtionality for a custom table.
__________________

- Base version of app is finished.

To Do List for the future
- Ability to input a custom effect right into the UI in a textfield, and write it into a new 
  effect that gets stored in the customeffects xml file. Valid Numberrange should update
- Fix the try / catch situation in MainWindow.xaml.cs -> Line 42 and onwards

NB:

- You need to edit your own XML files with results, I only included a few placeholders for testing.
  This is due to the wild magic table not being included in the System Reference Document, and is
  therefor not considered free for distribution.
  
- CustomTable.xml can hold any number of results and the program will read them on startup.
  This is where you input your own desired resulst for use with the app.
  
- OfficialTable.xml should always be fifty results as this is hardcoded to match dnd 5e's table.

