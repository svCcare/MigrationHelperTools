# Migration Template Instalation

Put .zip file into ItemTemplates folder
Type `/ItemTemplates` in Windows Run field

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
