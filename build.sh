echo First remove old binary files
rm *.dll
rm *.exe

echo View the list of source files
ls -l

echo Compile redlightuserinterface.cs to create the file: redlightuserinterface.dll
mcs -target:library -r:System.Drawing.dll -r:System.Windows.Forms.dll -out:redlightuserinterface.dll redlightuserinterface.cs

echo Compile Fibonaccimain.cs and link the two previously created dll files to create an executable file.
mcs -r:System -r:System.Windows.Forms -r:redlightuserinterface.dll -out:RedLightProject.exe redlightmain.cs

echo View the list of files in the current folder
ls -l

echo Run the Assignment 1 program.
./RedLightProject.exe

echo The script has terminated.
