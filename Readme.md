# UWP Responsive Design Sample

The topic of adaptive UI is cornerstone on Windows 10 UWP apps. One may argue that this is one area where Microsoft actually increased complexity on Win 10, as you now need to have one app that runs across all devices, meaning your UI needs to gracefully adapt to whatever form factor is running on.

The good news is that most of the challenges can be met by creating a responsive UI that knows how to adapt itself based on the window size, rather than trying to target specific form factors or physical screen sizes. You can actually tailor your experience based on the later, however, this should only be done if you really need to.

Responsive design is not a new topic by itself. Web developers have been doing this for a long time now. However, Microsoft introduced a number of new features in our XAML framework to better support the most typical techniques for responsive UI design in apps, and we are offering some guidance on how developers can address this challenge.

Part of the guidance provided pertains to the 6 R’s, which you can think of recipes for content adaptability:

* Resize
* Reflow
* Reposition
* Reveal
* Rearchitect
* Replace

This sample goes through these techniques and shows how they are implemented, and how can they be used in several scenarios. All scenarios work both on the desktop and a phone running Win 10, but to make it easier to demo if you don’t have a phone available, I added a little button to the top right that allows you to resize the app all the way down to a phone screen size (and it will look exactly like that on a Win 10 phone). 

### Next Steps

1. Making sure the sample works on Xbox correctly as I expect some handling of the controller needs to be done.
2. Detailed project documentation in a blogpost, soon to be linked here
