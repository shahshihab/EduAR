# EduAR

A small Vuforia + Unity augmented reality project containing a set of simple lab experiments aimed at school students (Class 9–10 syllabus). The project lets you read a short description of each experiment and then launch an AR scene — when you point your device or webcam at the printed image target the corresponding 3D model appears over the target.

This repository is a work in progress. At the moment there are three experiments included. The models are static (no interactions or animations yet).

## Quick overview

- Platform: Unity + Vuforia Engine
- Purpose: Visual, non-interactive AR demonstrations of simple school lab experiments
- Current state: 3 static 3D models displayed on image targets; WIP for interactive features and animations

## What's included

- Assets/Scenes — AR scenes for the experiments
- Assets/Prefabs — static 3D models used by the scenes
- Assets/Resources — supporting assets
- ProjectSettings/ProjectVersion.txt — Unity Editor version used for the project

Unity Editor version (from ProjectSettings): m_EditorVersion: 6000.2.7f2

Note: experiment pages/descriptions are provided in the project (look under `Assets/` for text or scene descriptions).

## Requirements

- Unity Editor (see ProjectSettings/ProjectVersion.txt above for the version used to create this project)
- Vuforia Engine package (installable via Unity Package Manager)
- A Vuforia license key (you can get a free developer key from the Vuforia Developer Portal)
- A webcam for Editor preview or a mobile device (Android / iOS) for on-device testing

## How to run (Editor)

1. Open this project in Unity.
2. Open Window → Package Manager and ensure Vuforia Engine (or Vuforia Engine AR) is installed.
3. In the Project window, open a scene from `Assets/Scenes`.
4. Configure Vuforia: open the Vuforia Configuration (search in Project Settings or check `Assets/Editor`/`Vuforia` settings) and add your license key.
5. For Editor preview: configure a webcam in Vuforia Play Mode settings (if not using a webcam, build to device).
6. Press Play. Point the webcam at the printed image target (or a second screen showing the target) to see the model appear.

## How to run (on device)

1. Follow the normal Unity build steps for Android or iOS.
2. In the AR scene, ensure the ARCamera prefab (with Vuforia behaviour) and ImageTarget prefab(s) are present and correctly configured.
3. Build & install the app on a device. Give camera permissions when prompted.
4. Point the device camera at the printed image target to view the 3D model.

Tip: print the image target at the correct size for more accurate tracking. The image target files are in the project (search `Assets/` for image assets used by the ImageTarget prefabs).

## Limitations & roadmap

- Static models only: the 3D models are non-interactive and have no animations.
- Tracking is jittery
- Planned improvements:
	- Add basic interactions (rotate/scale/touch info)
	- Add small guided quizzes and measurement overlays
	- Improve tracking robustness and add alternate targets
	- Add explicit per-experiment README pages and metadata

## Contributing

Contributions, fixes and suggestions are welcome. Suggested workflow:

1. Fork the repository and create a feature branch.
2. Make changes with clear commit messages.
3. Open a pull request describing what you changed and why.

Please include device/Unity version information with any bug reports.

## Troubleshooting

- Model doesn't appear:
	- Make sure your Vuforia license key is present and valid.
	- Confirm the ImageTarget prefab references the correct image/trackable.
	- Check camera permissions on the device.
	- In Editor, verify Play Mode is set to use your webcam or that Play Mode simulation is enabled.
## License & attribution

This project is licensed under the MIT License — see the `LICENSE` file in the repository root for full terms and attribution.

Copyright © 2025 Shahriar Shihab

