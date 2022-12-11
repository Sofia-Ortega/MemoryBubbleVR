# Memory Bubble 

## About

Memory Bubble is a **Virtual Reality** project, created to help those patients experiencing memory decline. The application will transport the patient to a significant setting, such as their childhood home, to incite memories.

This application was created in extension of the following research:
https://ivr-health.com/

# Code
- Unity (version 2021.3.10f1)
- C#

## Features
- 360 degree background image
- Popup slideshow of personal images

## Visual

Figure 1: 360 degree background picture - VR enviroment 

![unityExampleArch](https://user-images.githubusercontent.com/40405324/206888134-c9d78f5b-2401-45c7-9cc3-b98c04495bbd.gif)



Figure 2: Slideshow of images

![unityExampleArch2](https://user-images.githubusercontent.com/40405324/206888203-32ae7bc8-418c-4fce-9e4f-2021ec46810b.gif)


Figure 3: Moving interacting with slideshow

![unityExampleArch3](https://user-images.githubusercontent.com/40405324/206888593-d0ca740e-6284-4663-af27-449c8fb71485.gif)




## Files
The code has 4 main C# files, found in directory [/Assets/Scripts](https://github.com/Sofia-Ortega/MemoryBubbleVR/tree/main/Assets/Scripts)
- [RenderCanvas.cs](https://github.com/Sofia-Ortega/MemoryBubbleVR/blob/main/Assets/Scripts/RenderCanvas.cs): Renders canvas (image slideshow) after certain amount of time
- [LookAtUser.cs](https://github.com/Sofia-Ortega/MemoryBubbleVR/blob/main/Assets/Scripts/LookAtUser.cs): Personal pictures faces User
- [ChangeImages.cs](https://github.com/Sofia-Ortega/MemoryBubbleVR/blob/main/Assets/Scripts/ChangeImages.cs): Rotates through given array of images
- [FunctionTimer.cs](https://github.com/Sofia-Ortega/MemoryBubbleVR/blob/main/Assets/Scripts/FunctionTimer.cs): Creates timer to execute function after given time. Helper class


## Future Improvements
- Canvas (image slideshow) renders at eyelevel of user, rather than at fixed coordinates
- Menu System & UI - more instructions and prompt for users
- Store pictures in online database so users can easily upload personal pictures 
- Click through different 360 degree backgrounds



