# OOD-C MediaTracker_Final

A WPF application demonstrating three of the design patterns while at school in NTC.

## Features

- **Media Management:** View a list of medias loaded from your personal JSON file.
- **Media Creation:** Add new pieces of Media with different titles, lengths, and priorities.
- **Extensible Design:** Usage of factory design pattern and command to easily add a bit of your own taste to the project.

## Technologies

- **Language:** .NET 8.0
- **UI:** WPF (Windows Presentation Foundation)

## Project Structure

- `CommandPattern/` – Interface `Icommand` for commands to inherit from, along with seperate commands within another folder.
- `InterfaceHandler/` – A class that can handle updating the UI to the user based on selected media.
- `JsonObjectHandling/` – Classes that can handle writing to the users personal JSON file (filled with their media).
- `Media Object/` – Contains the different media classes that user can create. There is also a media factory subfolder that creates media based on user input.
- `Singleton/` – Has a class that can get the users media JSON file.
- `TestJSON` – Contains the User JSON file.

## Getting Started

1. **Clone the repository** and open the solution in Visual Studio 2022.
2. **Build the solution** to restore dependencies.
3. **Run the application.**
4. On startup, the media list should be populated with movies and videos already.
5. Select a media from the media list to view its details.
6. Use the "Add" button to create and add a new media.
