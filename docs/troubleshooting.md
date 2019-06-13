# Troubleshooting

Commonly encountered issues for Pimax projects, and how to solve them.

#### My Pimax device does not turn on, or has a red light displayed.

Pimax relies on an external power source, unlike many other VR headsets. Ensure that all connections are fuly plugged in, all sockets are active, and the power button has been pressed. For developers who are experienced with other platforms this can be an easy oversight.

#### My Pimax device only shows a Pimax splash screen, without any head tracking.

Ensure that SteamVR is enabled, with correctly set up sensors and that the HMD icon in steam shows a Pimax logo.

<p align="center">
  <img alt="Pimax Logo" width="500px" src="/assets/PimaxSteamLogo.png">
</p>

This issue can commonly occurs when Graphics card drivers are out of date. Pimax relies on relativly recent software, and it is worth updating your graphics card drivers and performing a full system restart to attempt to solve issues on first-time startup.

#### My Pimax device is very demanding on my computers hardware, even when running a simple VR experience.

If your computer can normally run VR experiences without issue, but struggles to show the Pimax home screen, you may want to adjust the display quality settings in PiTools.

From the PiTools window select **Settings > HMD > Rendering Quality**. Lowering this value will improve performance overall. Other settings within the same window can be used to adjust more specific issues with the display, such as screen tearing or latency delay.

<p align="center">
  <img alt="Pimax Logo" width="500px" src="/assets/RenderQuality.png">
</p>

### Next: Optimizing Pimax experiences

See [Optimizing Pimax experiences](/docs/optimizing-pimax-experiences.md)
