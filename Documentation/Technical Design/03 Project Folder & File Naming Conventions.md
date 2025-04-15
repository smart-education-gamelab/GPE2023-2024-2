# Project Folder & File Naming Conventions

This document describes the folder and file naming conventions of the project.

## Project Folder Structure 

The root folder of our project is the `Assets` folder. Subfolders of our project are based on the following:

### Per-concept

Since the project is divided into multiple concepts, each concept will have its own folder with used assets and scenes. The subfolders within the concept folder, group related assets together (e.g. `Scenes`, `Objects`, `Graphics`, `Audio`, `Settings`), while leaving specific asset types in their own sub-sub-folders (e.g. `Objects/Prefabs`, `Objects/Game Events`, `Objects/Progression`).

### Common 

Besides the concept folders, there is also a `Common` folder. This folder contains assets that are shared between multiple concepts. The subfolders within the common folder, group related assets together (e.g. `Objects`, `Settings`), like in the concept folders.

### Scripts

Lastly, there is a `Scripts` folder, which contains all the scripts of the project. Most folders are feature based, meaning they contain scripts related to a specific feature as defined in the project's design. However, there is small set of fixed subfolders within the scripts folder:

- `Editor`: Contains all editor scripts

    <details>

    Subfolders are based on what the scripts are inheriting from (e.g. `Editor` (called `Custom` to avoid conflicting namespace), `Drawers`, etc.)

    </details>

- `Attributes`: Contains all custom attributes

- `Events`: Contains all event-related scripts

    <details>

    This should only contain scripts that are directly related to events (e.g. `GameEvent`, `EventListener`) and built-in types for typed events (e.g. `IntEvent`, `FloatGameEvent`). Custom event types should be placed in their respective feature folder.

    </details>

- `UI`: Contains all UI scripts

    <details>

    Subfolders are based on which feature the scripts are related to (e.g. `FeatureOne`, `FeatureTwo`, etc.), but if they are generic they can be placed directly in the `UI` folder.

    </details>

### Example Structure

```markdown
Assets/
├── Concept 1/
│   ├── Scenes/
│   │   ├── Development/
│   │   └── Release/
│   ├── Objects/
│   │   ├── Prefabs/
│   │   ├── Game Events/
│   │   ├── Progression/
│   │   └── .../
│   ├── Graphics/
│   │   ├── Textures/
│   │   ├── Materials/
│   │   ├── Shaders/
│   │   └── .../
│   ├── Audio/
│   ├── Settings/
│   └── .../
├── Concept 2/
├── Common/
│   ├── Objects/
│   ├── Settings/
│   └── .../
└── Scripts/
    ├── Editor/
    │   ├── Custom/
    │   ├── Drawers/
    │   └── .../
    ├── Attributes/
    ├── Events/
    ├── UI/
    ├── FeatureOne/
    ├── FeatureTwo/
    └── .../
```

## Project Folder Naming Conventions

### Concept Folders

Concept folders & subfolders use `Title Case` for naming and the root concept folders follow the format of `Concept [Number]`.

### Common Folder

The common folder & subfolders uses `Title Case` for naming.

### Scripts Folder

The scripts folder & subfolders use `PascalCase` for naming as defined in `02 Code Conventions & Repository Management`.

## File Naming Conventions

There isn't a specific file naming convention for the project. However, the following general rules apply:

- `PascalCase` for script files as defined in `02 Code Conventions & Repository Management`

- `Title Case` for other files, unless it is necessary (e.g. `README.md`, `LICENSE.md`, etc.)

- Graphical and audio assets should have a descriptive name that indicates their purpose and content (e.g. `Player Model`, `Background Music 1`, etc.)
