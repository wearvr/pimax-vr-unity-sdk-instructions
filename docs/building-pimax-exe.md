# Creating .exe files for use with Pimax

## Build settings

Ensure that all scenes intended to be used in the final project have been added to 'Scenes to build' and have been recently saved.

'Platform' should be set to 'Windows, Mac and Linux Standalone'.

Change 'Architecture' to 'x86_64'.

Press 'Build' to select a output folder.

<p align="center">
  <img alt="Build settings" width="500px" src="/docs/assets/BuildSettings.png">
</p>

## Playing your app

In the output folder several files will be generated. Including '-project-name-.exe', 'UnityCrashHandler64.exe', 'UnityPlayer.dll' and 'WinPixEventRuntime.dll'. All of these files should be kept together if moving your application from your build folder to another directory.

Opening the .exe file with the same name as your project, while the Pimax device is set up and ready to use, should result in the program being correctly transmitted to the headset.

### Next: Pimax sample scenes

See [Pimax sample scenes](/docs/pimax-sample-scenes-overview.md)
