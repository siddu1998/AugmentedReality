# Augmented Reality 

### Installation
1. Install Unity setup windows/mac. Linux will support but eventually you will find no augmented reality plugin support
2. enable vuforia in XR option

Augmented reality Projects
### Unity One

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
