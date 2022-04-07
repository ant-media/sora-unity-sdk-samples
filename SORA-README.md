# Sora Unity SDK

[![libwebrtc](https://img.shields.io/badge/libwebrtc-m87.4280-blue.svg)](https://chromium.googlesource.com/external/webrtc/+/branch-heads/4280)
[![GitHub tag](https://img.shields.io/github/tag/shiguredo/sora-unity-sdk.svg)](https://github.com/shiguredo/sora-unity-sdk)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Actions Status](https://github.com/shiguredo/sora-unity-sdk/workflows/build/badge.svg)](https://github.com/shiguredo/sora-unity-sdk/actions)

Sora Unity SDK [WebRTC SFU Sora](https://sora.shiguredo.jp/) A library for developing Unity client applications for.

## About Support

We check PRs or Issues only when written in ENGLISH.
In other languages, we won't be able to deal with them. Thank you for your understanding.

## About AntMedia's open source software

Before use https://github.com/ant-media/sora-unity-sdk-samples Please read.

## How to use

Sora Unity SDK For those who want to use [README.md](SORA-README.md) Please read.

## How to build

- How to build with Windows please read[BUILD_WINDOWS.md](doc/BUILD_WINDOWS.md)
- How to build with macOS please read[BUILD_MACOS.md](doc/BUILD_MACOS.md) 

## sample

[AntMedia/sora\-unity\-sdk\-samples: WebRTC SFU Sora Unity SDK Sample collection](https://github.com/ant-media/sora-unity-sdk-samples)

### Sample operation example

- [ "It is now possible to distribute Unity camera images via WebRTC like this https://t\.co/R98ZmZTFOK" / Twitter](https://twitter.com/melponn/status/1193406538494275592?s=20)
- ["It's delivered in real time properly (I'm moving it from the scene editor because it was troublesome to make motion)。Unity The side is delivering and receiving with the browser (upper right)。 https://t\.co/TIL7NYroZm」 / Twitter](https://twitter.com/melponn/status/1193411591183552512?s=20)
- [「Momo (on Jetson Nano) -> Sora-Labo -> Sora-Unity And Sora-Js simultaneous reception. This is too easy and dangerous.  / Twitter](https://twitter.com/izmhrats/status/1203299775354851328?s=20)

## Supported Unity versions

- Unity 2019.1
- Unity 2019.2
- Unity 2019.3
- Unity 2019.4
- Unity 2020.1

## Supported platforms

- Windows 10 1809 x86_64 以降
- macOS 10.15 x86_64 以降
- Android 7 以降
- iOS 10 以降

## Corresponding function

--Support for Windows
--Support for macOS
--Compatible with Android
--iOS compatible
--Get Unity camera footage and send with Sora
--Get video from camera and send to Sora
--Get video from camera and output to Unity app
--Get audio from microphone and send to Sora
--Get audio from microphone and output to Unity app
--Receive audio from Sora in Unity app
--Receive video from Sora with the Unity app
--Play audio from Sora in Unity app
--Software encoding / decoding Support for VP8 / VP9
--Support for Opus
--Device specification function
--Audio output from Unity instead of microphone
--Supports video acquisition from Unity camera
--Supports playback of audio received on the Unity side
--Output the audio received from Sora to the Unity app
--Output the video received from Sora to the Unity app
--Support for Sora multi-stream function
--Correspondence to Sora signaling notification
--Support for Sora metadata
--Supports audio codec / bit rate specification at the start of Sora signaling
--Supports video codec / bit rate specification at the start of Sora signaling
--Correspondence to signaling notification

- Apple VideoToolbox
    --Support for H.264 hardware encoding
    --Support for H.264 hardware decoding
- NVIDIA VIDEO CODEC SDK
    - Windows Version
       --Support for H.264 hardware encoding
       --Support for H.264 hardware decoding

##  About the use of H.264

H.264 encoding / decoding is not available in software with the Sora Unity SDK.
This is because if you distribute the software including the H.264 software encoder / decoder, you will be charged a license fee, so it is disabled.

Therefore, H.264 encoding / decoding is realized by using NVIDIA VIDEO CODEC SDK on Windows and VideoToolbox on macOS. Android also uses the H.264 hardware encoder.

Read H.264 [USE_H264.md] (doc / USE_H264.md) for more information

## from now on

- Simulcast compatible

## Priority implementation for a fee

--Supports H.264 encoder by NVIDIA VIDEO CODEC SDK for Windows
    -[Sloth Networks Co., Ltd.] (http://www.sloth-networks.co.jp)
--Compatible with WebRTC's Statistics
    --Company name private
--Supports H.264 decoder by NVIDIA VIDEO CODEC SDK for Windows
    -[Sloth Networks Co., Ltd.] (http://www.sloth-networks.co.jp)
--Compatible with Android version
    -[KDDI Technology Corporation] (https://kddi-tech.com/)

## List of functions that can be preferentially implemented for a fee

** Please contact us by Discord or email for details **

--Assuming release in open source
--Publication of company name if possible
--If it is difficult to publish, we will write `company name private`.

### platform

-Support for Ubuntu 18.04

### NVIDIA VIDEO CODEC SDK

--Support for VP8 hardware decoding
--Support for VP9 hardware decoding
--Support for Ubuntu 18.04

### Supports INTEL Media SDK

--Support for H.264 hardware encoding
--Support for VP8 hardware encoding
--Support for VP9 hardware encoding
--Support for H.264 hardware decoding
--Support for VP8 hardware decoding
--Support for VP9 hardware decoding

## license

Apache License 2.0

```
Copyright 2019-2020, Wandbox LLC (Original Author)
Copyright 2019-2020, Shiguredo Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```
