# WildMagicRoller
First self-made small project to try out some C# Coding, by making tools for dnd5e.

Want to learn:  Mvvm and storing in Xml files

WildMagicRoller in its first stage, will be a form where you can input a number,
or roll a random number by simulating a d100 roll, and getting the corresponding
wild magic associated with the result. Also has added funtionality for a custom table.

NB: The public version will not contain official DnD 5E results, since they are
not a part of the free System Reference Document.
__________________

- Base version of app is finished.

- You need to edit your own XML files with results, I only included a few placeholders for testing.
  OfficialTable.xml should hold fifty results while CustomTable.xml should hold twenty.
  All you have to do is change the placeholder text in the WildMagicEffect node.

- If you added more results to the customtable, CustomRoll () in the logic.cs should be changed aswell.
  Also make sure to change the UI text with the new max number (MainWindow.xaml -> Line 52),
 
 
To Do List for the future

- Make sure that you are reading a valid numberrange for custom input, right over the textfield, 
  since the custom tablesize will change with more additions. This should be automated on app start

- Ability to input a custom effect right into the UI in a textfield, and write it into a new 
  effect that gets stored in the customeffects xml file. Valid Numberrange should update
  
- Fix the try / catch situation in MainWindow.xaml.cs -> Line 42 and onwards