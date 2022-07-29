/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.Shared.V1.idl
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

        namespace SharedV1
        {

            namespace Type
            {

                namespace Implementation
                {
                    internal class MachineTypeEnumPlugin : Rti.Dds.NativeInterface.TypePlugin.EnumTypePlugin
                    {
                        public MachineTypeEnumPlugin() : base(CreateDynamicType(isPublic: false))
                        {
                        }

                        internal static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            return dtf.BuildEnum()
                            .WithName("Komatsu::Machine::SharedV1::Type::MachineTypeEnum")
                            .AddMember(new EnumMember("ELECTRIC_SHOVEL", 0))
                            .AddMember(new EnumMember("HYDRAULIC_EXCAVATOR", 1))
                            .AddMember(new EnumMember("HYDRAULIC_SHOVEL", 2))
                            .AddMember(new EnumMember("WHEEL_LOADER", 3))
                            .WithExtensibility(ExtensibilityKind.Extensible)
                            .Create();
                        }
                    }
                }

                public class MachineTypeEnumSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.MachineTypeEnum>
                {
                    public MachineTypeEnumSupport() : base(
                        new Implementation.MachineTypeEnumPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.MachineTypeEnumPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static MachineTypeEnumSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<MachineTypeEnumSupport, Komatsu.Machine.SharedV1.Type.MachineTypeEnum>();
                }

                namespace Implementation
                {
                    public struct CoordinateUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.Coordinate>
                    {

                        private double X;
                        private double Y;
                        private double Z;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.Coordinate sample, bool keysOnly = false)
                        {

                            sample.X = X;
                            sample.Y = Y;
                            sample.Z = Z;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            X = (double) 0.0;
                            Y = (double) 0.0;
                            Z = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.Coordinate sample, bool keysOnly = false)
                        {
                            X = sample.X;
                            Y = sample.Y;
                            Z = sample.Z;
                        }
                    }

                    internal class CoordinatePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.Coordinate, CoordinateUnmanaged>
                    {
                        internal CoordinatePlugin() : base("Komatsu.Machine.SharedV1.Type.Coordinate", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // Coordinate struct
                            var CoordinateStructMembers = new StructMember[]
                            {
                                new StructMember("X", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("Y", dtf.GetPrimitiveType<double>(), id: 1),
                                new StructMember("Z", dtf.GetPrimitiveType<double>(), id: 2)
                            };

                            return tsf.CreateTypeWithAccessInfo<CoordinateUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::Coordinate")
                                .AddMembers(CoordinateStructMembers));
                        }
                    }
                }

                public class CoordinateSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.Coordinate>
                {
                    public CoordinateSupport() : base(
                        new Implementation.CoordinatePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.CoordinatePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static CoordinateSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<CoordinateSupport, Komatsu.Machine.SharedV1.Type.Coordinate>();
                }

                namespace Implementation
                {
                    public struct GeographicCoordinateUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.GeographicCoordinate>
                    {

                        private double Latitude;
                        private double Longitude;
                        private NativeUnmanagedOptional Elevation;

                        public void Destroy(bool optionalsOnly)
                        {
                            Elevation.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.GeographicCoordinate sample, bool keysOnly = false)
                        {

                            sample.Latitude = Latitude;
                            sample.Longitude = Longitude;
                            sample.Elevation = Elevation.FromNative<float>();
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            Latitude = (double) 0.0;
                            Longitude = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.GeographicCoordinate sample, bool keysOnly = false)
                        {
                            Latitude = sample.Latitude;
                            Longitude = sample.Longitude;
                            Elevation.ToNative<float>(sample.Elevation);
                        }
                    }

                    internal class GeographicCoordinatePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.GeographicCoordinate, GeographicCoordinateUnmanaged>
                    {
                        internal GeographicCoordinatePlugin() : base("Komatsu.Machine.SharedV1.Type.GeographicCoordinate", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // GeographicCoordinate struct
                            var GeographicCoordinateStructMembers = new StructMember[]
                            {
                                new StructMember("Latitude", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("Longitude", dtf.GetPrimitiveType<double>(), id: 1),
                                new StructMember("Elevation", dtf.GetPrimitiveType<float>(), isOptional: true, id: 2)
                            };

                            return tsf.CreateTypeWithAccessInfo<GeographicCoordinateUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::GeographicCoordinate")
                                .AddMembers(GeographicCoordinateStructMembers));
                        }
                    }
                }

                public class GeographicCoordinateSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.GeographicCoordinate>
                {
                    public GeographicCoordinateSupport() : base(
                        new Implementation.GeographicCoordinatePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.GeographicCoordinatePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static GeographicCoordinateSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GeographicCoordinateSupport, Komatsu.Machine.SharedV1.Type.GeographicCoordinate>();
                }

                namespace Implementation
                {
                    public struct ProjectedCoordinateUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.ProjectedCoordinate>
                    {

                        private double Easting;
                        private double Northing;
                        private float Elevation;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.ProjectedCoordinate sample, bool keysOnly = false)
                        {

                            sample.Easting = Easting;
                            sample.Northing = Northing;
                            sample.Elevation = Elevation;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            Easting = (double) 0.0;
                            Northing = (double) 0.0;
                            Elevation = (float) 0.0f;
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.ProjectedCoordinate sample, bool keysOnly = false)
                        {
                            Easting = sample.Easting;
                            Northing = sample.Northing;
                            Elevation = sample.Elevation;
                        }
                    }

                    internal class ProjectedCoordinatePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.ProjectedCoordinate, ProjectedCoordinateUnmanaged>
                    {
                        internal ProjectedCoordinatePlugin() : base("Komatsu.Machine.SharedV1.Type.ProjectedCoordinate", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // ProjectedCoordinate struct
                            var ProjectedCoordinateStructMembers = new StructMember[]
                            {
                                new StructMember("Easting", dtf.GetPrimitiveType<double>(), id: 0),
                                new StructMember("Northing", dtf.GetPrimitiveType<double>(), id: 1),
                                new StructMember("Elevation", dtf.GetPrimitiveType<float>(), id: 2)
                            };

                            return tsf.CreateTypeWithAccessInfo<ProjectedCoordinateUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::ProjectedCoordinate")
                                .AddMembers(ProjectedCoordinateStructMembers));
                        }
                    }
                }

                public class ProjectedCoordinateSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.ProjectedCoordinate>
                {
                    public ProjectedCoordinateSupport() : base(
                        new Implementation.ProjectedCoordinatePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.ProjectedCoordinatePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static ProjectedCoordinateSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<ProjectedCoordinateSupport, Komatsu.Machine.SharedV1.Type.ProjectedCoordinate>();
                }

                namespace Implementation
                {
                    public struct GPSAntennaPositionCoordinatesUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.GPSAntennaPositionCoordinates>
                    {

                        private Komatsu.Machine.SharedV1.Type.Implementation.GeographicCoordinateUnmanaged LocalGeographicPosition;
                        private Komatsu.Machine.SharedV1.Type.Implementation.ProjectedCoordinateUnmanaged LocalPosition;

                        public void Destroy(bool optionalsOnly)
                        {
                            LocalGeographicPosition.Destroy(optionalsOnly);
                            if (optionalsOnly)
                            {
                                return;
                            }
                            LocalPosition.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.GPSAntennaPositionCoordinates sample, bool keysOnly = false)
                        {

                            LocalGeographicPosition.FromNative(sample.LocalGeographicPosition, keysOnly: false);
                            LocalPosition.FromNative(sample.LocalPosition, keysOnly: false);
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            LocalGeographicPosition.Initialize(allocatePointers, allocateMemory);
                            LocalPosition.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.GPSAntennaPositionCoordinates sample, bool keysOnly = false)
                        {
                            LocalGeographicPosition.ToNative(sample.LocalGeographicPosition, keysOnly: false);
                            LocalPosition.ToNative(sample.LocalPosition, keysOnly: false);
                        }
                    }

                    internal class GPSAntennaPositionCoordinatesPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.GPSAntennaPositionCoordinates, GPSAntennaPositionCoordinatesUnmanaged>
                    {
                        internal GPSAntennaPositionCoordinatesPlugin() : base("Komatsu.Machine.SharedV1.Type.GPSAntennaPositionCoordinates", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // GPSAntennaPositionCoordinates struct
                            var GPSAntennaPositionCoordinatesStructMembers = new StructMember[]
                            {
                                new StructMember("LocalGeographicPosition", Komatsu.Machine.SharedV1.Type.GeographicCoordinateSupport.Instance.GetDynamicTypeInternal(isPublic), id: 0),
                                new StructMember("LocalPosition", Komatsu.Machine.SharedV1.Type.ProjectedCoordinateSupport.Instance.GetDynamicTypeInternal(isPublic), id: 1)
                            };

                            return tsf.CreateTypeWithAccessInfo<GPSAntennaPositionCoordinatesUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::GPSAntennaPositionCoordinates")
                                .AddMembers(GPSAntennaPositionCoordinatesStructMembers));
                        }
                    }
                }

                public class GPSAntennaPositionCoordinatesSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.GPSAntennaPositionCoordinates>
                {
                    public GPSAntennaPositionCoordinatesSupport() : base(
                        new Implementation.GPSAntennaPositionCoordinatesPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.GPSAntennaPositionCoordinatesPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static GPSAntennaPositionCoordinatesSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GPSAntennaPositionCoordinatesSupport, Komatsu.Machine.SharedV1.Type.GPSAntennaPositionCoordinates>();
                }

                namespace Implementation
                {
                    public struct MachinePositionCoordinatesUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates>
                    {

                        private Komatsu.Machine.SharedV1.Type.Implementation.GeographicCoordinateUnmanaged LocalGeographicPosition;
                        private Komatsu.Machine.SharedV1.Type.Implementation.ProjectedCoordinateUnmanaged LocalPosition;

                        public void Destroy(bool optionalsOnly)
                        {
                            LocalGeographicPosition.Destroy(optionalsOnly);
                            if (optionalsOnly)
                            {
                                return;
                            }
                            LocalPosition.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates sample, bool keysOnly = false)
                        {

                            LocalGeographicPosition.FromNative(sample.LocalGeographicPosition, keysOnly: false);
                            LocalPosition.FromNative(sample.LocalPosition, keysOnly: false);
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            LocalGeographicPosition.Initialize(allocatePointers, allocateMemory);
                            LocalPosition.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates sample, bool keysOnly = false)
                        {
                            LocalGeographicPosition.ToNative(sample.LocalGeographicPosition, keysOnly: false);
                            LocalPosition.ToNative(sample.LocalPosition, keysOnly: false);
                        }
                    }

                    internal class MachinePositionCoordinatesPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates, MachinePositionCoordinatesUnmanaged>
                    {
                        internal MachinePositionCoordinatesPlugin() : base("Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // MachinePositionCoordinates struct
                            var MachinePositionCoordinatesStructMembers = new StructMember[]
                            {
                                new StructMember("LocalGeographicPosition", Komatsu.Machine.SharedV1.Type.GeographicCoordinateSupport.Instance.GetDynamicTypeInternal(isPublic), id: 0),
                                new StructMember("LocalPosition", Komatsu.Machine.SharedV1.Type.ProjectedCoordinateSupport.Instance.GetDynamicTypeInternal(isPublic), id: 1)
                            };

                            return tsf.CreateTypeWithAccessInfo<MachinePositionCoordinatesUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::MachinePositionCoordinates")
                                .AddMembers(MachinePositionCoordinatesStructMembers));
                        }
                    }
                }

                public class MachinePositionCoordinatesSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates>
                {
                    public MachinePositionCoordinatesSupport() : base(
                        new Implementation.MachinePositionCoordinatesPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.MachinePositionCoordinatesPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static MachinePositionCoordinatesSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<MachinePositionCoordinatesSupport, Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates>();
                }

                namespace Implementation
                {
                    public struct BucketPositionCoordinatesUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates>
                    {

                        private Komatsu.Machine.SharedV1.Type.Implementation.CoordinateUnmanaged BucketXZCoordinate;
                        private NativeManagedOptional BucketLocalCoordinate;

                        public void Destroy(bool optionalsOnly)
                        {
                            BucketLocalCoordinate.Destroy<Komatsu.Machine.SharedV1.Type.ProjectedCoordinate, Komatsu.Machine.SharedV1.Type.Implementation.ProjectedCoordinateUnmanaged>(optionalsOnly);
                            if (optionalsOnly)
                            {
                                return;
                            }
                            BucketXZCoordinate.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates sample, bool keysOnly = false)
                        {

                            BucketXZCoordinate.FromNative(sample.BucketXZCoordinate, keysOnly: false);
                            BucketLocalCoordinate.FromNative<Komatsu.Machine.SharedV1.Type.ProjectedCoordinate, Komatsu.Machine.SharedV1.Type.Implementation.ProjectedCoordinateUnmanaged>(out var BucketLocalCoordinateTemporary_);
                            sample.BucketLocalCoordinate = BucketLocalCoordinateTemporary_;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            BucketXZCoordinate.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates sample, bool keysOnly = false)
                        {
                            BucketXZCoordinate.ToNative(sample.BucketXZCoordinate, keysOnly: false);
                            BucketLocalCoordinate.ToNative<Komatsu.Machine.SharedV1.Type.ProjectedCoordinate, Komatsu.Machine.SharedV1.Type.Implementation.ProjectedCoordinateUnmanaged>(sample.BucketLocalCoordinate);
                        }
                    }

                    internal class BucketPositionCoordinatesPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates, BucketPositionCoordinatesUnmanaged>
                    {
                        internal BucketPositionCoordinatesPlugin() : base("Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // BucketPositionCoordinates struct
                            var BucketPositionCoordinatesStructMembers = new StructMember[]
                            {
                                new StructMember("BucketXZCoordinate", Komatsu.Machine.SharedV1.Type.CoordinateSupport.Instance.GetDynamicTypeInternal(isPublic), id: 0),
                                new StructMember("BucketLocalCoordinate", Komatsu.Machine.SharedV1.Type.ProjectedCoordinateSupport.Instance.GetDynamicTypeInternal(isPublic), isOptional: true, id: 1)
                            };

                            return tsf.CreateTypeWithAccessInfo<BucketPositionCoordinatesUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::BucketPositionCoordinates")
                                .AddMembers(BucketPositionCoordinatesStructMembers));
                        }
                    }
                }

                public class BucketPositionCoordinatesSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates>
                {
                    public BucketPositionCoordinatesSupport() : base(
                        new Implementation.BucketPositionCoordinatesPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.BucketPositionCoordinatesPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static BucketPositionCoordinatesSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<BucketPositionCoordinatesSupport, Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates>();
                }

                namespace Implementation
                {
                    public struct MachineOrientationUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.MachineOrientation>
                    {

                        private NativeUnmanagedOptional Yaw;
                        private NativeUnmanagedOptional Pitch;
                        private NativeUnmanagedOptional Roll;

                        public void Destroy(bool optionalsOnly)
                        {
                            Yaw.Destroy(optionalsOnly);
                            Pitch.Destroy(optionalsOnly);
                            Roll.Destroy(optionalsOnly);
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.MachineOrientation sample, bool keysOnly = false)
                        {

                            sample.Yaw = Yaw.FromNative<float>();
                            sample.Pitch = Pitch.FromNative<float>();
                            sample.Roll = Roll.FromNative<float>();
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.MachineOrientation sample, bool keysOnly = false)
                        {
                            Yaw.ToNative<float>(sample.Yaw);
                            Pitch.ToNative<float>(sample.Pitch);
                            Roll.ToNative<float>(sample.Roll);
                        }
                    }

                    internal class MachineOrientationPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.MachineOrientation, MachineOrientationUnmanaged>
                    {
                        internal MachineOrientationPlugin() : base("Komatsu.Machine.SharedV1.Type.MachineOrientation", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // MachineOrientation struct
                            var MachineOrientationStructMembers = new StructMember[]
                            {
                                new StructMember("Yaw", dtf.GetPrimitiveType<float>(), isOptional: true, id: 0),
                                new StructMember("Pitch", dtf.GetPrimitiveType<float>(), isOptional: true, id: 1),
                                new StructMember("Roll", dtf.GetPrimitiveType<float>(), isOptional: true, id: 2)
                            };

                            return tsf.CreateTypeWithAccessInfo<MachineOrientationUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::MachineOrientation")
                                .AddMembers(MachineOrientationStructMembers));
                        }
                    }
                }

                public class MachineOrientationSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.MachineOrientation>
                {
                    public MachineOrientationSupport() : base(
                        new Implementation.MachineOrientationPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.MachineOrientationPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static MachineOrientationSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<MachineOrientationSupport, Komatsu.Machine.SharedV1.Type.MachineOrientation>();
                }

                namespace Implementation
                {
                    internal class GPSFixTypePlugin : Rti.Dds.NativeInterface.TypePlugin.EnumTypePlugin
                    {
                        public GPSFixTypePlugin() : base(CreateDynamicType(isPublic: false))
                        {
                        }

                        internal static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            return dtf.BuildEnum()
                            .WithName("Komatsu::Machine::SharedV1::Type::GPSFixType")
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

                public class GPSFixTypeSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.GPSFixType>
                {
                    public GPSFixTypeSupport() : base(
                        new Implementation.GPSFixTypePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.GPSFixTypePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static GPSFixTypeSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GPSFixTypeSupport, Komatsu.Machine.SharedV1.Type.GPSFixType>();
                }

                namespace Implementation
                {
                    public struct GPSQualityOfServiceUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.GPSQualityOfService>
                    {

                        private Komatsu.Machine.SharedV1.Type.GPSFixType FixType;
                        private short NumberOfSatellites;
                        private double PositionDilutionOfPrecision;
                        private double HorizontalDilutionOfPrecision;
                        private double VerticalDilutionOfPrecision;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.GPSQualityOfService sample, bool keysOnly = false)
                        {

                            sample.FixType = FixType;
                            sample.NumberOfSatellites = NumberOfSatellites;
                            sample.PositionDilutionOfPrecision = PositionDilutionOfPrecision;
                            sample.HorizontalDilutionOfPrecision = HorizontalDilutionOfPrecision;
                            sample.VerticalDilutionOfPrecision = VerticalDilutionOfPrecision;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            FixType = (Komatsu.Machine.SharedV1.Type.GPSFixType) 0;
                            NumberOfSatellites = (short) 0;
                            PositionDilutionOfPrecision = (double) 0.0;
                            HorizontalDilutionOfPrecision = (double) 0.0;
                            VerticalDilutionOfPrecision = (double) 0.0;
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.GPSQualityOfService sample, bool keysOnly = false)
                        {
                            FixType = sample.FixType;
                            NumberOfSatellites = sample.NumberOfSatellites;
                            PositionDilutionOfPrecision = sample.PositionDilutionOfPrecision;
                            HorizontalDilutionOfPrecision = sample.HorizontalDilutionOfPrecision;
                            VerticalDilutionOfPrecision = sample.VerticalDilutionOfPrecision;
                        }
                    }

                    internal class GPSQualityOfServicePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.GPSQualityOfService, GPSQualityOfServiceUnmanaged>
                    {
                        internal GPSQualityOfServicePlugin() : base("Komatsu.Machine.SharedV1.Type.GPSQualityOfService", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // GPSQualityOfService struct
                            var GPSQualityOfServiceStructMembers = new StructMember[]
                            {
                                new StructMember("FixType", Komatsu.Machine.SharedV1.Type.GPSFixTypeSupport.Instance.GetDynamicTypeInternal(isPublic), id: 0),
                                new StructMember("NumberOfSatellites", dtf.GetPrimitiveType<short>(), id: 1),
                                new StructMember("PositionDilutionOfPrecision", dtf.GetPrimitiveType<double>(), id: 2),
                                new StructMember("HorizontalDilutionOfPrecision", dtf.GetPrimitiveType<double>(), id: 3),
                                new StructMember("VerticalDilutionOfPrecision", dtf.GetPrimitiveType<double>(), id: 4)
                            };

                            return tsf.CreateTypeWithAccessInfo<GPSQualityOfServiceUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::GPSQualityOfService")
                                .AddMembers(GPSQualityOfServiceStructMembers));
                        }
                    }
                }

                public class GPSQualityOfServiceSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.GPSQualityOfService>
                {
                    public GPSQualityOfServiceSupport() : base(
                        new Implementation.GPSQualityOfServicePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.GPSQualityOfServicePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static GPSQualityOfServiceSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GPSQualityOfServiceSupport, Komatsu.Machine.SharedV1.Type.GPSQualityOfService>();
                }

                namespace Implementation
                {
                    public struct GPSDataUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.GPSData>
                    {

                        private NativeString TimeUtc;
                        private Komatsu.Machine.SharedV1.Type.Implementation.GeographicCoordinateUnmanaged AntennaGeoPosition;
                        private NativeManagedOptional AntennaProjectedPosition;
                        private NativeUnmanagedOptional GpsHeading;
                        private NativeUnmanagedOptional GpsSpeed;
                        private NativeManagedOptional GpsQoS;

                        public void Destroy(bool optionalsOnly)
                        {
                            AntennaGeoPosition.Destroy(optionalsOnly);
                            AntennaProjectedPosition.Destroy<Komatsu.Machine.SharedV1.Type.ProjectedCoordinate, Komatsu.Machine.SharedV1.Type.Implementation.ProjectedCoordinateUnmanaged>(optionalsOnly);
                            GpsHeading.Destroy(optionalsOnly);
                            GpsSpeed.Destroy(optionalsOnly);
                            GpsQoS.Destroy<Komatsu.Machine.SharedV1.Type.GPSQualityOfService, Komatsu.Machine.SharedV1.Type.Implementation.GPSQualityOfServiceUnmanaged>(optionalsOnly);
                            if (optionalsOnly)
                            {
                                return;
                            }
                            TimeUtc.Destroy();
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.GPSData sample, bool keysOnly = false)
                        {

                            sample.TimeUtc = TimeUtc.FromNative();
                            AntennaGeoPosition.FromNative(sample.AntennaGeoPosition, keysOnly: false);
                            AntennaProjectedPosition.FromNative<Komatsu.Machine.SharedV1.Type.ProjectedCoordinate, Komatsu.Machine.SharedV1.Type.Implementation.ProjectedCoordinateUnmanaged>(out var AntennaProjectedPositionTemporary_);
                            sample.AntennaProjectedPosition = AntennaProjectedPositionTemporary_;
                            sample.GpsHeading = GpsHeading.FromNative<float>();
                            sample.GpsSpeed = GpsSpeed.FromNative<float>();
                            GpsQoS.FromNative<Komatsu.Machine.SharedV1.Type.GPSQualityOfService, Komatsu.Machine.SharedV1.Type.Implementation.GPSQualityOfServiceUnmanaged>(out var GpsQoSTemporary_);
                            sample.GpsQoS = GpsQoSTemporary_;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            TimeUtc.Initialize(size: ((int) 30), allocateMemory: allocateMemory);
                            AntennaGeoPosition.Initialize(allocatePointers, allocateMemory);
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.GPSData sample, bool keysOnly = false)
                        {
                            TimeUtc.ToNative(sample.TimeUtc, ((int) 30));
                            AntennaGeoPosition.ToNative(sample.AntennaGeoPosition, keysOnly: false);
                            AntennaProjectedPosition.ToNative<Komatsu.Machine.SharedV1.Type.ProjectedCoordinate, Komatsu.Machine.SharedV1.Type.Implementation.ProjectedCoordinateUnmanaged>(sample.AntennaProjectedPosition);
                            GpsHeading.ToNative<float>(sample.GpsHeading);
                            GpsSpeed.ToNative<float>(sample.GpsSpeed);
                            GpsQoS.ToNative<Komatsu.Machine.SharedV1.Type.GPSQualityOfService, Komatsu.Machine.SharedV1.Type.Implementation.GPSQualityOfServiceUnmanaged>(sample.GpsQoS);
                        }
                    }

                    internal class GPSDataPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.GPSData, GPSDataUnmanaged>
                    {
                        internal GPSDataPlugin() : base("Komatsu.Machine.SharedV1.Type.GPSData", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // GPSData struct
                            var GPSDataStructMembers = new StructMember[]
                            {
                                new StructMember("TimeUtc", dtf.CreateString(((int) 30)), id: 0),
                                new StructMember("AntennaGeoPosition", Komatsu.Machine.SharedV1.Type.GeographicCoordinateSupport.Instance.GetDynamicTypeInternal(isPublic), id: 1),
                                new StructMember("AntennaProjectedPosition", Komatsu.Machine.SharedV1.Type.ProjectedCoordinateSupport.Instance.GetDynamicTypeInternal(isPublic), isOptional: true, id: 2),
                                new StructMember("GpsHeading", dtf.GetPrimitiveType<float>(), isOptional: true, id: 3),
                                new StructMember("GpsSpeed", dtf.GetPrimitiveType<float>(), isOptional: true, id: 4),
                                new StructMember("GpsQoS", Komatsu.Machine.SharedV1.Type.GPSQualityOfServiceSupport.Instance.GetDynamicTypeInternal(isPublic), isOptional: true, id: 5)
                            };

                            return tsf.CreateTypeWithAccessInfo<GPSDataUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::GPSData")
                                .AddMembers(GPSDataStructMembers));
                        }
                    }
                }

                public class GPSDataSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.GPSData>
                {
                    public GPSDataSupport() : base(
                        new Implementation.GPSDataPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.GPSDataPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static GPSDataSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GPSDataSupport, Komatsu.Machine.SharedV1.Type.GPSData>();
                }

                namespace Implementation
                {
                    internal class GPSQualityTypeEmunPlugin : Rti.Dds.NativeInterface.TypePlugin.EnumTypePlugin
                    {
                        public GPSQualityTypeEmunPlugin() : base(CreateDynamicType(isPublic: false))
                        {
                        }

                        internal static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            return dtf.BuildEnum()
                            .WithName("Komatsu::Machine::SharedV1::Type::GPSQualityTypeEmun")
                            .AddMember(new EnumMember("GOOD", 0))
                            .AddMember(new EnumMember("BAD", 1))
                            .AddMember(new EnumMember("DEGRADED_LOW_SATELLITES", 2))
                            .WithExtensibility(ExtensibilityKind.Extensible)
                            .Create();
                        }
                    }
                }

                public class GPSQualityTypeEmunSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.GPSQualityTypeEmun>
                {
                    public GPSQualityTypeEmunSupport() : base(
                        new Implementation.GPSQualityTypeEmunPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.GPSQualityTypeEmunPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static GPSQualityTypeEmunSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GPSQualityTypeEmunSupport, Komatsu.Machine.SharedV1.Type.GPSQualityTypeEmun>();
                }

                namespace Implementation
                {
                    public struct GPSQualityDataUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.SharedV1.Type.GPSQualityData>
                    {

                        private Komatsu.Machine.SharedV1.Type.GPSQualityTypeEmun QualityType;
                        private short NumberOfSatellites;
                        private Komatsu.Machine.SharedV1.Type.GPSFixType FixType;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.SharedV1.Type.GPSQualityData sample, bool keysOnly = false)
                        {

                            sample.QualityType = QualityType;
                            sample.NumberOfSatellites = NumberOfSatellites;
                            sample.FixType = FixType;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            QualityType = (Komatsu.Machine.SharedV1.Type.GPSQualityTypeEmun) 0;
                            NumberOfSatellites = (short) 0;
                            FixType = (Komatsu.Machine.SharedV1.Type.GPSFixType) 0;
                        }

                        public void ToNative(Komatsu.Machine.SharedV1.Type.GPSQualityData sample, bool keysOnly = false)
                        {
                            QualityType = sample.QualityType;
                            NumberOfSatellites = sample.NumberOfSatellites;
                            FixType = sample.FixType;
                        }
                    }

                    internal class GPSQualityDataPlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.SharedV1.Type.GPSQualityData, GPSQualityDataUnmanaged>
                    {
                        internal GPSQualityDataPlugin() : base("Komatsu.Machine.SharedV1.Type.GPSQualityData", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // GPSQualityData struct
                            var GPSQualityDataStructMembers = new StructMember[]
                            {
                                new StructMember("QualityType", Komatsu.Machine.SharedV1.Type.GPSQualityTypeEmunSupport.Instance.GetDynamicTypeInternal(isPublic), id: 0),
                                new StructMember("NumberOfSatellites", dtf.GetPrimitiveType<short>(), id: 1),
                                new StructMember("FixType", Komatsu.Machine.SharedV1.Type.GPSFixTypeSupport.Instance.GetDynamicTypeInternal(isPublic), id: 2)
                            };

                            return tsf.CreateTypeWithAccessInfo<GPSQualityDataUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::SharedV1::Type::GPSQualityData")
                                .AddMembers(GPSQualityDataStructMembers));
                        }
                    }
                }

                public class GPSQualityDataSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.SharedV1.Type.GPSQualityData>
                {
                    public GPSQualityDataSupport() : base(
                        new Implementation.GPSQualityDataPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.GPSQualityDataPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static GPSQualityDataSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<GPSQualityDataSupport, Komatsu.Machine.SharedV1.Type.GPSQualityData>();
                }

            } // namespace Type

        } // namespace SharedV1

    } // namespace Machine

} // namespace Komatsu

