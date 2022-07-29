/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.Status.V1.Guidance.idl
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

        namespace StatusV1
        {

            namespace Guidance
            {

                namespace Type
                {

                    namespace Implementation
                    {
                        internal class GnssFixPlugin : Rti.Dds.NativeInterface.TypePlugin.EnumTypePlugin
                        {
                            public GnssFixPlugin() : base(CreateDynamicType(isPublic: false))
                            {
                            }

                            internal static DynamicType CreateDynamicType(bool isPublic = true)
                            {
                                var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                                return dtf.BuildEnum()
                                .WithName("Komatsu::Machine::StatusV1::Guidance::Type::GnssFix")
                                .AddMember(new EnumMember("INVALID", 0))
                                .AddMember(new EnumMember("FIX", 1))
                                .AddMember(new EnumMember("DGPS", 2))
                                .AddMember(new EnumMember("PPS", 3))
                                .AddMember(new EnumMember("RTK", 4))
                                .AddMember(new EnumMember("RTK_FLOAT", 5))
                                .AddMember(new EnumMember("ESTIMATED", 6))
                                .AddMember(new EnumMember("MANUAL", 7))
                                .AddMember(new EnumMember("SIMULATION", 8))
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .Create();
                            }
                        }
                    }

                    public class GnssFixSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.StatusV1.Guidance.Type.GnssFix>
                    {
                        public GnssFixSupport() : base(
                            new Implementation.GnssFixPlugin(),
                            new Lazy<DynamicType>(() =>Implementation.GnssFixPlugin.CreateDynamicType(isPublic: true)))
                        {
                        }

                        public static GnssFixSupport Instance { get; } =
                        ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GnssFixSupport, Komatsu.Machine.StatusV1.Guidance.Type.GnssFix>();
                    }

                    namespace Implementation
                    {
                        internal class KinematicSolutionQualityPlugin : Rti.Dds.NativeInterface.TypePlugin.EnumTypePlugin
                        {
                            public KinematicSolutionQualityPlugin() : base(CreateDynamicType(isPublic: false))
                            {
                            }

                            internal static DynamicType CreateDynamicType(bool isPublic = true)
                            {
                                var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                                return dtf.BuildEnum()
                                .WithName("Komatsu::Machine::StatusV1::Guidance::Type::KinematicSolutionQuality")
                                .AddMember(new EnumMember("NOT_AVAILABLE", 0))
                                .AddMember(new EnumMember("AVAILABLE", 1))
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .Create();
                            }
                        }
                    }

                    public class KinematicSolutionQualitySupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.StatusV1.Guidance.Type.KinematicSolutionQuality>
                    {
                        public KinematicSolutionQualitySupport() : base(
                            new Implementation.KinematicSolutionQualityPlugin(),
                            new Lazy<DynamicType>(() =>Implementation.KinematicSolutionQualityPlugin.CreateDynamicType(isPublic: true)))
                        {
                        }

                        public static KinematicSolutionQualitySupport Instance { get; } =
                        ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<KinematicSolutionQualitySupport, Komatsu.Machine.StatusV1.Guidance.Type.KinematicSolutionQuality>();
                    }

                    namespace Implementation
                    {
                        public struct GnssQualityInfoUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo>
                        {

                            private short NumberOfSatellites;
                            private Komatsu.Machine.StatusV1.Guidance.Type.GnssFix FixType;

                            public void Destroy(bool optionalsOnly)
                            {
                            }

                            public void FromNative(Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo sample, bool keysOnly = false)
                            {

                                sample.NumberOfSatellites = NumberOfSatellites;
                                sample.FixType = FixType;
                            }

                            public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                            {
                                NumberOfSatellites = (short) 0;
                                FixType = (Komatsu.Machine.StatusV1.Guidance.Type.GnssFix) 0;
                            }

                            public void ToNative(Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo sample, bool keysOnly = false)
                            {
                                NumberOfSatellites = sample.NumberOfSatellites;
                                FixType = sample.FixType;
                            }
                        }

                        internal class GnssQualityInfoPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo, GnssQualityInfoUnmanaged>
                        {
                            internal GnssQualityInfoPlugin() : base("Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo", isKeyed: false, CreateDynamicType(isPublic: false))
                            {
                            }

                            public static DynamicType CreateDynamicType(bool isPublic = true)
                            {
                                var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                                var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                                // GnssQualityInfo struct
                                var GnssQualityInfoStructMembers = new StructMember[]
                                {
                                    new StructMember("NumberOfSatellites", dtf.GetPrimitiveType<short>(), id: 0),
                                    new StructMember("FixType", Komatsu.Machine.StatusV1.Guidance.Type.GnssFixSupport.Instance.GetDynamicTypeInternal(isPublic), id: 1)
                                };

                                return tsf.CreateTypeWithAccessInfo<GnssQualityInfoUnmanaged>(
                                    dtf.BuildStruct()
                                    .WithExtensibility(ExtensibilityKind.Extensible)
                                    .WithName("Komatsu::Machine::StatusV1::Guidance::Type::GnssQualityInfo")
                                    .AddMembers(GnssQualityInfoStructMembers));
                            }
                        }
                    }

                    public class GnssQualityInfoSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo>
                    {
                        public GnssQualityInfoSupport() : base(
                            new Implementation.GnssQualityInfoPlugin(),
                            new Lazy<DynamicType>(() =>Implementation.GnssQualityInfoPlugin.CreateDynamicType(isPublic: true)))
                        {
                        }

                        public static GnssQualityInfoSupport Instance { get; } =
                        ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GnssQualityInfoSupport, Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo>();
                    }

                } // namespace Type

                namespace Message
                {

                    namespace Implementation
                    {
                        public struct GuidanceStatusMessageUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.StatusV1.Guidance.Message.GuidanceStatusMessage>
                        {

                            private Komatsu.Machine.StatusV1.Message.Implementation.StatusMessageUnmanaged parent;

                            private Komatsu.Machine.StatusV1.Guidance.Type.Implementation.GnssQualityInfoUnmanaged GnssQuality;
                            private Komatsu.Machine.StatusV1.Guidance.Type.KinematicSolutionQuality KinematicSolution;

                            public void Destroy(bool optionalsOnly)
                            {
                                parent.Destroy(optionalsOnly);
                                if (optionalsOnly)
                                {
                                    return;
                                }
                                GnssQuality.Destroy(optionalsOnly);
                            }

                            public void FromNative(Komatsu.Machine.StatusV1.Guidance.Message.GuidanceStatusMessage sample, bool keysOnly = false)
                            {

                                parent.FromNative(sample, keysOnly);
                                GnssQuality.FromNative(sample.GnssQuality, keysOnly: false);
                                sample.KinematicSolution = KinematicSolution;
                            }

                            public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                            {
                                parent.Initialize(allocatePointers, allocateMemory);
                                GnssQuality.Initialize(allocatePointers, allocateMemory);
                                KinematicSolution = (Komatsu.Machine.StatusV1.Guidance.Type.KinematicSolutionQuality) 0;
                            }

                            public void ToNative(Komatsu.Machine.StatusV1.Guidance.Message.GuidanceStatusMessage sample, bool keysOnly = false)
                            {
                                parent.ToNative(sample, keysOnly);
                                GnssQuality.ToNative(sample.GnssQuality, keysOnly: false);
                                KinematicSolution = sample.KinematicSolution;
                            }
                        }

                        internal class GuidanceStatusMessagePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.StatusV1.Guidance.Message.GuidanceStatusMessage, GuidanceStatusMessageUnmanaged>
                        {
                            internal GuidanceStatusMessagePlugin() : base("Komatsu.Machine.StatusV1.Guidance.Message.GuidanceStatusMessage", isKeyed: false, CreateDynamicType(isPublic: false))
                            {
                            }

                            public static DynamicType CreateDynamicType(bool isPublic = true)
                            {
                                var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                                var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                                // GuidanceStatusMessage struct
                                var GuidanceStatusMessageStructMembers = new StructMember[]
                                {
                                    new StructMember("GnssQuality", Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfoSupport.Instance.GetDynamicTypeInternal(isPublic), id: 1),
                                    new StructMember("KinematicSolution", Komatsu.Machine.StatusV1.Guidance.Type.KinematicSolutionQualitySupport.Instance.GetDynamicTypeInternal(isPublic), id: 2)
                                };

                                return tsf.CreateTypeWithAccessInfo<GuidanceStatusMessageUnmanaged>(
                                    dtf.BuildStruct()
                                    .WithParent((StructType) Komatsu.Machine.StatusV1.Message.StatusMessageSupport.Instance.GetDynamicTypeInternal(isPublic))
                                    .WithExtensibility(ExtensibilityKind.Extensible)
                                    .WithName("Komatsu::Machine::StatusV1::Guidance::Message::GuidanceStatusMessage")
                                    .AddMembers(GuidanceStatusMessageStructMembers));
                            }
                        }
                    }

                    public class GuidanceStatusMessageSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.StatusV1.Guidance.Message.GuidanceStatusMessage>
                    {
                        public GuidanceStatusMessageSupport() : base(
                            new Implementation.GuidanceStatusMessagePlugin(),
                            new Lazy<DynamicType>(() =>Implementation.GuidanceStatusMessagePlugin.CreateDynamicType(isPublic: true)))
                        {
                        }

                        public static GuidanceStatusMessageSupport Instance { get; } =
                        ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GuidanceStatusMessageSupport, Komatsu.Machine.StatusV1.Guidance.Message.GuidanceStatusMessage>();
                    }

                } // namespace Message

            } // namespace Guidance

        } // namespace StatusV1

    } // namespace Machine

} // namespace Komatsu

