# Project 1

## Overview

This is a unity augmented reality project made to display a virtual cube like figure that shows a glimpse of the Great Pyramids and Sambro Island lighthouse.  The surface that the cube is projected on is detected by two different textured cubes that you can make yourself with paper at this link. The unity app uses an augmented reality library name Vuforia to detect the cube and project the image on your screen. On top of that, you can move the cube around and the image with flip in the direction that you move the cube.

On one side you can see the local time being displayed for the respactive places.

And on the other side you can see the weather and temperature.

You will also be able to hear a sound track playing in the background as you hold each of the cubes.

Moreover, if you show it the Vuforia Astronaut ImageTarget, you will be able to see a scene of a park, with A gate for the enterance, a fence surrounding the area, a tree, a swing and a stair like structure for the parents to sit around. 

## Installation

- **Github**: [Source code](https://github.com/Rikki407/Rishab-Project-1)

- **Unity Hub**: [https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe](https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe)

    - **Unity version**: [LTS Release 2021.3.6f1 Released: 8 July 2022](unityhub://2021.3.6f1/7da38d85baf6)

- **Openweather API**: [https://openweathermap.org/](https://openweathermap.org/)



### Steps to run

1. Clone the repository in a location in your files

2. Download Unity Hub and install. Make sure to not update to beta.

3. Download Unity v2021.3.6f1 as unity hub link listed above

4. If planning on building on iOS / Android or any other platform, check mark those boxes here to save some time

5. In Unity Hub, locate and open the project

6. Once the project is open, make a Vuforia account and store an API key somewhere. Download Vuforia 9.8 via "Add to Unity" link. From there, Unity should download some libraries if not included in project already.

7. In Unity, under the "Window" tab, click on Vuforia Configuration and add key under "App License Key"

8. Go to the Openweather site and register yourself a personal key by making an account. 
*NOTE: this key can take up to an hour to activate*

9. Open up the two weather api script (WeatherAPI_2 and WeatherAPIScript). This can be found in the project explorer on the bottom on unity. Under the string url in each file towards the top of the file, copy paste your API key in the *<ENTER KEY\>* area of the string. Save file and exit file editors.

10. From here, you should be all set to press play on the top of Unity. It will take your default webcam and you can bring the cube that you made into view of camera.



#### Running the App on an iOS
*Note requires XCode*

1. Follow the instructions listed [above](/#steps-to-run) first.

2. Go to File > Build Settings. Then Click on iOS and press Switch Platform (if shown instead of build)

3. Then go to Edit > Project Settings > Player. Under Other Settings, make sure minimum iOS version is set to 11.0

4. Then go back to Build Settings and press Build and Run. Make sure you store this file into a new folder not in the same directory as the Unity Project.

5. Let it run and eventually you will get some errors. On the left towards the top, click on Unity-iPhone and then in the middle tabs, click on Signing & Capabilities.

6. Check mark Automatically manage signing and either make an account from XCode and make a valid bundle identifier

7. Plug in iOS device and press the top play button to compile and run on iOS


## Assets

### 3D models
- [Camel model by Gabriel Bernardes](https://www.turbosquid.com/3d-models/desert-animal-3d-model-1470845)
- [Anubis model by xhable](https://www.cgtrader.com/free-3d-models/character/man/anubis-the-man)
- [Plateau terrain model by AbsoluteWitch](https://www.cgtrader.com/free-3d-models/exterior/landscape/plateau-terrain-mesh)
- [Clouds low poly model by XT3D](https://www.cgtrader.com/free-3d-models/various/various-models/clouds-low-poly)
- [Old house model by lucass12](https://www.cgtrader.com/free-3d-models/exterior/house/old-house-2--2)
- [Old abandoned cottage model by animated heaved](https://www.cgtrader.com/free-3d-models/exterior/house/old-abandoned-cottage)
- [Tree cartoon model by MarkAlis](https://www.cgtrader.com/free-3d-models/plant/leaf/tree-cartoon-low-poly)
- [Swings model by NEKCOM Entertainment](https://assetstore.unity.com/packages/3d/props/exterior/swing-19032)

### Sounds
- [Belly dancing middle east music by Sound Gallery by Dmitry Taras](https://pixabay.com/music/world-belly-dance-middle-east-arabic-oriental-ethnic-118609/)
- [Wind sound effect by Sound Jay](https://www.soundjay.com/wind-sound-effect.html)

### First Knickknack
For the first knickknack I am trying to potray the great pyramids in Egypt. In which I display the Pyramids, the scorching sun (which I created), the Anubis, and a mud house and a camel to set the scene for the place.
I am playing a mideastern belly soundtrack in the background which really gives you the typical feel of egypt represented in movies while holding the knickknack.

### Second Knickknack
For the second knickknack I am showing the Sambro Island lighthouse. In which I created the lighthouse and a small house and used the models of clouds, a cottage, and the plateau terrain from other creaters (listed above) to mimic [this photograph](https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2F0%2F05%2FSambro_Island_Lighthouse_%25282%2529.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FSambro_Island_Light&tbnid=bmMvvVjymfWB2M&vet=12ahUKEwiqpO3jmaL6AhWtEFkFHcNjDqIQMygAegUIARC1AQ..i&docid=4sI1XOq6CGk0TM&w=4288&h=2848&q=Sambro%20Island&ved=2ahUKEwiqpO3jmaL6AhWtEFkFHcNjDqIQMygAegUIARC1AQ) of the island. The sound is of the wind gushing when you visit the place.



## [Youtube video](https://youtu.be/71ku0LRQ3zY)

## Future of AR

AR glasses have been around for a while now, but they haven’t yet made their way into the mainstream market. However, there are already products on the market that you can buy right now if you want to try out AR glasses yourself. The most popular product on the market right now is probably Google Glass, which has been released by Google as an open platform so anyone can create apps and use them on their own device. It also has some great features like voice control and video recording capabilities (although these features aren’t available in all regions). But many people who wear these devices say that they don’t work well enough to justify buying one just yet because they don’t offer enough value for money compared to other more affordable options available today.

But this could soon change thanks to new companies such as Vuzix Corporation who are working hard at creating augmented reality eyewear products that will make wearing them much more fun than simply looking through a screen or taking pictures with your phone camera! These kinds of products would allow users to see real-time information about what is happening around them using advanced computer vision algorithms combined with sensors built into smart lenses – allowing users to get real-time information about everything from traffic conditions near their location up to further away locations where GPS signals may not reach due to high levels of interference. You can use these smart lenses for many other purposes including being able to read menus at restaurants without having to take your eyes off your phone screen (or wearing glasses) while still being able to make calls on your smartphone as well as taking pictures with its camera!  This kind of technology could also be used for augmented reality applications such as using your eyewear to see the world around you in 3D. Other possibilities include using smart lenses to see through objects, for example being able to look at the inside of a building without having to go in! 

Another interesting application for augmented reality eyewear is being able to play games with real-time information about the game environment displayed on your smartphone screen using a pair of smart glasses. For example, you could have an AR version of Angry Birds in which as you are playing the game there would be a computer vision algorithm that detects objects within a certain range from your eyes and then displays them on your smartphone screen so that you can interact with them by moving around in the virtual space displayed on it. You could even use this technology for educational purposes such as being able to learn about dinosaurs while playing one of these games!

In the end, the possibilities for augmented reality eyewear are endless and the technology is still in its infancy. It will be interesting to see what kind of applications we see in the future!
 
