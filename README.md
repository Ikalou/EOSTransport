# EOSTransport for Mirror
Hello all!

This is a Mirror Transport for Epic Online Service (EOS) originally created by [FakeByte](https://github.com/FakeByte/EpicOnlineTransport/tree/master).  Unfortunately, our dear friend is no longer at Mirror, so the transport was left abandoned.  But no worries!  This transport will be supported as long as my project uses it!

For a quick tutorial on how  to get set up, feel free to follow this 
[Video Tutorials](https://youtube.com/playlist?list=PLMS9RDQ9ar-dQuAjG8KOBpwhBZa1V7y2_)

### Supported Platform
- PC
- MacOS
- Android
- *iOS is currently in development...*

## Dependencies
- Mirror ([Documentation](https://mirror-networking.gitbook.io/docs/))
- Epic Online Services C# SDK ([Documentation](https://dev.epicgames.com/docs/services/en-US/index.html))

## 1. Setting Up Epic Online Services and Obtaining API Keys
You'll need these keys to access the Services!  If you have them already, then ignore this step
1. Login to the [Epic Games Dev Portal](https://dev.epicgames.com/portal) with an Epic Games Account
2. Create a new Product
3. Go to Product Settings -> Clients and add a new Client Policy
4. Name your Client Policy and set the Client Policy Type to Peer2Peer, then Save & Exit
5. Add a new Client
6. Name your Client and set the Client Policy to the Client Policy you just created, then Save & Exit
7. Go to Epic Account Services -> Configure Application
8. Set Application Name to what you want your users to see when signing in with the Account Portal, then Save Draft
9. Go to Permissions and set all permissions to Required, then Save
10. Go to Clients and set the Client to the Client you just created, then Save
11. Go back, then click Back to Organization
12. Go to SDK -> SDK Credentials -> Get Credentials
13. Copy and paste all of your credentials into the EOS API Key Asset once your project is set up

## 2. Installation
1. Install Mirror into your project
    - Install [Mirror Asset Store Page](https://assetstore.unity.com/packages/tools/network/mirror-129321)
    - Import Mirror into your project
        - (Window -> Package Manager -> Packages: My Assets -> Mirror -> Download)
2. Import the EOSTransport into your project
    - Download the [EOSTransport project](https://github.com/WeLoveJesusChrist/EOSTransport) onto your desktop
    - Unzip it
    - Copy the following directories into your **Assets Folder** (merge with already existing folders)
        - Mirror
        - Plugins
        - Sample_Transport (optional)
3. Create your EOS API Key
    - Right click in the Project View and create an EOS API Key Asset (Create -> EOS -> API Key)
    - Fill out all the SDK keys on the EOS API Key Asset, you can find them in the Epic Online Services Dev Portal (SDK -> SDK Credentials -> Get Credentials)

## 3. Running a demo
Provided to you in the **Sample_Transport** directory is a scene that shows you what is needed on a gameobject in order for this transport to work.

*Please note that you'll need two devices to test this transport!*

1. Start the lobby as a Host Player
    - On your first computer, open the **Sample_Transport/SampleScene**
    - Click on the **_NetworkManager** object
    - Scroll down to the **EOSSDK Component** and be sure to set the **Api Keys** slot to the one you set in **Step 2.3**
    - Click play
    - When the game starts, click "Host"
        - You will see in the log the following message:  
        ```
        "EOS User Product ID: 00020000000000000000000000000"

        That long string is your PID!  
        That's the number your second device will use to connect to this Host Player!
        ```

2. Join the lobby as a Client Player
    - On your second computer, open the **Sample_Transport/SampleScene**
    - Perform the same steps as above but thsi time, instead of clicking "Host", fill out the text field with the Host Player's PID and click "Client"
    - If successful, you should be connected to the Host Player
    - Press the "A" to move left, "D" to move right on both computers to see the player moving on the screen

## 4. Building for Android
1. Install the **Android Module** through **Unity Hub**
2. In File -> Build Settings, switch platform to Android
3. In Unity -> Edit -> Project Settings... -> Player -> Android -> Other Settings -> Identification set Minimum API Level to Android 6.0 'Marshmallow' (API Level 23) as required by the EOS Android SDK
4. (Optional) Install Android Logcat through Package Manager to see logs when running on Android device over USB (Window -> Package Manager -> Packages: Unity Registry -> Android Logcat -> Install) then open with Alt+6 or Window -> Analysis -> Android Logcat


## Old Notes from FakeByte
Change the [Auth Interface Credential Type](https://dev.epicgames.com/docs/services/en-US/API/Members/Enums/Auth/EOS_ELoginCredentialType/index.html) and [Connect Interface Credential Types](https://dev.epicgames.com/docs/services/en-US/API/Members/Enums/NoInterface/EOS_EExternalCredentialType/index.html) on the EOSSDKComponent to suit the needs of your project

### Testing multiplayer on one device
Running multiple instances of your game on one device for testing requires you to have multiple epic accounts.
Even if your game doesn't use epic accounts you will need them for testing.

0. Add all epic accounts you want to test with to your organization in the dev portal
1. On the EOSSDKComponent under User Login set Auth Interface Login to true
2. Choose 'Developer' as Auth Interface Credential Type
3. Choose 'Epic' as Connect Interface Credential Type
4. Open the epic transport folder with a file explorer and go into the DevAuthTool folder
5. Create a folder that ends with ~ e.g. Tool~, this makes unity ignore this folder
6. Unzip the dev auth tool for your OS (Mac/Win) into the folder you created in step 5.
7. Run the dev auth tool 
8. Enter a port in the dev auth tool
9. Login to your epic account and give the credential a name
10. Repeat step 9 for as many accounts you want to use
11. On the EOSSDKComponent set the port to the one you used in the dev auth tool
12. On the EOSSDKCOmponent set Dev Auth Tool Credential Name to the named you chose in the tool

Note: In the editor after logging in with the dev auth tool you cant change the credential name as the sdk stays initialized even after finish playing. You either have to restart unity or the dev auth tool. For builds it is useful to set delayed initialization on the EOSSDKComponent to true and then provide a user input field to set the dev tool credential name and then calling EOSSDKComponent.Initialize().

## Credits
**FakeByte**:  "Big thanks to erikas-taroza aka TypicalEgg for his help in improving and extending this transport!"

**Me**:  "Big thanks to FakeByte for creating this transport, which I simply just updated and expanded on
