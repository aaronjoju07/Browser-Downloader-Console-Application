# 🦊 Browser Downloader Console Application

A C# Console Application that allows users to select and download different versions of various web browsers. The program follows Object-Oriented Programming (OOP) principles such as Abstraction, Encapsulation, Inheritance, and Polymorphism while also handling operating system detection and download progress tracking.

---

## 📌 Features

- ✅ Select from multiple browsers (Chrome, Firefox, Edge, Brave, Zen, Chromium)
- ✅ Displays available versions for each browser
- ✅ Detects the operating system (Windows, macOS, Linux) automatically
- ✅ Downloads the selected browser version with a progress bar
- ✅ Encapsulated & Modular Code following SOLID principles

---

## 📂 Project Structure

```
📦 BrowserDownloader
 ┣ 📂 Models
 ┃ ┣ 📜 Browser.cs          # Abstract base class for browsers
 ┃ ┣ 📜 BraveBrowser.cs      # Brave-specific implementation
 ┃ ┣ 📜 ZenBrowser.cs        # Zen-specific implementation
 ┃ ┣ 📜 ChromiumBrowser.cs   # Chromium-specific implementation
 ┣ 📜 Program.cs             # Main entry point
 ┣ 📜 Downloader.cs          # Handles file download with progress bar
 ┣ 📜 OSHelper.cs            # Detects the user's operating system
 ┣ 📜 README.md              # Project documentation (this file)
 ┣ 📜 BrowserDownloader.csproj # C# project configuration file
```

---

## 🚀 Getting Started

### 📌 Prerequisites

Ensure you have the following installed:
- .NET SDK (6.0 or later) → [Download Here](https://dotnet.microsoft.com/download)
- Git (optional, for cloning the repository)

### 📥 Clone the Repository

Run the following command to clone the repository:

```bash
git clone https://github.com/yourusername/BrowserDownloader.git
cd BrowserDownloader
```

### 🏗️ Build the Project

Use the .NET CLI to build the project:

```bash
dotnet build
```

### ▶️ Run the Application

Run the following command to start the application:

```bash
dotnet run
```

---

## 🛠️ How It Works

### 1️⃣ OS Detection

At startup, the application detects the user’s OS (Windows/macOS/Linux) using `OSHelper.cs`.

### 2️⃣ Select a Browser

Users are presented with a list of supported browsers:

```
Select a browser to download:
1. Brave Browser
2. Zen Browser
3. Chromium Browser
```

They enter a number (e.g., `2` for Zen Browser).

### 3️⃣ Choose a Version

The application then displays available versions for the selected browser:

```
Available Firefox versions: 92.0, 93.1, 94.2
Enter the version you want to download:
```

### 4️⃣ Automatic OS-Based Download

The application determines the correct download link based on the user’s OS and starts downloading the file.

### 5️⃣ Progress Bar

The `Downloader.cs` file manages the file download and displays a progress bar as the download progresses.

---

## 🌟 Example Output

```bash
Detected OS: Windows
Select a browser to download:
1. Google Chrome
2. Mozilla Firefox
3. Microsoft Edge
4. Brave Browser
5. Zen Browser
6. Chromium Browser

Enter your choice (1-6): 4

Available Brave Browser versions: 1.78.27, 1.78.26
Enter the version you want to download: 1.78.27

Downloading Brave Browser version 1.78.27...
[##########      ] 50%  (5 MB / 10 MB)
Download complete!
```

---

## 💡 Technologies Used

- 🔹 **C#** - Object-Oriented Programming (OOP) principles
- 🔹 **.NET Console Application** - CLI-based application
- 🔹 **HttpClient** - To handle HTTP downloads
- 🔹 **Multi-threading** - For efficient downloading with a progress bar

---

## 🛠️ Future Improvements

- 🚀 Add multi-threaded downloads for faster speed
- 🚀 Provide resume download support for large files
- 🚀 Introduce a GUI version for better user experience
