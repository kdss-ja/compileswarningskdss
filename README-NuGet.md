# Komatsu Machine Digital Twin KDDS API

This package contains the pre-compiled KDDS IDL data transfer objects for the Komatsu Machine Digital Twin API.

## Positioning API

| KDDS Profile | Value |
| ----------- | ----------- |
| Pattern                       | Publish / Subscribe
| DomainID                      | 2  (KDDS_DEBUG_LOCAL)
| DomainParticipantQoS          | KomatsuDDSInternalLibrary::KomatsuAppUnsecureParticipant
| QoS                           | KomatsuDDSLibrary::Regular
| Topic                         | Machine/DigitalTwin/Positioning
| Publish Frequency             | 1Hz
| Message Data Transfer Object  | EquipmentPositioning

**Example :**
```C#
subscriberPositioning = new DdsSubscriber<EquipmentPositioning>(
    (int)KomatsuDomainID.KDDS_DEBUG_LOCAL,
    "Machine/DigitalTwin/Positioning",
    "KomatsuDDSLibrary::Regular",
    "KomatsuDDSInternalLibrary::KomatsuAppUnsecureParticipant"
);

subscriberPositioning.AddSubscriber(MachinePositioning_OnMessageReceived);
subscriberPositioning.Activate();
```

---
<br><br>

## Guidance API

| KDDS Profile | Value |
| ----------- | ----------- |
| Pattern                       | Publish / Subscribe
| DomainID                      | 2  (KDDS_DEBUG_LOCAL)
| DomainParticipantQoS          | KomatsuDDSInternalLibrary::KomatsuAppUnsecureParticipant
| QoS                           | KomatsuDDSLibrary::Regular
| Topic                         | Machine/DigitalTwin/Guidance
| Publish Frequency             | 5Hz
| Message Data Transfer Object  | LoadingUnitGuidance

**Example :**
```C#
subscriberGuidance = new DdsSubscriber<LoadingUnitGuidance>(
    (int)KomatsuDomainID.KDDS_DEBUG_LOCAL,
    "Machine/DigitalTwin/Guidance",
    "KomatsuDDSLibrary::Regular",
    "KomatsuDDSInternalLibrary::KomatsuAppUnsecureParticipant"
);

subscriberGuidance.AddSubscriber(MachineGuidance_OnMessageReceived);
subscriberGuidance.Activate();
```

---
<br><br>

## Machine Geometry API

| KDDS Profile | Value |
| ----------- | ----------- |
| Pattern                       | Request / Reply
| DomainID                      | 2  (KDDS_DEBUG_LOCAL)
| DomainParticipantQoS          | KomatsuDDSInternalLibrary::KomatsuAppUnsecureParticipant
| QoS                           | KomatsuDDSLibrary::Regular
| Topic                         | Machine/DigitalTwin/Geometry
| Request Message               | LoadingUnitConfig
| Reply Message                 | LoadingUnitConfig

**Example :**
```C#
GeometryRequester = new DdsRequester<LoadingUnitConfig, LoadingUnitConfig>(
    (int)KomatsuDomainID.KDDS_DEBUG_LOCAL,
    "Machine/DigitalTwin/Geometry",
    "KomatsuDDSLibrary::Regular",
    "KomatsuDDSInternalLibrary::KomatsuAppUnsecureParticipant");

GeometryRequester.Activate();

var reply = GeometryRequester.Request(new LoadingUnitConfig());

switch (reply.Geometry.Discriminator)
{
    case MachineTypeEnum.ELECTRIC_SHOVEL:
        var geomPoint = reply.Geometry.ElectricShovelGeometry.crowdPivotX;
        break;

    case MachineTypeEnum.HYDRAULIC_EXCAVATOR:
        var geomPoint = reply.Geometry.HydraulicExcavatorGeometry.boomPositionX;
        break;

    case MachineTypeEnum.HYDRAULIC_SHOVEL:
        var geomPoint = reply.Geometry.HydraulicShovelGeometry.boomPositionX;
        break;
}
```

---
<br><br>

## System Health API

| KDDS Profile | Value |
| ----------- | ----------- |
| Pattern                       | Publish / Subscribe
| DomainID                      | 2  (KDDS_DEBUG_LOCAL)
| DomainParticipantQoS          | KomatsuDDSInternalLibrary::KomatsuAppUnsecureParticipant
| QoS                           | KomatsuDDSLibrary::Regular
| Topic                         | Machine/DigitalTwin/Guidance_status
| Publish Frequency             | 1Hz
| Message Data Transfer Objects | StatusMessage <br> GuidanceStatusMessage


**Example :**
```C#
subscriberStatus = new DdsSubscriber<StatusMessage>(
    (int)KomatsuDomainID.KDDS_DEBUG_LOCAL,
    "Machine/DigitalTwin/Guidance_status",
    "KomatsuDDSLibrary::Regular",
    "KomatsuDDSInternalLibrary::KomatsuAppUnsecureParticipant"
);

subscriberStatus.AddSubscriber(MachineGuidance_OnStatusMessageReceived);
subscriberStatus.Activate();

subscriberGuidanceStatus = new DdsSubscriber<GuidanceStatusMessage>(
    (int)KomatsuDomainID.KDDS_DEBUG_LOCAL,
    "Machine/DigitalTwin/Guidance_status",
    "KomatsuDDSLibrary::Regular",
    "KomatsuDDSInternalLibrary::KomatsuAppUnsecureParticipant"
);

subscriberGuidanceStatus.AddSubscriber(MachineGuidance_OnGuidanceStatusMessageReceived);
subscriberGuidanceStatus.Activate();
```