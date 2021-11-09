# DXR with Mixed Reality Toolkit
DXR is a library for visualizing data in virtual and augmented reality systems. It was built in 2018 by using the tools provided by the Unity library made by Microsoft for developing applications for HoloLens 1 called [https://github.com/MSHoloLens/HoloToolkit-Unity](HoloToolkit).

With the introduction of HoloLens 2, Microsoft decided to discontinue support for HoloToolkit, creating a new library of tools for the development of augmented reality applications called [Mixed Reality Toolkit](https://github.com/microsoft/MixedRealityToolkit-Unity). This new library takes some of the functionalities of HoloToolkit, but for some features it completely overturns the functioning logic.

I updated every component of DXR, from Unity prefabs to C# classes, to work together with the Mixed Reality Toolkit library instead of HoloToolkit. The artifact produced is therefore a new library, in which support for HoloToolkit has been removed and support for Mixed Reality Toolkit has been introduced.

Please take a look a the folder `demo` to see some demos. 

The file `DXR-MRTK.unitypackage` contains the updated library with MRTK. 

## References

Sicat, Ronell, et al. "Dxr: A toolkit for building immersive data visualizations." IEEE transactions on visualization and computer graphics 25.1 (2018): 715-725. (https://doi.org/10.1109/TVCG.2018.2865152)

HoloToolkit. https://github.com/MSHoloLens/HoloToolkit-Unity, 2017.