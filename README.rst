Purpose
=======

scrot is Screen capture tool on linux. I am using scrot on linux. I
couldn't do to work scrot on Windows. ZScreen has simialr interface to
scrot. So I have extract the source and modified for my own use.


Requirements
============

 - scons
 - scons_csharp(included)
 - Microsoft .NET Framework (for c# compiler)

 - nunit(included, optional)


Compile
=======

1. The command "scons" will generate bin/crop.exe


Using
=====

1. Double click bin/crop.exe.
2. Select region.
3. Choose the directory to be stored. In first time you have to choose the
   directory. This will stored in crop_path.txt. If you want to change the
   directory, then edit crop_path.txt or delete crop_path.txt.
