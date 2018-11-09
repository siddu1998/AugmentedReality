# Augmented Reality 

### Installation
1. Install Unity setup windows/mac. Linux will support but eventually you will find no augmented reality plugin support
2. enable vuforia in XR option

Augmented reality Projects
### UnityOne

#### Use case: 
Placing a 3D model over an image entity
#### Rough Steps
1. Set up vuforia account
2. Set up License keys
3. Remove regular camera
4. Plug in AR camera
5. Set AR camera Credentials (license key)
6. Get image for scanning
7. Place assests of AR
8. Make asset a child of Image which is further a child of ar camera
9. add animation to asset
10. Play 
11. Set up android studio , Java Development kit, Java Runtime 
12. Change build settings
13. Change path and sdk locations
14. Build SDK
15. Push to android phone
16. Run

### Functioning
1. Take a print or display the image on digital screen (UnityOne.jpg)
2. Download the UnityOne Apk file onto your android device
3. Install the apk
4. Place your mobile phone camera infront of the UnityOne.jpg
5. Watch the dance of Barbarian on the book cover

### ARBOOK
#### Description
An augmented reality book which projects 3D models as you flip pages of a book
#### Use cases
Can be used in regular academic text books to provide personalization of education and also enhance the better understanding of certain concepts which require higher levels of imagination. 
#### Rough Steps
1. Set up new unity project
2. Set up vuforia
3. set up license key for AR camera
4. Delete normal camera 
5. Develop databases for project with goo Augmentation rate
6. Set up each image object
7. Develop C# scripts for each of the object if u require any kind of animation or task
8. solve animation issues with DefaultTrackable.cs 
9. Convert project to andriod sdk
10. If ios install xcode and follow standard conversion steps

### Coding notes:
#### Adding event listners i.e start playing this image object if this image is shown
#### DataTypes to take note of
a. GameObject : we might declare multiple gameobjects within our scene like cubes, ships, imageobjects etc
b. TrackableBehavious : provides the tracking status in a frame
#### Function to take note of
a. void start() : This function indicates the start of gameplay
b. GameObject.setActive(boolean): each gameobject has an attribute setActive which can be set true or false
#### Reset position
a. add colliders to each of the game object (generally one object and and a wall)
b. add a tag to the wall
c. handle the collision with 
                onTriggerEnter(Collider collide){ if (collide.gameObject.CompareTag("SHIPWALL"))
                      {
                         transform.localPosition = originalPos;
                         }}
### ARGreetingCard
#### Description
Creating a augmented reality greeting card which displays animation and text on showing a greeting card
#### Use Case
Can be used to augment buisness visiting cards and make kiosks more interactive.
### Steps
1. Create Unity Project
2. Get Vuforia License keys
3. Create Vuforia Databases
4. Download Vuforia Databases
5. Enable Vuforia on Unity
6. Add License keys to AR camera
7. Add Image objects
8. Impose with 3D objects
9. Add audio files
10. Change trackable scripts to compile with audio playtimes
11. create apk
12. Download apk into android
13. Happy Birthday!!
#### Coding parts to take note
Adding audio on tracking a particular image target is simillar to repositionsing 
1. create public variables of an AudioSouce and AudioClip w.r.t to the gameobject
2. attach the audiosource (ImageTarger) and audio clip 
3. in the OnTrackingFound() if the trackable behaviour has the coressponding name then OneShot the audiocip
4. in the OnTrackingLost() if the trackable behaviour is lost then Stop the audio source.


### Augmented Canvas
1. creation of 2D Image directly is placed into the Canvas
2. You can place buttons and define functions in the scripts
3. attach the functions using the OnClick() method.
4. Move between the scenes using Screen function

### Virtual Buttons
1. should not be placed over other GameObjects, only on Image objects
2. 6 Important factors
  a. Size --> Should have rectangular space and should have an area 10% of the total
  b. Placement of the virtual button --> place where there is a lot of features
  c. Not on the boarder 
  d. Dont place virtual buttons in coloumn --> prefer row
  e. Sensitivity
  g. Texture Area
  
### AR Object Tracker
1. Clone the object tracker apk
2. Get good quality camera phone
3. Install the APK
4. In the App folder you will find the media component
5. In the media component you will find the A4 tracking sheet
6. place the object to be scanned with the empty area
7. Scan the image using the app till your reach roughly 300 points
8. Once you are done save the .od file which contains the scanned points
9. Now create a new unity project
10. Create Vuforia license key
11. Insert AR camera
12. Align the Vuforia key with AR camera
13. Upload the .od files onto the vuforia Database
14. Download the vuforia database
15. In the hiearchy add an 3D scan Gameobject
16. Change from Default database to the newly imported databse
17. Place the 3D model in the shown cubicle
18. Choose any 3D assest and place it in the cube
19. Play!
20. If it works then convert build settings to Android

### Cylindrical Object Tracking
1. Download the Cylinder images
2. Set the dimensions right
3. Upload it on database 
4. Download databases
5. Import database onto unity
6. Create your Unity Scene
7. To change animations to any prefab --> Find the model, in the rig tab change the animation to legacy and then choose your animation and also change the wrap mode to loop, after this add the animation component in the prefab
8. Develop rotation scripts
9. Play!
