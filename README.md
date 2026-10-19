# Simple AR – HND Y2 Game Technology 3 starter project

Steps 1–10 of the setup sheet are already done in this project. Open it, switch to Android, plug in your phone, Build And Run.

## Open it
1. Unzip somewhere with a short path (e.g. `C:\Unity\HND_SimpleAR`).
2. Unity Hub → **Add → Add project from disk** → pick the `HND_SimpleAR` folder.
3. Made for **Unity 6000.0.70f1 (Unity 6 LTS)** with **Android Build Support** installed. Any newer Unity 6 version is fine too, just accept the upgrade prompt.
4. The first time you open it, Unity downloads the packages and builds the Library folder. This takes a few minutes.
5. Open `Assets/Scenes/ARScene.unity`.

## What's already set up
| Sheet step | Done |
|---|---|
| 2 Packages | AR Foundation 6.0.8, Google ARCore XR Plugin 6.0.8, Input System |
| 3 ARCore | XR Plug-in Management → Android → ARCore ticked |
| 4 Input | Player → Active Input Handling = **Both** |
| 5 Scene | `AR Session` + `XR Origin (Mobile AR)` → `Camera Offset` → `Main Camera` (AR Camera) |
| 6 Managers | AR Plane Manager (uses `Prefabs/AR Default Plane`) + AR Raycast Manager on the XR Origin |
| 7 Game manager | `ARGameManager` with ARTapToPlace (Raycast/Plane managers assigned) + ARTouchInteractor (AR Camera assigned) |
| 8–9 Prefab | `Prefabs/ARGameRoot` (Environment, Player, Targets, Enemies, Spawners, GameManager), assigned to **Game Prefab** |
| 10 Test object | `ARGameRoot/Targets/TestTarget`: a sphere with a SphereCollider, ARTappable and TestTarget. **On Tap()** calls `TestTarget.HitTarget()` |
| Android player | IL2CPP, ARM64, min API 24, OpenGLES3, scene added to the build |

## Step 11: build to your phone
1. On the phone: turn on Developer Options and USB Debugging, then connect it by USB.
2. **File → Build Profiles** → Android → **Switch Platform**.
3. Click **Build And Run**.
4. On the phone: move it slowly over a well-lit table or floor until a plane appears. Tap the plane to place ARGameRoot, then tap the red sphere. It disappears and the log shows `AR Target Hit!` (you can read the log in Window → Analysis → Android Logcat).

## Step 12: make your game
Keep `Scripts/AR/*` as the supplied technology. Open `Prefabs/ARGameRoot` and build your mechanics inside it. 1 unit = 1 metre in real life, so the board is 60 cm across.
