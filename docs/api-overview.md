# API overview

> Instructions relevant for Pimax SDK version 1.1.2

Scriping interfaces:
* PVRSession.cs 
* PVRInputEvent.cs 

## (1) PVRSession.cs

Used to access the connection with PVR runtime. You only need to add one in each scene and you can use the PVRSession.prefab to add it.

#### instance
| Name | public static PVRSession instance |
| :---: | :----: |
| Purpose | Static reference to PVRSession instance. Should be used to access all PVRSession data. |
| Returns | PVRSession instance |
| Call Method | PVR.Unity.PVRSession.instance; |

#### TrackingOrig
| Name | public enum TrackingOrig |
| :---: | :----: |
| Values | eye, floor |
| Call Method | PVR.Unity.PVRSession.instance.TrackingOrig; |

#### trackingOrig
| Name | public TrackingOrig trackingOrig |
| :---: | :----: |
| Purpose | Defines tracking origin |
| Expected values | TrackingOrig enumerator: eye, floor |
| Call Method | PVR.Unity.PVRSession.instance.trackingOrig; |

#### ready
| Name | public bool ready |
| :---: | :----: |
| Purpose | Used to indicate if PVRSession is initilized |
| Returns | Is ready |
| Call Method | PVR.Unity.PVRSession.instance.ready; |

#### errorMsg
| Name | public string errorMsg |
| :---: | :----: |
| Purpose | Used to retrive error outputs |
| Returns | Message string in English |
| Call Method | PVR.Unity.PVRSession.instance.errorMsg; |

#### client
| Name | public PVRClient client |
| :---: | :----: |
| Purpose | Used to retrive pimax client |
| Returns | active PVRClient |
| Call Method | PVR.Unity.PVRSession.instance.client; |

#### headPoseState
| Name | public pvrPoseStatef headPoseState |
| :---: | :----: |
| Purpose | Used to retrive head pose |
| Returns | Head pose |
| Call Method | PVR.Unity.PVRSession.instance.headPoseState; |

#### handsPoseState
| Name | public pvrPoseStatef[] headPoseState |
| :---: | :----: |
| Purpose | Used to retrive hand poses |
| Returns | Array of two pvrPoseStatef |
| Call Method | PVR.Unity.PVRSession.instance.handsPoseState; |

#### eyePose
| Name | public pvrPosef[] headPoseState |
| :---: | :----: |
| Purpose | Used to retrive eye poses |
| Returns | Array of two pvrPoseStatef |
| Call Method | PVR.Unity.PVRSession.instance.eyePose; |

#### renderTargetSize
| Name | public pvrSizei renderTargetSize |
| :---: | :----: |
| Purpose | Used to retrive render target size |
| Returns | Size of the screen in pixels |
| Call Method | PVR.Unity.PVRSession.instance.renderTargetSize; |

#### hmdToEyePose
| Name | public pvrPosef[] hmdToEyePose |
| :---: | :----: |
| Purpose | Used to retrive eye offsets |
| Returns | Array of two pvrPosef |
| Call Method | PVR.Unity.PVRSession.instance.hmdToEyePose; |

#### inputState
| Name | public pvrInputState inputState |
| :---: | :----: |
| Purpose | Used to retrive full list of button and joystick states |
| Returns | Active input state |
| Call Method | PVR.Unity.PVRSession.instance.inputState; |

#### trackingOrigin
| Name | public pvrTrackingOrigin trackingOrigin |
| :---: | :----: |
| Purpose | Alters tracking origin if PVRSession is ready |
| Sets | Attempts to set tracking origin |
| Returns | Tracking origin, defaults to eye level if not ready |
| Call Method | PVR.Unity.PVRSession.instance.trackingOrigin; |

#### recenterTrackingOrigin()
| Name | public void recenterTrackingOrigin () |
| :---: | :----: |
| Functionality | Recenters users direction |
| Parameters | None |
| Returns | None |
| Call Method | PVR.Unity.PVRSession.instance.recenterTrackingOrigin(); |

#### triggerHapticPulse()
| Name | public void triggerHapticPulse ( int hand, float intensity ) |
| :---: | :----: |
| Functionality | Created controller vibration in a specific hand and strength. |
| Parameters | Hand: 0 = left hand, otherwise right hand. Intensity increases power. |
| Returns | None |
| Call Method | PVR.Unity.PVRSession.instance.triggerHapticPulse(int, float); |

