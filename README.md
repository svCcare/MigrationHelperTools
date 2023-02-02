# Migration Template Instalation

Put Migro.zip file into ItemTemplates folder. It can be found by typing `/ItemTemplates` into the Windows Run field
>IMPORTANT you need to restart VS since it detects these packages only during startup

# Migration Template Usage
Right click on solution explorer in location where you want to create new migration
Add... -> New Item... -> Look for `Migro` -> Create and adjust file to your standards

# Migration Timestamp Instalation
Create release version of MigrationHelperTools, locate .exe file

In VS navigate to Tools -> External Tools... 
Add new Tool
In `Command` field, select created .exe file

![image](https://user-images.githubusercontent.com/27490969/173327451-27e82bce-a875-4116-8cbb-887e8c48c6a0.png)


# Migration Timestamp Generator Usage
Tools -> Select `However you called newly created Tool` -> Now you have Timestamp in your clipboard

# VS2022 settings to keep usings inside of namespace
![image](https://user-images.githubusercontent.com/27490969/173326547-0a6405c3-9d96-4b02-b6d8-6dbcc85616b3.png)
