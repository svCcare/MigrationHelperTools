# Migration Template Instalation

Put Migro.zip file into ItemTemplates folder. It can be found by typing `/ItemTemplates` into the Windows Run field

# Migration Template Usage
Right click in solution in location where you want to create new migration
Add... -> New Item... -> Look for `Migro` -> Create and adjust file to your standards

# Migration Timestamp Instalation
Create release version of MigrationHelperTools, locate .exe file

In VS navigate to Tools -> External Tools... 
Add new Tool
In `Command` field, select created .exe file

# Migration Timestamp Generator Usage
Tools -> Select `However you called newly created Tool` -> Now you have Timestamp in your clipboard

# VS2022 settings to keep usings inside of namespace
![image](https://user-images.githubusercontent.com/27490969/173326547-0a6405c3-9d96-4b02-b6d8-6dbcc85616b3.png)
