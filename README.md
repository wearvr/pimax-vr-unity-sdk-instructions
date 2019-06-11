# Pimax Unity SDK Instructions

> These instructions are relevant to PVR SDK version 1.1.2

Instructions for how to create new Unity virtual reality experiences for the Pimax (or port existing ones).

These guides primarily target the Pimax 5k Headset for desktop applications and games, although other devices using the same SDK will generally be supported. For controllers and base stations this documentation and example projects will be working from the HTC vive and SteamVR.

<p align="center">
  <img alt="P1 Headset" width="500px" src="/docs/assets/Pimax 5K.svg">
</p>

## Pimax Headsets

#### Support & Revenue share

WEARVR.com, The world's largest independent VR app store, has partnered with Pimax Technology to provide distribution alongside promotion, technical support and advice to help get your content into the marketplace - at no cost to you. You get the same high revenue share of 75%.

| Region | Developer Revenue Share |
| :---: | :----: |
| Worldwide | 75% |

WEARVR offers the largest independent marketplace for VR content, and one of the only places that distributes products exclusively developed for the Pimax headset.

#### Specifications

View the [full headset specifications](https://www.wearvr.com/developer-center/devices/pimax).

> TODO: Website needs to be updated

## Prerequisites

You will require the following in order to develop a Pimax application:

A compatible version of Unity (based on Vive SDK requirements):
> TODO: Consider confirming with Pimax to get more accurate specs
* Unity3D 5.4 series through to Unity 2018 are supported.

A Pimax device:

* These guides assume the developer is working with a Pimax 5k device. Other versions may have specific requirements, but should be similar to develop for unless noted otherwise.

A Pimax asset package compatible with your device and Unity version:
> TODO: Update the website to include the latest SDK
<a href="https://users.wearvr.com/developers/devices/pimax/resources/vr-unity-package" target="_blank">Get the latest version here.</a>

## Overview

You can easily create a new Unity VR app, but the fastest way to get up and running on a Pimax device is to convert an existing Oculus, Vive, Windows Mixed Reality or Mobile VR experience.

* [Installing and configuring the Pimax SDK](/docs/pimax-vr-unity-sdk-installation.md)
* [Controller and headset inputs](/docs/pimax-controllers.md)
* [Building an executable](/docs/building-pimax-exe.md)

Optional:

* [Pimax sample scenes](/docs/pimax-sample-scenes-overview.md)
* [Compatibility](/docs/pimax-compatibility.md)
* [Porting considerations](/docs/pimax-porting-considerations.md)
* [Troubleshooting](/docs/troubleshooting.md)
* [Optimizing Pimax experiences](/docs/optimizing-pimax-experiences.md)
* [Overview of API](/docs/api-overview.md)

Device:

* [Understanding PiTool](/docs/pitool-guide.md)

There is an [example project](examples/Readme.md) to use as a reference as you follow this guide.

## Unable to port yourself?

Depending on availability and need, WEARVR may be able to provide additional support to help port your existing VR experiences to be compatible with Pimax, all the way up to completing the port for you and submitting it to the market.

Please get in touch on `devs@wearvr.com` to discuss your needs and how WEARVR may be able to help.

## Copyright & Trademarks

These instructions and example project are maintained by WEARVR LLC, The largest independent virtual reality app store. WEARVR is interested in connecting VR content creators and consumers, globally. We love working with the VR community and would be delighted to hear from you at `devs@wearvr.com`.

You can find more information about WEARVR at www.wearvr.com

The Pimax trademark, all Pimax virtual reality headsets and Pimax Unity SDK are all owned by [Pimax Technology](https://pimaxvr.com/).
