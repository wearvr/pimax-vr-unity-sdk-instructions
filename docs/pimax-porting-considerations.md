# Porting considerations

Pimax is an unique platform to develop for, in comparison to other desktop VR SDKs. It's ability to use hardware from other platforms, it's high specifications, and reliance on PiTool present some important considerations when attempting to change a project designed for any other platform into a Pimax product.

### Input

Pimax is dependent on PVRInputEvent.cs for it's Input, [which is covered here](/docs/pimax-controllers.md). This system presents some issues, as replacing the input hooks for a completed project can be a large task. In general it is recommended that developers create their own Input interface to keep track of button states using the Pimax system, as well as parse out other useful information such as testing touchpad swipe directions or detecting long button presses.

As well as using PVRInputEvent, it may be possible to query PVRSession for input states. This could be a useful alternative to those preffering not to use event-driven input. See the [API section for more details](/docs/api-overview.md).

Games ported from the Oculus may have difficulty as 'Near press' input results, and dedicated face buttons, all are not present on the Vive or Pimax. Most developers consider using touchpad click locations to create virtual buttons as an acceptable alternative to physical buttons.

### Build settings

Pimax does not require a VR SDK to be enabled under In 'Edit->Project Settings->Player->Other Settings'. The 'VR Enabled' checkbox under the same XR settings area also does not have to be enabled. If you are working with a project that previously used VR it is worth ensuring that these settings are disabled, and that no Editor code is re-enabling them at buildtime (As other VR SDKs might often do).

Pimax can run with other VR SDKs enabled, such as OpenVR. In some cases this will not cause issues, but if you intend for your project to be exclusively played on the Pimax it is best to limit unexpected issues by disabling any other VR SDKs.

### FOV (Felid of view)

Pimax has a wider FOV than any of it's competitors currently on the market. This can cause minor visual glitches in the users peripheral vision, such as objects appearing and disappearing due to frustum culling.

Here are the specifications on current VR headsets, for quick reference:

| Device | HxV FOV |
| :---: | :----: |
| Pimax 8k | 200° x 110° |
| Pimax 5k | 170° x 110° |
| Oculus CV1 | 88° x 90° |
| Vive Pro | 110° x 110° |
| Windows Mixed Reality | 95° x 90° |

## Alternatively, use the Vive SDK, VivePort or OpenVR.

As Pimax is compatible with the Vive by default it is also a completely valid strategy to develop using Viveport or the SteamVR SDK. For some developers who have games already compatible with the Vive it will be much more appealing to make minor adjustments to make their game 'Pimax friendly' as opposed to developing for Pimax exclusively.

One of the largest concerns is with FOV (Felid of view). As the Pimax has wider screens than the vive it is common for visual issues to occur in the users peripheral vision if a VR experience has not been correctly set up for Pimax. Objects may appear to pop in and out of vision due to frustum culling, or UI elements such as 'fade out boxes' or vision overlays might not stretch to the edges of a users vision correctly.

Additionally as the Pimax has a larger screen in comparison to the Vive, and has some overhead in rendering to it's two screens and running PiTool, it is common for applications to run slower on PiMax than on other headsets. This can be mitigated with more powerful hardware, or optimization, but a game that has already shown some difficulty with performance will likely require further optimization to work seamlessly with PiMax.

If you are developing a Pimax experience using a Vive-only SDK you may need to enable **'Compatible With Vive Only Game'** under PiTools **'Settings > Brainwarp > Compatible With vive Only Game'** menu.

### Next: Troubleshooting

See [Troubleshooting](/docs/troubleshooting.md)