#### GetEyeProjectionMatrix()
| Name | public pvrMatrix4f GetEyeProjectionMatrix ( pvrEyeType eye ) |
| :---: | :----: |
| Functionality | Get eye projection as a 4x4 matrix |
| Parameters | eye: enumerator of which eye to use |
| Returns | pvrMatrix4f of projection matrix |
| Call Method | PVR.Unity.PVRSession.instance.GetEyeProjectionMatrix(pvrEyeType); |

#### GetFovPort()
| Name | public pvrFovPort GetEyeProjectionMatrix ( pvrEyeType eye ) |
| :---: | :----: |
| Functionality | Get render information as a pvrFovPort |
| Parameters | eye: enumerator of which eye to use |
| Returns | pvrFovPort of render information |
| Call Method | PVR.Unity.PVRSession.instance.GetFovPort(pvrEyeType); |

#### RegisterColorBuffer()
| Name | public static void RegisterColorBuffer ( IntPtr colorBuffer ) |
| :---: | :----: |
| Functionality | If a renderLibrary is present register a color buffer |
| Parameters | colorBuffer: color buffer to action |
| Returns | None |
| Call Method | PVR.Unity.PVRSession.RegisterColorBuffer(IntPtr); |

#### UnRegisterColorBuffer()
| Name | public static void UnRegisterColorBuffer ( IntPtr colorBuffer ) |
| :---: | :----: |
| Functionality | If a renderLibrary is present unregister a color buffer |
| Parameters | colorBuffer: color buffer to action |
| Returns | None |
| Call Method | PVR.Unity.PVRSession.UnRegisterColorBuffer(IntPtr); |

#### SubmitEyeLayer()
| Name | public void SubmitEyeLayer ( int layer_uid, pvrEyeType eye, IntPtr colorBuffer, bool headLocked ) |
| :---: | :----: |
| Functionality | If a renderLibrary is present submit an eye layer with the specified paramiters |
| Parameters | layer_uid: layer to action, eye: eye array data to use, colorBuffer: coloruffer, headLocked: used locked head |
| Returns | None |
| Call Method | PVR.Unity.PVRSession.instance.SubmitEyeLayer(int, pvrEyeType, IntPtr, bool); |

#### IsButtonInPress()
| Name | public bool IsButtonInPress ( int hand, PVR.pvrButton btn ) |
| :---: | :----: |
| Functionality | Get the pressed status of the specified input and hand |
| Parameters | hand: 0 = left, 1 = right. btn: input to poll |
| Returns | Button pressed state |
| Call Method | PVR.Unity.PVRSession.instance.IsButtonInPress(int, PVR.pvrButton); |

#### IsButtonInTouch()
| Name | public bool IsButtonInTouch ( int hand, PVR.pvrButton btn ) |
| :---: | :----: |
| Functionality | Get the touched status of the specified input and hand |
| Parameters | hand: 0 = left, 1 = right. btn: input to poll |
| Returns | Button touched state |
| Call Method | PVR.Unity.PVRSession.instance.IsButtonInTouch(int, PVR.pvrButton); |

#### GetButtonAxis()
| Name | public pvrVector2f GetButtonAxis ( int hand, PVR.pvrButton btn ) |
| :---: | :----: |
| Functionality | Get the axis state of the specified input and hand |
| Parameters | hand: 0 = left, 1 = right. btn: input to poll |
| Returns | 0.0f to 1.0f if a button is only on or off. Single axis inputs like triggers and grips return 0.0f to 1.0f along the X  input axis. Two axis inputs like thumbsticks and touchpads return along X and Y |
| Call Method | PVR.Unity.PVRSession.instance.GetButtonAxis(int, PVR.pvrButton); |

#### isDeviceConnected()
| Name | public bool isDeviceConnected ( pvrTrackedDeviceType device ) |
| :---: | :----: |
| Functionality | Test specified device against connected devices |
| Parameters | device: device type |
| Returns | Is the specified device connected |
| Call Method | PVR.Unity.PVRSession.instance.isDeviceConnected(pvrTrackedDeviceType); |

## (2) PVRInputEvent.cs

Used to access the state of input events.

#### IPVRInputEventTarget
| Name | public interface IPVRInputEventTarget : IEventSystemHandler |
| :---: | :----: |
| Inherited function | Description |
| :---: | :----: |
| void OnButtonPress (PVRButtonEventData data) | Event called when button pressed |
| void OnButtonRelease (PVRButtonEventData data) | Event called when button released |
| void OnButtonTouch (PVRButtonEventData data) | Event called when button touched |
| void OnButtonUntouch (PVRButtonEventData data) | Event called when button untouched |
| void OnAxisChange (PVRButtonEventData data) | Event called when axis updated |

### Next: Understanding PiTool

See [Understanding PiTool](/docs/pitool-guide.md)
