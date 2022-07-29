/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.LoadingUnit.V1.idl
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

        namespace LoadingUnitV1
        {

            namespace Type
            {

                namespace Implementation
                {
                    public struct ElectricShovelGeometryPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints>
                    {

                        private double crowdPivotX;
                        private double crowdPivotZ;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints sample, bool keysOnly = false)
                        {

                            sample.crowdPivotX = crowdPivotX;
                            sample.crowdPivotZ = crowdPivotZ;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            crowdPivotX = (double) 0.0;
                            crowdPivotZ = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints sample, bool keysOnly = false)
                        {
                            crowdPivotX = sample.crowdPivotX;
                            crowdPivotZ = sample.crowdPivotZ;
                        }
                    }

                    internal class ElectricShovelGeometryPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints, ElectricShovelGeometryPointsUnmanaged>
                    {
                        internal ElectricShovelGeometryPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // ElectricShovelGeometryPoints struct
                            var ElectricShovelGeometryPointsStructMembers = new StructMember[]
                            {
                                new StructMember("crowdPivotX", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("crowdPivotZ", dtf.GetPrimitiveType<double>(), id: 1)
                            };

                            return tsf.CreateTypeWithAccessInfo<ElectricShovelGeometryPointsUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::ElectricShovelGeometryPoints")
                                .AddMembers(ElectricShovelGeometryPointsStructMembers));
                        }
                    }
                }

                public class ElectricShovelGeometryPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints>
                {
                    public ElectricShovelGeometryPointsSupport() : base(
                        new Implementation.ElectricShovelGeometryPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.ElectricShovelGeometryPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static ElectricShovelGeometryPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<ElectricShovelGeometryPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints>();
                }

                namespace Implementation
                {
                    public struct HydraulicExcavatorGeometryPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints>
                    {

                        private double boomLength;
                        private double stickLength;
                        private double bucketLength;
                        private double boomPositionX;
                        private double boomPositionZ;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints sample, bool keysOnly = false)
                        {

                            sample.boomLength = boomLength;
                            sample.stickLength = stickLength;
                            sample.bucketLength = bucketLength;
                            sample.boomPositionX = boomPositionX;
                            sample.boomPositionZ = boomPositionZ;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            boomLength = (double) 0.0;
                            stickLength = (double) 0.0;
                            bucketLength = (double) 0.0;
                            boomPositionX = (double) 0.0;
                            boomPositionZ = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints sample, bool keysOnly = false)
                        {
                            boomLength = sample.boomLength;
                            stickLength = sample.stickLength;
                            bucketLength = sample.bucketLength;
                            boomPositionX = sample.boomPositionX;
                            boomPositionZ = sample.boomPositionZ;
                        }
                    }

                    internal class HydraulicExcavatorGeometryPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints, HydraulicExcavatorGeometryPointsUnmanaged>
                    {
                        internal HydraulicExcavatorGeometryPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // HydraulicExcavatorGeometryPoints struct
                            var HydraulicExcavatorGeometryPointsStructMembers = new StructMember[]
                            {
                                new StructMember("boomLength", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("stickLength", dtf.GetPrimitiveType<double>(), id: 1),
                                new StructMember("bucketLength", dtf.GetPrimitiveType<double>(), id: 2),
                                new StructMember("boomPositionX", dtf.GetPrimitiveType<double>(), id: 3),
                                new StructMember("boomPositionZ", dtf.GetPrimitiveType<double>(), id: 4)
                            };

                            return tsf.CreateTypeWithAccessInfo<HydraulicExcavatorGeometryPointsUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::HydraulicExcavatorGeometryPoints")
                                .AddMembers(HydraulicExcavatorGeometryPointsStructMembers));
                        }
                    }
                }

                public class HydraulicExcavatorGeometryPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints>
                {
                    public HydraulicExcavatorGeometryPointsSupport() : base(
                        new Implementation.HydraulicExcavatorGeometryPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.HydraulicExcavatorGeometryPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static HydraulicExcavatorGeometryPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<HydraulicExcavatorGeometryPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints>();
                }

                namespace Implementation
                {
                    public struct HydraulicShovelGeometryPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints>
                    {

                        private double boomLength;
                        private double stickLength;
                        private double bucketLength;
                        private double boomPositionX;
                        private double boomPositionZ;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints sample, bool keysOnly = false)
                        {

                            sample.boomLength = boomLength;
                            sample.stickLength = stickLength;
                            sample.bucketLength = bucketLength;
                            sample.boomPositionX = boomPositionX;
                            sample.boomPositionZ = boomPositionZ;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            boomLength = (double) 0.0;
                            stickLength = (double) 0.0;
                            bucketLength = (double) 0.0;
                            boomPositionX = (double) 0.0;
                            boomPositionZ = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints sample, bool keysOnly = false)
                        {
                            boomLength = sample.boomLength;
                            stickLength = sample.stickLength;
                            bucketLength = sample.bucketLength;
                            boomPositionX = sample.boomPositionX;
                            boomPositionZ = sample.boomPositionZ;
                        }
                    }

                    internal class HydraulicShovelGeometryPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints, HydraulicShovelGeometryPointsUnmanaged>
                    {
                        internal HydraulicShovelGeometryPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // HydraulicShovelGeometryPoints struct
                            var HydraulicShovelGeometryPointsStructMembers = new StructMember[]
                            {
                                new StructMember("boomLength", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("stickLength", dtf.GetPrimitiveType<double>(), id: 1),
                                new StructMember("bucketLength", dtf.GetPrimitiveType<double>(), id: 2),
                                new StructMember("boomPositionX", dtf.GetPrimitiveType<double>(), id: 3),
                                new StructMember("boomPositionZ", dtf.GetPrimitiveType<double>(), id: 4)
                            };

                            return tsf.CreateTypeWithAccessInfo<HydraulicShovelGeometryPointsUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::HydraulicShovelGeometryPoints")
                                .AddMembers(HydraulicShovelGeometryPointsStructMembers));
                        }
                    }
                }

                public class HydraulicShovelGeometryPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints>
                {
                    public HydraulicShovelGeometryPointsSupport() : base(
                        new Implementation.HydraulicShovelGeometryPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.HydraulicShovelGeometryPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static HydraulicShovelGeometryPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<HydraulicShovelGeometryPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints>();
                }

                namespace Implementation
                {
                    public struct WheelLoaderGeometryPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints>
                    {

                        private double boomLength;
                        private double stickLength;
                        private double bucketLength;
                        private double boomPositionX;
                        private double boomPositionZ;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints sample, bool keysOnly = false)
                        {

                            sample.boomLength = boomLength;
                            sample.stickLength = stickLength;
                            sample.bucketLength = bucketLength;
                            sample.boomPositionX = boomPositionX;
                            sample.boomPositionZ = boomPositionZ;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            boomLength = (double) 0.0;
                            stickLength = (double) 0.0;
                            bucketLength = (double) 0.0;
                            boomPositionX = (double) 0.0;
                            boomPositionZ = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints sample, bool keysOnly = false)
                        {
                            boomLength = sample.boomLength;
                            stickLength = sample.stickLength;
                            bucketLength = sample.bucketLength;
                            boomPositionX = sample.boomPositionX;
                            boomPositionZ = sample.boomPositionZ;
                        }
                    }

                    internal class WheelLoaderGeometryPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints, WheelLoaderGeometryPointsUnmanaged>
                    {
                        internal WheelLoaderGeometryPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // WheelLoaderGeometryPoints struct
                            var WheelLoaderGeometryPointsStructMembers = new StructMember[]
                            {
                                new StructMember("boomLength", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("stickLength", dtf.GetPrimitiveType<double>(), id: 1),
                                new StructMember("bucketLength", dtf.GetPrimitiveType<double>(), id: 2),
                                new StructMember("boomPositionX", dtf.GetPrimitiveType<double>(), id: 3),
                                new StructMember("boomPositionZ", dtf.GetPrimitiveType<double>(), id: 4)
                            };

                            return tsf.CreateTypeWithAccessInfo<WheelLoaderGeometryPointsUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::WheelLoaderGeometryPoints")
                                .AddMembers(WheelLoaderGeometryPointsStructMembers));
                        }
                    }
                }

                public class WheelLoaderGeometryPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints>
                {
                    public WheelLoaderGeometryPointsSupport() : base(
                        new Implementation.WheelLoaderGeometryPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.WheelLoaderGeometryPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static WheelLoaderGeometryPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<WheelLoaderGeometryPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints>();
                }

                namespace Implementation
                {
                    public struct LoadingUnitGeometryPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints>
                    {

                        private Komatsu.Machine.SharedV1.Type.MachineTypeEnum _d;
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.ElectricShovelGeometryPointsUnmanaged ElectricShovelGeometry;
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.HydraulicExcavatorGeometryPointsUnmanaged HydraulicExcavatorGeometry;
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.HydraulicShovelGeometryPointsUnmanaged HydraulicShovelGeometry;
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.WheelLoaderGeometryPointsUnmanaged WheelLoaderGeometry;

                        public void Destroy(bool optionalsOnly)
                        {
                            if (optionalsOnly)
                            {
                                return;
                            }
                            ElectricShovelGeometry.Destroy(optionalsOnly);
                            HydraulicExcavatorGeometry.Destroy(optionalsOnly);
                            HydraulicShovelGeometry.Destroy(optionalsOnly);
                            WheelLoaderGeometry.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints sample, bool keysOnly = false)
                        {
                            switch (_d)
                            {
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                                if(sample.Discriminator != _d)
                                {
                                    sample.ElectricShovelGeometry = new Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints();
                                }
                                ElectricShovelGeometry.FromNative(sample.ElectricShovelGeometry, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                                if(sample.Discriminator != _d)
                                {
                                    sample.HydraulicExcavatorGeometry = new Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints();
                                }
                                HydraulicExcavatorGeometry.FromNative(sample.HydraulicExcavatorGeometry, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                                if(sample.Discriminator != _d)
                                {
                                    sample.HydraulicShovelGeometry = new Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints();
                                }
                                HydraulicShovelGeometry.FromNative(sample.HydraulicShovelGeometry, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                                if(sample.Discriminator != _d)
                                {
                                    sample.WheelLoaderGeometry = new Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints();
                                }
                                WheelLoaderGeometry.FromNative(sample.WheelLoaderGeometry, keysOnly: false);
                                break;
                            }
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            _d = LoadingUnitGeometryPoints.DefaultDiscriminator;
                            ElectricShovelGeometry.Initialize(allocatePointers, allocateMemory);
                            HydraulicExcavatorGeometry.Initialize(allocatePointers, allocateMemory);
                            HydraulicShovelGeometry.Initialize(allocatePointers, allocateMemory);
                            WheelLoaderGeometry.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints sample, bool keysOnly = false)
                        {
                            _d = sample.Discriminator;
                            switch (_d)
                            {
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                                ElectricShovelGeometry.ToNative(sample.ElectricShovelGeometry, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                                HydraulicExcavatorGeometry.ToNative(sample.HydraulicExcavatorGeometry, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                                HydraulicShovelGeometry.ToNative(sample.HydraulicShovelGeometry, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                                WheelLoaderGeometry.ToNative(sample.WheelLoaderGeometry, keysOnly: false);
                                break;
                            }
                        }
                    }

                    internal class LoadingUnitGeometryPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints, LoadingUnitGeometryPointsUnmanaged>
                    {
                        internal LoadingUnitGeometryPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // LoadingUnitGeometryPoints union
                            var LoadingUnitGeometryPointsStructMembers = new UnionMember[]
                            {
                                new UnionMember("ElectricShovelGeometry", Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPointsSupport.Instance.GetDynamicTypeInternal(isPublic), new int[] {(int) Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL}, id: 1),
                                new UnionMember("HydraulicExcavatorGeometry", Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPointsSupport.Instance.GetDynamicTypeInternal(isPublic), new int[] {(int) Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR}, id: 2),
                                new UnionMember("HydraulicShovelGeometry", Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPointsSupport.Instance.GetDynamicTypeInternal(isPublic), new int[] {(int) Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL}, id: 3),
                                new UnionMember("WheelLoaderGeometry", Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPointsSupport.Instance.GetDynamicTypeInternal(isPublic), new int[] {(int) Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER}, id: 4)
                            };

                            return tsf.CreateTypeWithAccessInfo<LoadingUnitGeometryPointsUnmanaged>(
                                dtf.BuildUnion()
                                .WithDiscriminator(Komatsu.Machine.SharedV1.Type.MachineTypeEnumSupport.Instance.GetDynamicTypeInternal(isPublic))
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::LoadingUnitGeometryPoints")
                                .AddMembers(LoadingUnitGeometryPointsStructMembers));
                        }
                    }
                }
                public class LoadingUnitGeometryPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints>
                {
                    public LoadingUnitGeometryPointsSupport() : base(
                        new Implementation.LoadingUnitGeometryPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.LoadingUnitGeometryPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static LoadingUnitGeometryPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<LoadingUnitGeometryPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints>();
                }

                namespace Implementation
                {
                    public struct ElectricShovelKinematicPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints>
                    {

                        private double crowdAngle;
                        private double trackHeading;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints sample, bool keysOnly = false)
                        {

                            sample.crowdAngle = crowdAngle;
                            sample.trackHeading = trackHeading;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            crowdAngle = (double) 0.0;
                            trackHeading = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints sample, bool keysOnly = false)
                        {
                            crowdAngle = sample.crowdAngle;
                            trackHeading = sample.trackHeading;
                        }
                    }

                    internal class ElectricShovelKinematicPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints, ElectricShovelKinematicPointsUnmanaged>
                    {
                        internal ElectricShovelKinematicPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // ElectricShovelKinematicPoints struct
                            var ElectricShovelKinematicPointsStructMembers = new StructMember[]
                            {
                                new StructMember("crowdAngle", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("trackHeading", dtf.GetPrimitiveType<double>(), id: 1)
                            };

                            return tsf.CreateTypeWithAccessInfo<ElectricShovelKinematicPointsUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::ElectricShovelKinematicPoints")
                                .AddMembers(ElectricShovelKinematicPointsStructMembers));
                        }
                    }
                }

                public class ElectricShovelKinematicPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints>
                {
                    public ElectricShovelKinematicPointsSupport() : base(
                        new Implementation.ElectricShovelKinematicPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.ElectricShovelKinematicPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static ElectricShovelKinematicPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<ElectricShovelKinematicPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints>();
                }

                namespace Implementation
                {
                    public struct HydraulicExcavatorKinematicPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints>
                    {

                        private double stickPositionX;
                        private double stickPositionZ;
                        private double bucketPivotX;
                        private double bucketPivotZ;
                        private double bucketWishbonePivotX;
                        private double bucketWishbonePivotZ;
                        private double bucketWishboneTipX;
                        private double bucketWishboneTipZ;
                        private double bucketLinkX;
                        private double bucketLinkZ;
                        private double trackHeading;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints sample, bool keysOnly = false)
                        {

                            sample.stickPositionX = stickPositionX;
                            sample.stickPositionZ = stickPositionZ;
                            sample.bucketPivotX = bucketPivotX;
                            sample.bucketPivotZ = bucketPivotZ;
                            sample.bucketWishbonePivotX = bucketWishbonePivotX;
                            sample.bucketWishbonePivotZ = bucketWishbonePivotZ;
                            sample.bucketWishboneTipX = bucketWishboneTipX;
                            sample.bucketWishboneTipZ = bucketWishboneTipZ;
                            sample.bucketLinkX = bucketLinkX;
                            sample.bucketLinkZ = bucketLinkZ;
                            sample.trackHeading = trackHeading;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            stickPositionX = (double) 0.0;
                            stickPositionZ = (double) 0.0;
                            bucketPivotX = (double) 0.0;
                            bucketPivotZ = (double) 0.0;
                            bucketWishbonePivotX = (double) 0.0;
                            bucketWishbonePivotZ = (double) 0.0;
                            bucketWishboneTipX = (double) 0.0;
                            bucketWishboneTipZ = (double) 0.0;
                            bucketLinkX = (double) 0.0;
                            bucketLinkZ = (double) 0.0;
                            trackHeading = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints sample, bool keysOnly = false)
                        {
                            stickPositionX = sample.stickPositionX;
                            stickPositionZ = sample.stickPositionZ;
                            bucketPivotX = sample.bucketPivotX;
                            bucketPivotZ = sample.bucketPivotZ;
                            bucketWishbonePivotX = sample.bucketWishbonePivotX;
                            bucketWishbonePivotZ = sample.bucketWishbonePivotZ;
                            bucketWishboneTipX = sample.bucketWishboneTipX;
                            bucketWishboneTipZ = sample.bucketWishboneTipZ;
                            bucketLinkX = sample.bucketLinkX;
                            bucketLinkZ = sample.bucketLinkZ;
                            trackHeading = sample.trackHeading;
                        }
                    }

                    internal class HydraulicExcavatorKinematicPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints, HydraulicExcavatorKinematicPointsUnmanaged>
                    {
                        internal HydraulicExcavatorKinematicPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // HydraulicExcavatorKinematicPoints struct
                            var HydraulicExcavatorKinematicPointsStructMembers = new StructMember[]
                            {
                                new StructMember("stickPositionX", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("stickPositionZ", dtf.GetPrimitiveType<double>(), id: 1),
                                new StructMember("bucketPivotX", dtf.GetPrimitiveType<double>(), id: 2),
                                new StructMember("bucketPivotZ", dtf.GetPrimitiveType<double>(), id: 3),
                                new StructMember("bucketWishbonePivotX", dtf.GetPrimitiveType<double>(), id: 4),
                                new StructMember("bucketWishbonePivotZ", dtf.GetPrimitiveType<double>(), id: 5),
                                new StructMember("bucketWishboneTipX", dtf.GetPrimitiveType<double>(), id: 6),
                                new StructMember("bucketWishboneTipZ", dtf.GetPrimitiveType<double>(), id: 7),
                                new StructMember("bucketLinkX", dtf.GetPrimitiveType<double>(), id: 8),
                                new StructMember("bucketLinkZ", dtf.GetPrimitiveType<double>(), id: 9),
                                new StructMember("trackHeading", dtf.GetPrimitiveType<double>(), id: 10)
                            };

                            return tsf.CreateTypeWithAccessInfo<HydraulicExcavatorKinematicPointsUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::HydraulicExcavatorKinematicPoints")
                                .AddMembers(HydraulicExcavatorKinematicPointsStructMembers));
                        }
                    }
                }

                public class HydraulicExcavatorKinematicPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints>
                {
                    public HydraulicExcavatorKinematicPointsSupport() : base(
                        new Implementation.HydraulicExcavatorKinematicPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.HydraulicExcavatorKinematicPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static HydraulicExcavatorKinematicPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<HydraulicExcavatorKinematicPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints>();
                }

                namespace Implementation
                {
                    public struct HydraulicShovelKinematicPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints>
                    {

                        private double stickPositionX;
                        private double stickPositionZ;
                        private double bucketPivotX;
                        private double bucketPivotZ;
                        private double bucketLinkX;
                        private double bucketLinkZ;
                        private double trackHeading;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints sample, bool keysOnly = false)
                        {

                            sample.stickPositionX = stickPositionX;
                            sample.stickPositionZ = stickPositionZ;
                            sample.bucketPivotX = bucketPivotX;
                            sample.bucketPivotZ = bucketPivotZ;
                            sample.bucketLinkX = bucketLinkX;
                            sample.bucketLinkZ = bucketLinkZ;
                            sample.trackHeading = trackHeading;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            stickPositionX = (double) 0.0;
                            stickPositionZ = (double) 0.0;
                            bucketPivotX = (double) 0.0;
                            bucketPivotZ = (double) 0.0;
                            bucketLinkX = (double) 0.0;
                            bucketLinkZ = (double) 0.0;
                            trackHeading = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints sample, bool keysOnly = false)
                        {
                            stickPositionX = sample.stickPositionX;
                            stickPositionZ = sample.stickPositionZ;
                            bucketPivotX = sample.bucketPivotX;
                            bucketPivotZ = sample.bucketPivotZ;
                            bucketLinkX = sample.bucketLinkX;
                            bucketLinkZ = sample.bucketLinkZ;
                            trackHeading = sample.trackHeading;
                        }
                    }

                    internal class HydraulicShovelKinematicPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints, HydraulicShovelKinematicPointsUnmanaged>
                    {
                        internal HydraulicShovelKinematicPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // HydraulicShovelKinematicPoints struct
                            var HydraulicShovelKinematicPointsStructMembers = new StructMember[]
                            {
                                new StructMember("stickPositionX", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("stickPositionZ", dtf.GetPrimitiveType<double>(), id: 1),
                                new StructMember("bucketPivotX", dtf.GetPrimitiveType<double>(), id: 2),
                                new StructMember("bucketPivotZ", dtf.GetPrimitiveType<double>(), id: 3),
                                new StructMember("bucketLinkX", dtf.GetPrimitiveType<double>(), id: 4),
                                new StructMember("bucketLinkZ", dtf.GetPrimitiveType<double>(), id: 5),
                                new StructMember("trackHeading", dtf.GetPrimitiveType<double>(), id: 6)
                            };

                            return tsf.CreateTypeWithAccessInfo<HydraulicShovelKinematicPointsUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::HydraulicShovelKinematicPoints")
                                .AddMembers(HydraulicShovelKinematicPointsStructMembers));
                        }
                    }
                }

                public class HydraulicShovelKinematicPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints>
                {
                    public HydraulicShovelKinematicPointsSupport() : base(
                        new Implementation.HydraulicShovelKinematicPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.HydraulicShovelKinematicPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static HydraulicShovelKinematicPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<HydraulicShovelKinematicPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints>();
                }

                namespace Implementation
                {
                    public struct WheelLoaderKinematicPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints>
                    {

                        private double bucketPivotX;
                        private double bucketPivotZ;
                        private NativeUnmanagedOptional articulationAngle;

                        public void Destroy(bool optionalsOnly)
                        {
                            articulationAngle.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints sample, bool keysOnly = false)
                        {

                            sample.bucketPivotX = bucketPivotX;
                            sample.bucketPivotZ = bucketPivotZ;
                            sample.articulationAngle = articulationAngle.FromNative<double>();
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            bucketPivotX = (double) 0.0;
                            bucketPivotZ = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints sample, bool keysOnly = false)
                        {
                            bucketPivotX = sample.bucketPivotX;
                            bucketPivotZ = sample.bucketPivotZ;
                            articulationAngle.ToNative<double>(sample.articulationAngle);
                        }
                    }

                    internal class WheelLoaderKinematicPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints, WheelLoaderKinematicPointsUnmanaged>
                    {
                        internal WheelLoaderKinematicPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // WheelLoaderKinematicPoints struct
                            var WheelLoaderKinematicPointsStructMembers = new StructMember[]
                            {
                                new StructMember("bucketPivotX", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("bucketPivotZ", dtf.GetPrimitiveType<double>(), id: 1),
                                new StructMember("articulationAngle", dtf.GetPrimitiveType<double>(), isOptional: true, id: 2)
                            };

                            return tsf.CreateTypeWithAccessInfo<WheelLoaderKinematicPointsUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::WheelLoaderKinematicPoints")
                                .AddMembers(WheelLoaderKinematicPointsStructMembers));
                        }
                    }
                }

                public class WheelLoaderKinematicPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints>
                {
                    public WheelLoaderKinematicPointsSupport() : base(
                        new Implementation.WheelLoaderKinematicPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.WheelLoaderKinematicPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static WheelLoaderKinematicPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<WheelLoaderKinematicPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints>();
                }

                namespace Implementation
                {
                    public struct LoadingUnitKinematicPointsUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints>
                    {

                        private Komatsu.Machine.SharedV1.Type.MachineTypeEnum _d;
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.ElectricShovelKinematicPointsUnmanaged ElectricShovelKinematics;
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.HydraulicExcavatorKinematicPointsUnmanaged HydraulicExcavatorKinematics;
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.HydraulicShovelKinematicPointsUnmanaged HydraulicShovelKinematics;
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.WheelLoaderKinematicPointsUnmanaged WheelLoaderKinematics;

                        public void Destroy(bool optionalsOnly)
                        {
                            WheelLoaderKinematics.Destroy(optionalsOnly);
                            if (optionalsOnly)
                            {
                                return;
                            }
                            ElectricShovelKinematics.Destroy(optionalsOnly);
                            HydraulicExcavatorKinematics.Destroy(optionalsOnly);
                            HydraulicShovelKinematics.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints sample, bool keysOnly = false)
                        {
                            switch (_d)
                            {
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                                if(sample.Discriminator != _d)
                                {
                                    sample.ElectricShovelKinematics = new Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints();
                                }
                                ElectricShovelKinematics.FromNative(sample.ElectricShovelKinematics, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                                if(sample.Discriminator != _d)
                                {
                                    sample.HydraulicExcavatorKinematics = new Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints();
                                }
                                HydraulicExcavatorKinematics.FromNative(sample.HydraulicExcavatorKinematics, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                                if(sample.Discriminator != _d)
                                {
                                    sample.HydraulicShovelKinematics = new Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints();
                                }
                                HydraulicShovelKinematics.FromNative(sample.HydraulicShovelKinematics, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                                if(sample.Discriminator != _d)
                                {
                                    sample.WheelLoaderKinematics = new Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints();
                                }
                                WheelLoaderKinematics.FromNative(sample.WheelLoaderKinematics, keysOnly: false);
                                break;
                            }
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            _d = LoadingUnitKinematicPoints.DefaultDiscriminator;
                            ElectricShovelKinematics.Initialize(allocatePointers, allocateMemory);
                            HydraulicExcavatorKinematics.Initialize(allocatePointers, allocateMemory);
                            HydraulicShovelKinematics.Initialize(allocatePointers, allocateMemory);
                            WheelLoaderKinematics.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints sample, bool keysOnly = false)
                        {
                            _d = sample.Discriminator;
                            switch (_d)
                            {
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                                ElectricShovelKinematics.ToNative(sample.ElectricShovelKinematics, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                                HydraulicExcavatorKinematics.ToNative(sample.HydraulicExcavatorKinematics, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                                HydraulicShovelKinematics.ToNative(sample.HydraulicShovelKinematics, keysOnly: false);
                                break;
                                case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                                WheelLoaderKinematics.ToNative(sample.WheelLoaderKinematics, keysOnly: false);
                                break;
                            }
                        }
                    }

                    internal class LoadingUnitKinematicPointsPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints, LoadingUnitKinematicPointsUnmanaged>
                    {
                        internal LoadingUnitKinematicPointsPlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // LoadingUnitKinematicPoints union
                            var LoadingUnitKinematicPointsStructMembers = new UnionMember[]
                            {
                                new UnionMember("ElectricShovelKinematics", Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPointsSupport.Instance.GetDynamicTypeInternal(isPublic), new int[] {(int) Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL}, id: 1),
                                new UnionMember("HydraulicExcavatorKinematics", Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPointsSupport.Instance.GetDynamicTypeInternal(isPublic), new int[] {(int) Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR}, id: 2),
                                new UnionMember("HydraulicShovelKinematics", Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPointsSupport.Instance.GetDynamicTypeInternal(isPublic), new int[] {(int) Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL}, id: 3),
                                new UnionMember("WheelLoaderKinematics", Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPointsSupport.Instance.GetDynamicTypeInternal(isPublic), new int[] {(int) Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER}, id: 4)
                            };

                            return tsf.CreateTypeWithAccessInfo<LoadingUnitKinematicPointsUnmanaged>(
                                dtf.BuildUnion()
                                .WithDiscriminator(Komatsu.Machine.SharedV1.Type.MachineTypeEnumSupport.Instance.GetDynamicTypeInternal(isPublic))
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::LoadingUnitKinematicPoints")
                                .AddMembers(LoadingUnitKinematicPointsStructMembers));
                        }
                    }
                }
                public class LoadingUnitKinematicPointsSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints>
                {
                    public LoadingUnitKinematicPointsSupport() : base(
                        new Implementation.LoadingUnitKinematicPointsPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.LoadingUnitKinematicPointsPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static LoadingUnitKinematicPointsSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<LoadingUnitKinematicPointsSupport, Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints>();
                }

                namespace Implementation
                {
                    public struct LoadingUnitBaseUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBase>
                    {

                        private Komatsu.Machine.SharedV1.Type.MachineTypeEnum MachineType;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBase sample, bool keysOnly = false)
                        {

                            sample.MachineType = MachineType;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            MachineType = (Komatsu.Machine.SharedV1.Type.MachineTypeEnum) 0;
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBase sample, bool keysOnly = false)
                        {
                            MachineType = sample.MachineType;
                        }
                    }

                    internal class LoadingUnitBasePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBase, LoadingUnitBaseUnmanaged>
                    {
                        internal LoadingUnitBasePlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBase", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // LoadingUnitBase struct
                            var LoadingUnitBaseStructMembers = new StructMember[]
                            {
                                new StructMember("MachineType", Komatsu.Machine.SharedV1.Type.MachineTypeEnumSupport.Instance.GetDynamicTypeInternal(isPublic), id: 0)
                            };

                            return tsf.CreateTypeWithAccessInfo<LoadingUnitBaseUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::LoadingUnitBase")
                                .AddMembers(LoadingUnitBaseStructMembers));
                        }
                    }
                }

                public class LoadingUnitBaseSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBase>
                {
                    public LoadingUnitBaseSupport() : base(
                        new Implementation.LoadingUnitBasePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.LoadingUnitBasePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static LoadingUnitBaseSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<LoadingUnitBaseSupport, Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBase>();
                }

                namespace Implementation
                {
                    public struct LoadingUnitConfigBaseUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitConfigBase>
                    {

                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.LoadingUnitBaseUnmanaged parent;

                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.LoadingUnitGeometryPointsUnmanaged Geometry;

                        public void Destroy(bool optionalsOnly)
                        {
                            parent.Destroy(optionalsOnly);
                            Geometry.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitConfigBase sample, bool keysOnly = false)
                        {

                            parent.FromNative(sample, keysOnly);
                            Geometry.FromNative(sample.Geometry, keysOnly: false);
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            parent.Initialize(allocatePointers, allocateMemory);
                            Geometry.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitConfigBase sample, bool keysOnly = false)
                        {
                            parent.ToNative(sample, keysOnly);
                            Geometry.ToNative(sample.Geometry, keysOnly: false);
                        }
                    }

                    internal class LoadingUnitConfigBasePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitConfigBase, LoadingUnitConfigBaseUnmanaged>
                    {
                        internal LoadingUnitConfigBasePlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitConfigBase", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // LoadingUnitConfigBase struct
                            var LoadingUnitConfigBaseStructMembers = new StructMember[]
                            {
                                new StructMember("Geometry", Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPointsSupport.Instance.GetDynamicTypeInternal(isPublic), id: 1)
                            };

                            return tsf.CreateTypeWithAccessInfo<LoadingUnitConfigBaseUnmanaged>(
                                dtf.BuildStruct()
                                .WithParent((StructType) Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBaseSupport.Instance.GetDynamicTypeInternal(isPublic))
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::LoadingUnitConfigBase")
                                .AddMembers(LoadingUnitConfigBaseStructMembers));
                        }
                    }
                }

                public class LoadingUnitConfigBaseSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitConfigBase>
                {
                    public LoadingUnitConfigBaseSupport() : base(
                        new Implementation.LoadingUnitConfigBasePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.LoadingUnitConfigBasePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static LoadingUnitConfigBaseSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<LoadingUnitConfigBaseSupport, Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitConfigBase>();
                }

                namespace Implementation
                {
                    public struct LoadingUnitGuidanceBaseUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGuidanceBase>
                    {

                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.LoadingUnitBaseUnmanaged parent;

                        private Komatsu.Machine.SharedV1.Type.Implementation.MachinePositionCoordinatesUnmanaged Position;
                        private Komatsu.Machine.SharedV1.Type.Implementation.BucketPositionCoordinatesUnmanaged BucketPosition;
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.LoadingUnitKinematicPointsUnmanaged Kinematics;
                        private NativeManagedOptional Orientation;
                        private NativeManagedOptional GPSQuality;
                        private NativeUnmanagedOptional Speed;
                        private NativeUnmanagedOptional Heading;

                        public void Destroy(bool optionalsOnly)
                        {
                            parent.Destroy(optionalsOnly);
                            Position.Destroy(optionalsOnly);
                            BucketPosition.Destroy(optionalsOnly);
                            Kinematics.Destroy(optionalsOnly);
                            Orientation.Destroy<Komatsu.Machine.SharedV1.Type.MachineOrientation, Komatsu.Machine.SharedV1.Type.Implementation.MachineOrientationUnmanaged>(optionalsOnly);
                            GPSQuality.Destroy<Komatsu.Machine.SharedV1.Type.GPSQualityData, Komatsu.Machine.SharedV1.Type.Implementation.GPSQualityDataUnmanaged>(optionalsOnly);
                            Speed.Destroy(optionalsOnly);
                            Heading.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGuidanceBase sample, bool keysOnly = false)
                        {

                            parent.FromNative(sample, keysOnly);
                            Position.FromNative(sample.Position, keysOnly: false);
                            BucketPosition.FromNative(sample.BucketPosition, keysOnly: false);
                            Kinematics.FromNative(sample.Kinematics, keysOnly: false);
                            Orientation.FromNative<Komatsu.Machine.SharedV1.Type.MachineOrientation, Komatsu.Machine.SharedV1.Type.Implementation.MachineOrientationUnmanaged>(out var OrientationTemporary_);
                            sample.Orientation = OrientationTemporary_;
                            GPSQuality.FromNative<Komatsu.Machine.SharedV1.Type.GPSQualityData, Komatsu.Machine.SharedV1.Type.Implementation.GPSQualityDataUnmanaged>(out var GPSQualityTemporary_);
                            sample.GPSQuality = GPSQualityTemporary_;
                            sample.Speed = Speed.FromNative<double>();
                            sample.Heading = Heading.FromNative<double>();
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            parent.Initialize(allocatePointers, allocateMemory);
                            Position.Initialize(allocatePointers, allocateMemory);
                            BucketPosition.Initialize(allocatePointers, allocateMemory);
                            Kinematics.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGuidanceBase sample, bool keysOnly = false)
                        {
                            parent.ToNative(sample, keysOnly);
                            Position.ToNative(sample.Position, keysOnly: false);
                            BucketPosition.ToNative(sample.BucketPosition, keysOnly: false);
                            Kinematics.ToNative(sample.Kinematics, keysOnly: false);
                            Orientation.ToNative<Komatsu.Machine.SharedV1.Type.MachineOrientation, Komatsu.Machine.SharedV1.Type.Implementation.MachineOrientationUnmanaged>(sample.Orientation);
                            GPSQuality.ToNative<Komatsu.Machine.SharedV1.Type.GPSQualityData, Komatsu.Machine.SharedV1.Type.Implementation.GPSQualityDataUnmanaged>(sample.GPSQuality);
                            Speed.ToNative<double>(sample.Speed);
                            Heading.ToNative<double>(sample.Heading);
                        }
                    }

                    internal class LoadingUnitGuidanceBasePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGuidanceBase, LoadingUnitGuidanceBaseUnmanaged>
                    {
                        internal LoadingUnitGuidanceBasePlugin() : base("Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGuidanceBase", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // LoadingUnitGuidanceBase struct
                            var LoadingUnitGuidanceBaseStructMembers = new StructMember[]
                            {
                                new StructMember("Position", Komatsu.Machine.SharedV1.Type.MachinePositionCoordinatesSupport.Instance.GetDynamicTypeInternal(isPublic), id: 1),
                                new StructMember("BucketPosition", Komatsu.Machine.SharedV1.Type.BucketPositionCoordinatesSupport.Instance.GetDynamicTypeInternal(isPublic), id: 2),
                                new StructMember("Kinematics", Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPointsSupport.Instance.GetDynamicTypeInternal(isPublic), id: 3),
                                new StructMember("Orientation", Komatsu.Machine.SharedV1.Type.MachineOrientationSupport.Instance.GetDynamicTypeInternal(isPublic), isOptional: true, id: 4),
                                new StructMember("GPSQuality", Komatsu.Machine.SharedV1.Type.GPSQualityDataSupport.Instance.GetDynamicTypeInternal(isPublic), isOptional: true, id: 5),
                                new StructMember("Speed", dtf.GetPrimitiveType<double>(), isOptional: true, id: 6),
                                new StructMember("Heading", dtf.GetPrimitiveType<double>(), isOptional: true, id: 7)
                            };

                            return tsf.CreateTypeWithAccessInfo<LoadingUnitGuidanceBaseUnmanaged>(
                                dtf.BuildStruct()
                                .WithParent((StructType) Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBaseSupport.Instance.GetDynamicTypeInternal(isPublic))
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Type::LoadingUnitGuidanceBase")
                                .AddMembers(LoadingUnitGuidanceBaseStructMembers));
                        }
                    }
                }

                public class LoadingUnitGuidanceBaseSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGuidanceBase>
                {
                    public LoadingUnitGuidanceBaseSupport() : base(
                        new Implementation.LoadingUnitGuidanceBasePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.LoadingUnitGuidanceBasePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static LoadingUnitGuidanceBaseSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<LoadingUnitGuidanceBaseSupport, Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGuidanceBase>();
                }

            } // namespace Type

            namespace Message
            {

                namespace Implementation
                {
                    public struct LoadingUnitGuidanceUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitGuidance>
                    {

                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.LoadingUnitGuidanceBaseUnmanaged parent;

                        private NativeString TimeUtc;

                        public void Destroy(bool optionalsOnly)
                        {
                            parent.Destroy(optionalsOnly);
                            if (optionalsOnly)
                            {
                                return;
                            }
                            TimeUtc.Destroy();
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitGuidance sample, bool keysOnly = false)
                        {

                            parent.FromNative(sample, keysOnly);
                            sample.TimeUtc = TimeUtc.FromNative();
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            parent.Initialize(allocatePointers, allocateMemory);
                            TimeUtc.Initialize(size: ((int) 30), allocateMemory: allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitGuidance sample, bool keysOnly = false)
                        {
                            parent.ToNative(sample, keysOnly);
                            TimeUtc.ToNative(sample.TimeUtc, ((int) 30));
                        }
                    }

                    internal class LoadingUnitGuidancePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitGuidance, LoadingUnitGuidanceUnmanaged>
                    {
                        internal LoadingUnitGuidancePlugin() : base("Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitGuidance", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // LoadingUnitGuidance struct
                            var LoadingUnitGuidanceStructMembers = new StructMember[]
                            {
                                new StructMember("TimeUtc", dtf.CreateString(((int) 30)), id: 8)
                            };

                            return tsf.CreateTypeWithAccessInfo<LoadingUnitGuidanceUnmanaged>(
                                dtf.BuildStruct()
                                .WithParent((StructType) Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGuidanceBaseSupport.Instance.GetDynamicTypeInternal(isPublic))
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Message::LoadingUnitGuidance")
                                .AddMembers(LoadingUnitGuidanceStructMembers));
                        }
                    }
                }

                public class LoadingUnitGuidanceSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitGuidance>
                {
                    public LoadingUnitGuidanceSupport() : base(
                        new Implementation.LoadingUnitGuidancePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.LoadingUnitGuidancePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static LoadingUnitGuidanceSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<LoadingUnitGuidanceSupport, Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitGuidance>();
                }

                namespace Implementation
                {
                    public struct LoadingUnitConfigUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitConfig>
                    {
                        private Komatsu.Machine.LoadingUnitV1.Type.Implementation.LoadingUnitConfigBaseUnmanaged parent;

                        public void Destroy(bool optionalsOnly)
                        {
                            parent.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitConfig sample, bool keysOnly = false)
                        {

                            parent.FromNative(sample, keysOnly);
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            parent.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitConfig sample, bool keysOnly = false)
                        {
                            parent.ToNative(sample, keysOnly);
                        }
                    }

                    internal class LoadingUnitConfigPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitConfig, LoadingUnitConfigUnmanaged>
                    {
                        internal LoadingUnitConfigPlugin() : base("Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitConfig", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // LoadingUnitConfig struct
                            var LoadingUnitConfigStructMembers = new StructMember[]
                            {

                            };

                            return tsf.CreateTypeWithAccessInfo<LoadingUnitConfigUnmanaged>(
                                dtf.BuildStruct()
                                .WithParent((StructType) Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitConfigBaseSupport.Instance.GetDynamicTypeInternal(isPublic))
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::LoadingUnitV1::Message::LoadingUnitConfig")
                                .AddMembers(LoadingUnitConfigStructMembers));
                        }
                    }
                }

                public class LoadingUnitConfigSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitConfig>
                {
                    public LoadingUnitConfigSupport() : base(
                        new Implementation.LoadingUnitConfigPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.LoadingUnitConfigPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static LoadingUnitConfigSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<LoadingUnitConfigSupport, Komatsu.Machine.LoadingUnitV1.Message.LoadingUnitConfig>();
                }

            } // namespace Message

        } // namespace LoadingUnitV1

    } // namespace Machine

} // namespace Komatsu

