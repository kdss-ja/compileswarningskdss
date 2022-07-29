/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.Postioning.V1.idl
using RTI Code Generator (rtiddsgen) version 3.1.0.
The rtiddsgen tool is part of the RTI Connext DDS distribution.
For more information, type 'rtiddsgen -help' at a command shell
or consult the Code Generator User's Manual.
*/

using System;
using System.Runtime.InteropServices;
using Omg.Types;
using Omg.Types.Dynamic;
using Rti.Types;
using Rti.Dds.Core;
using Rti.Types.Dynamic;
using Rti.Dds.NativeInterface.TypePlugin;

namespace Komatsu
{

    namespace Machine
    {

        namespace EquipmentPositioningV1
        {

            namespace Message
            {

                namespace Implementation
                {
                    public struct EquipmentPositioningUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.EquipmentPositioningV1.Message.EquipmentPositioning>
                    {

                        private NativeString TimeUtc;
                        private Komatsu.Machine.SharedV1.Type.MachineTypeEnum MachineType;
                        private Komatsu.Machine.SharedV1.Type.Implementation.MachinePositionCoordinatesUnmanaged Position;
                        private NativeManagedOptional Orientation;
                        private NativeManagedOptional GPSQuality;
                        private NativeUnmanagedOptional Speed;
                        private NativeUnmanagedOptional Heading;

                        public void Destroy(bool optionalsOnly)
                        {
                            Position.Destroy(optionalsOnly);
                            Orientation.Destroy<Komatsu.Machine.SharedV1.Type.MachineOrientation, Komatsu.Machine.SharedV1.Type.Implementation.MachineOrientationUnmanaged>(optionalsOnly);
                            GPSQuality.Destroy<Komatsu.Machine.SharedV1.Type.GPSQualityData, Komatsu.Machine.SharedV1.Type.Implementation.GPSQualityDataUnmanaged>(optionalsOnly);
                            Speed.Destroy(optionalsOnly);
                            Heading.Destroy(optionalsOnly);
                            if (optionalsOnly)
                            {
                                return;
                            }
                            TimeUtc.Destroy();
                        }

                        public void FromNative(Komatsu.Machine.EquipmentPositioningV1.Message.EquipmentPositioning sample, bool keysOnly = false)
                        {

                            sample.TimeUtc = TimeUtc.FromNative();
                            sample.MachineType = MachineType;
                            Position.FromNative(sample.Position, keysOnly: false);
                            Orientation.FromNative<Komatsu.Machine.SharedV1.Type.MachineOrientation, Komatsu.Machine.SharedV1.Type.Implementation.MachineOrientationUnmanaged>(out var OrientationTemporary_);
                            sample.Orientation = OrientationTemporary_;
                            GPSQuality.FromNative<Komatsu.Machine.SharedV1.Type.GPSQualityData, Komatsu.Machine.SharedV1.Type.Implementation.GPSQualityDataUnmanaged>(out var GPSQualityTemporary_);
                            sample.GPSQuality = GPSQualityTemporary_;
                            sample.Speed = Speed.FromNative<double>();
                            sample.Heading = Heading.FromNative<double>();
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            TimeUtc.Initialize(size: ((int) 30), allocateMemory: allocateMemory);
                            MachineType = (Komatsu.Machine.SharedV1.Type.MachineTypeEnum) 0;
                            Position.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.EquipmentPositioningV1.Message.EquipmentPositioning sample, bool keysOnly = false)
                        {
                            TimeUtc.ToNative(sample.TimeUtc, ((int) 30));
                            MachineType = sample.MachineType;
                            Position.ToNative(sample.Position, keysOnly: false);
                            Orientation.ToNative<Komatsu.Machine.SharedV1.Type.MachineOrientation, Komatsu.Machine.SharedV1.Type.Implementation.MachineOrientationUnmanaged>(sample.Orientation);
                            GPSQuality.ToNative<Komatsu.Machine.SharedV1.Type.GPSQualityData, Komatsu.Machine.SharedV1.Type.Implementation.GPSQualityDataUnmanaged>(sample.GPSQuality);
                            Speed.ToNative<double>(sample.Speed);
                            Heading.ToNative<double>(sample.Heading);
                        }
                    }

                    internal class EquipmentPositioningPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.EquipmentPositioningV1.Message.EquipmentPositioning, EquipmentPositioningUnmanaged>
                    {
                        internal EquipmentPositioningPlugin() : base("Komatsu.Machine.EquipmentPositioningV1.Message.EquipmentPositioning", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // EquipmentPositioning struct
                            var EquipmentPositioningStructMembers = new StructMember[]
                            {
                                new StructMember("TimeUtc", dtf.CreateString(((int) 30)), id: 0),
                                new StructMember("MachineType", Komatsu.Machine.SharedV1.Type.MachineTypeEnumSupport.Instance.GetDynamicTypeInternal(isPublic), id: 1),
                                new StructMember("Position", Komatsu.Machine.SharedV1.Type.MachinePositionCoordinatesSupport.Instance.GetDynamicTypeInternal(isPublic), id: 2),
                                new StructMember("Orientation", Komatsu.Machine.SharedV1.Type.MachineOrientationSupport.Instance.GetDynamicTypeInternal(isPublic), isOptional: true, id: 3),
                                new StructMember("GPSQuality", Komatsu.Machine.SharedV1.Type.GPSQualityDataSupport.Instance.GetDynamicTypeInternal(isPublic), isOptional: true, id: 4),
                                new StructMember("Speed", dtf.GetPrimitiveType<double>(), isOptional: true, id: 5),
                                new StructMember("Heading", dtf.GetPrimitiveType<double>(), isOptional: true, id: 6)
                            };

                            return tsf.CreateTypeWithAccessInfo<EquipmentPositioningUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::EquipmentPositioningV1::Message::EquipmentPositioning")
                                .AddMembers(EquipmentPositioningStructMembers));
                        }
                    }
                }

                public class EquipmentPositioningSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.EquipmentPositioningV1.Message.EquipmentPositioning>
                {
                    public EquipmentPositioningSupport() : base(
                        new Implementation.EquipmentPositioningPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.EquipmentPositioningPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static EquipmentPositioningSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<EquipmentPositioningSupport, Komatsu.Machine.EquipmentPositioningV1.Message.EquipmentPositioning>();
                }

            } // namespace Message

        } // namespace EquipmentPositioningV1

    } // namespace Machine

} // namespace Komatsu

