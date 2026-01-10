# Raptors Soccer Website - Computer Setup Guide

Follow these steps in order to set up your computer to run the Raptors Soccer website.

---

## Step 1: Download and Install Visual Studio Code

Visual Studio Code is where you will write and edit your code.

1. Open your web browser (Chrome, Edge, or Firefox)
2. Go to: **https://code.visualstudio.com**
3. Click the big blue **"Download for Windows"** button
4. Wait for the file to download (it will be called something like `VSCodeUserSetup-x64-1.xx.x.exe`)
5. Open your **Downloads** folder and double-click the file you just downloaded
6. If Windows asks "Do you want to allow this app to make changes?" click **Yes**
7. Follow the installer:
   - Click **"I accept the agreement"** then click **Next**
   - Click **Next** again (keep the default location)
   - Click **Next** again
   - **Important:** Check these boxes:
     - [x] Add "Open with Code" action to Windows Explorer file context menu
     - [x] Add "Open with Code" action to Windows Explorer directory context menu
     - [x] Add to PATH
   - Click **Next**
   - Click **Install**
   - When finished, click **Finish**

---

## Step 2: Download and Install Git

Git lets you download code from the internet and save your changes.

1. Open your web browser
2. Go to: **https://git-scm.com/download/win**
3. The download should start automatically (if not, click "Click here to download manually")
4. Wait for the file to download (it will be called something like `Git-2.xx.x-64-bit.exe`)
5. Open your **Downloads** folder and double-click the file
6. If Windows asks "Do you want to allow this app to make changes?" click **Yes**
7. Follow the installer:
   - Click **Next** on every screen (the default options are fine)
   - Keep clicking **Next** until you see **Install**
   - Click **Install**
   - When finished, click **Finish**

---

## Step 3: Download and Install .NET 9 SDK

.NET is what makes the website code run on your computer.

1. Open your web browser
2. Go to: **https://dotnet.microsoft.com/download/dotnet/9.0**
3. Find the section that says **SDK 9.x.x** (not Runtime!)
4. Under **Windows**, click the **x64** link next to "Installer"
5. Wait for the file to download (it will be called something like `dotnet-sdk-9.x.x-win-x64.exe`)
6. Open your **Downloads** folder and double-click the file
7. If Windows asks "Do you want to allow this app to make changes?" click **Yes**
8. Click **Install**
9. Wait for it to finish, then click **Close**

---

## Step 4: Restart Your Computer

This is important! The programs you just installed need a restart to work properly.

1. Click the **Windows Start button**
2. Click the **Power** icon
3. Click **Restart**
4. Wait for your computer to restart and log back in

---

## Step 5: Install VS Code Extensions

Extensions add extra features to Visual Studio Code.

1. Open **Visual Studio Code** (search for it in the Start menu)
2. On the left side, click the **Extensions** icon (it looks like 4 squares)
   - Or press **Ctrl + Shift + X** on your keyboard
3. In the search box at the top, type: **C# Dev Kit**
4. Find **"C# Dev Kit"** by Microsoft (it has a purple icon)
5. Click the blue **Install** button
6. Wait for it to finish installing (this may take a minute)
   - This will also automatically install "C#" and ".NET Install Tool"

---

## Step 6: Download the Raptors Website Code

Now you will download the website code from the internet.

1. Open **Visual Studio Code** (if not already open)
2. Press **Ctrl + Shift + P** on your keyboard (this opens the Command Palette)
3. Type: **Git: Clone**
4. Click on **"Git: Clone"** when it appears
5. Paste this link: **https://github.com/ivanowen/raptorsite.git**
6. Press **Enter**
7. Choose where to save it:
   - Navigate to your **Documents** folder
   - Click **"Select as Repository Destination"**
8. Wait for the download to complete
9. When it asks **"Would you like to open the cloned repository?"** click **Open**

---

## Step 7: Run the Website

Now let's start the website!

1. You should now have the project open in VS Code
2. On the left side, you should see files and folders including **RaptorsWWW**
3. Press **F5** on your keyboard
4. Wait a moment while it builds (you'll see text scrolling in the bottom panel)
5. Your web browser should open automatically showing the Raptors Soccer website!

**If the browser doesn't open automatically:**
- Look at the bottom panel in VS Code
- Find a line that says something like `Now listening on: https://localhost:5001`
- Open your web browser and go to that address

---

## Troubleshooting

### "dotnet is not recognized" error
- Make sure you restarted your computer after installing .NET 9 SDK
- Try closing and reopening VS Code

### F5 doesn't do anything
- Make sure you installed the C# Dev Kit extension
- Make sure you have the project folder open (not just a single file)

### Browser shows "This site can't be reached"
- Wait a few more seconds - the website might still be starting up
- Make sure you see "Now listening on:" in the VS Code terminal

### Something else is wrong
- Ask a parent or teacher for help
- Make sure you followed all the steps in order

---

## Stopping the Website

When you're done:
1. Go back to Visual Studio Code
2. Press **Shift + F5** to stop the website
3. Or click the red square "Stop" button at the top of the screen

---

## Starting the Website Again Later

Next time you want to work on the website:
1. Open Visual Studio Code
2. Click **File** > **Open Folder**
3. Navigate to **Documents** > **raptorsite**
4. Click **Select Folder**
5. Press **F5** to run the website

---

Congratulations! You're now ready to work on the Raptors Soccer website!
