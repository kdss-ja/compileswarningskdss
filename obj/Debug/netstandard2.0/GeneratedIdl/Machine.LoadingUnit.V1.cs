
/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.LoadingUnit.V1.idl
using RTI Code Generator (rtiddsgen) version 3.1.0.
The rtiddsgen tool is part of the RTI Connext DDS distribution.
For more information, type 'rtiddsgen -help' at a command shell
or consult the Code Generator User's Manual.
*/

using System;
using System.Reflection;
using System.Collections.Generic;
using Rti.Types;
using System.Linq;
using Omg.Types;

namespace Komatsu
{
    namespace Machine
    {
        namespace LoadingUnitV1
        {
            namespace Type
            {
                public class ElectricShovelGeometryPoints :  IEquatable<ElectricShovelGeometryPoints>
                {
                    public double crowdPivotX { get; set; }

                    public double crowdPivotZ { get; set; }

                    public ElectricShovelGeometryPoints()
                    {
                    }

                    public ElectricShovelGeometryPoints(double  crowdPivotX, double  crowdPivotZ)
                    {
                        this.crowdPivotX = crowdPivotX;
                        this.crowdPivotZ = crowdPivotZ;
                    }

                    public ElectricShovelGeometryPoints(ElectricShovelGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.crowdPivotX = other.crowdPivotX;
                        this.crowdPivotZ = other.crowdPivotZ;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(crowdPivotX);
                        hash.Add(crowdPivotZ);

                        return hash.ToHashCode();
                    }

                    public bool Equals(ElectricShovelGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.crowdPivotX.Equals(other.crowdPivotX) &&
                        this.crowdPivotZ.Equals(other.crowdPivotZ);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as ElectricShovelGeometryPoints);

                    public override string ToString() => ElectricShovelGeometryPointsSupport.Instance.ToString(this);
                }

                public class HydraulicExcavatorGeometryPoints :  IEquatable<HydraulicExcavatorGeometryPoints>
                {
                    public double boomLength { get; set; }

                    public double stickLength { get; set; }

                    public double bucketLength { get; set; }

                    public double boomPositionX { get; set; }

                    public double boomPositionZ { get; set; }

                    public HydraulicExcavatorGeometryPoints()
                    {
                    }

                    public HydraulicExcavatorGeometryPoints(double  boomLength, double  stickLength, double  bucketLength, double  boomPositionX, double  boomPositionZ)
                    {
                        this.boomLength = boomLength;
                        this.stickLength = stickLength;
                        this.bucketLength = bucketLength;
                        this.boomPositionX = boomPositionX;
                        this.boomPositionZ = boomPositionZ;
                    }

                    public HydraulicExcavatorGeometryPoints(HydraulicExcavatorGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.boomLength = other.boomLength;
                        this.stickLength = other.stickLength;
                        this.bucketLength = other.bucketLength;
                        this.boomPositionX = other.boomPositionX;
                        this.boomPositionZ = other.boomPositionZ;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(boomLength);
                        hash.Add(stickLength);
                        hash.Add(bucketLength);
                        hash.Add(boomPositionX);
                        hash.Add(boomPositionZ);

                        return hash.ToHashCode();
                    }

                    public bool Equals(HydraulicExcavatorGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.boomLength.Equals(other.boomLength) &&
                        this.stickLength.Equals(other.stickLength) &&
                        this.bucketLength.Equals(other.bucketLength) &&
                        this.boomPositionX.Equals(other.boomPositionX) &&
                        this.boomPositionZ.Equals(other.boomPositionZ);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as HydraulicExcavatorGeometryPoints);

                    public override string ToString() => HydraulicExcavatorGeometryPointsSupport.Instance.ToString(this);
                }

                public class HydraulicShovelGeometryPoints :  IEquatable<HydraulicShovelGeometryPoints>
                {
                    public double boomLength { get; set; }

                    public double stickLength { get; set; }

                    public double bucketLength { get; set; }

                    public double boomPositionX { get; set; }

                    public double boomPositionZ { get; set; }

                    public HydraulicShovelGeometryPoints()
                    {
                    }

                    public HydraulicShovelGeometryPoints(double  boomLength, double  stickLength, double  bucketLength, double  boomPositionX, double  boomPositionZ)
                    {
                        this.boomLength = boomLength;
                        this.stickLength = stickLength;
                        this.bucketLength = bucketLength;
                        this.boomPositionX = boomPositionX;
                        this.boomPositionZ = boomPositionZ;
                    }

                    public HydraulicShovelGeometryPoints(HydraulicShovelGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.boomLength = other.boomLength;
                        this.stickLength = other.stickLength;
                        this.bucketLength = other.bucketLength;
                        this.boomPositionX = other.boomPositionX;
                        this.boomPositionZ = other.boomPositionZ;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(boomLength);
                        hash.Add(stickLength);
                        hash.Add(bucketLength);
                        hash.Add(boomPositionX);
                        hash.Add(boomPositionZ);

                        return hash.ToHashCode();
                    }

                    public bool Equals(HydraulicShovelGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.boomLength.Equals(other.boomLength) &&
                        this.stickLength.Equals(other.stickLength) &&
                        this.bucketLength.Equals(other.bucketLength) &&
                        this.boomPositionX.Equals(other.boomPositionX) &&
                        this.boomPositionZ.Equals(other.boomPositionZ);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as HydraulicShovelGeometryPoints);

                    public override string ToString() => HydraulicShovelGeometryPointsSupport.Instance.ToString(this);
                }

                public class WheelLoaderGeometryPoints :  IEquatable<WheelLoaderGeometryPoints>
                {
                    public double boomLength { get; set; }

                    public double stickLength { get; set; }

                    public double bucketLength { get; set; }

                    public double boomPositionX { get; set; }

                    public double boomPositionZ { get; set; }

                    public WheelLoaderGeometryPoints()
                    {
                    }

                    public WheelLoaderGeometryPoints(double  boomLength, double  stickLength, double  bucketLength, double  boomPositionX, double  boomPositionZ)
                    {
                        this.boomLength = boomLength;
                        this.stickLength = stickLength;
                        this.bucketLength = bucketLength;
                        this.boomPositionX = boomPositionX;
                        this.boomPositionZ = boomPositionZ;
                    }

                    public WheelLoaderGeometryPoints(WheelLoaderGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.boomLength = other.boomLength;
                        this.stickLength = other.stickLength;
                        this.bucketLength = other.bucketLength;
                        this.boomPositionX = other.boomPositionX;
                        this.boomPositionZ = other.boomPositionZ;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(boomLength);
                        hash.Add(stickLength);
                        hash.Add(bucketLength);
                        hash.Add(boomPositionX);
                        hash.Add(boomPositionZ);

                        return hash.ToHashCode();
                    }

                    public bool Equals(WheelLoaderGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.boomLength.Equals(other.boomLength) &&
                        this.stickLength.Equals(other.stickLength) &&
                        this.bucketLength.Equals(other.bucketLength) &&
                        this.boomPositionX.Equals(other.boomPositionX) &&
                        this.boomPositionZ.Equals(other.boomPositionZ);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as WheelLoaderGeometryPoints);

                    public override string ToString() => WheelLoaderGeometryPointsSupport.Instance.ToString(this);
                }

                public class LoadingUnitGeometryPoints :  IEquatable<LoadingUnitGeometryPoints>
                {

                    private Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints _ElectricShovelGeometry;

                    private Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints _HydraulicExcavatorGeometry;

                    private Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints _HydraulicShovelGeometry;

                    private Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints _WheelLoaderGeometry;

                    public Komatsu.Machine.SharedV1.Type.MachineTypeEnum Discriminator { get; private set; }

                    public const Komatsu.Machine.SharedV1.Type.MachineTypeEnum DefaultDiscriminator =  Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL;

                    public Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints ElectricShovelGeometry
                    {
                        get
                        {
                            if (Discriminator != Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL) 
                            {
                                throw new InvalidOperationException("ElectricShovelGeometry not selected");
                            }
                            return _ElectricShovelGeometry;
                        }

                        set
                        {
                            _ElectricShovelGeometry = value;
                            Discriminator = Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL;
                        }
                    }

                    public Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints HydraulicExcavatorGeometry
                    {
                        get
                        {
                            if (Discriminator != Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR) 
                            {
                                throw new InvalidOperationException("HydraulicExcavatorGeometry not selected");
                            }
                            return _HydraulicExcavatorGeometry;
                        }

                        set
                        {
                            _HydraulicExcavatorGeometry = value;
                            Discriminator = Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR;
                        }
                    }

                    public Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints HydraulicShovelGeometry
                    {
                        get
                        {
                            if (Discriminator != Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL) 
                            {
                                throw new InvalidOperationException("HydraulicShovelGeometry not selected");
                            }
                            return _HydraulicShovelGeometry;
                        }

                        set
                        {
                            _HydraulicShovelGeometry = value;
                            Discriminator = Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL;
                        }
                    }

                    public Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints WheelLoaderGeometry
                    {
                        get
                        {
                            if (Discriminator != Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER) 
                            {
                                throw new InvalidOperationException("WheelLoaderGeometry not selected");
                            }
                            return _WheelLoaderGeometry;
                        }

                        set
                        {
                            _WheelLoaderGeometry = value;
                            Discriminator = Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER;
                        }
                    }

                    public LoadingUnitGeometryPoints()
                    {
                        Discriminator = DefaultDiscriminator;
                        _ElectricShovelGeometry = new Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints();
                    }

                    public LoadingUnitGeometryPoints(LoadingUnitGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.Discriminator = other.Discriminator;
                        switch (Discriminator)
                        {
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                            this._ElectricShovelGeometry = new Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelGeometryPoints(other.ElectricShovelGeometry);
                            break;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                            this._HydraulicExcavatorGeometry = new Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorGeometryPoints(other.HydraulicExcavatorGeometry);
                            break;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                            this._HydraulicShovelGeometry = new Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelGeometryPoints(other.HydraulicShovelGeometry);
                            break;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                            this._WheelLoaderGeometry = new Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderGeometryPoints(other.WheelLoaderGeometry);
                            break;
                        }
                    }

                    public object Get()
                    {
                        switch (Discriminator)
                        {
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                            return ElectricShovelGeometry;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                            return HydraulicExcavatorGeometry;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                            return HydraulicShovelGeometry;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                            return WheelLoaderGeometry;
                            default:
                            return null;
                        }
                    }

                    public override int GetHashCode()
                    {
                        switch (Discriminator)
                        {
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                            return HashCode.Combine(Discriminator, ElectricShovelGeometry);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                            return HashCode.Combine(Discriminator, HydraulicExcavatorGeometry);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                            return HashCode.Combine(Discriminator, HydraulicShovelGeometry);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                            return HashCode.Combine(Discriminator, WheelLoaderGeometry);
                        }

                        throw new InvalidOperationException("Invalid discriminator");
                    }

                    public bool Equals(LoadingUnitGeometryPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        if (this.Discriminator != other.Discriminator)
                        {
                            return false;
                        }

                        switch (Discriminator)
                        {
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                            return this.ElectricShovelGeometry.Equals(other.ElectricShovelGeometry);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                            return this.HydraulicExcavatorGeometry.Equals(other.HydraulicExcavatorGeometry);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                            return this.HydraulicShovelGeometry.Equals(other.HydraulicShovelGeometry);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                            return this.WheelLoaderGeometry.Equals(other.WheelLoaderGeometry);
                        }
                        throw new InvalidOperationException("Invalid discriminator");
                    }

                    public override bool Equals(object obj) => this.Equals(obj as LoadingUnitGeometryPoints);

                    public override string ToString() => LoadingUnitGeometryPointsSupport.Instance.ToString(this);
                }

                public class ElectricShovelKinematicPoints :  IEquatable<ElectricShovelKinematicPoints>
                {
                    public double crowdAngle { get; set; }

                    public double trackHeading { get; set; }

                    public ElectricShovelKinematicPoints()
                    {
                    }

                    public ElectricShovelKinematicPoints(double  crowdAngle, double  trackHeading)
                    {
                        this.crowdAngle = crowdAngle;
                        this.trackHeading = trackHeading;
                    }

                    public ElectricShovelKinematicPoints(ElectricShovelKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.crowdAngle = other.crowdAngle;
                        this.trackHeading = other.trackHeading;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(crowdAngle);
                        hash.Add(trackHeading);

                        return hash.ToHashCode();
                    }

                    public bool Equals(ElectricShovelKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.crowdAngle.Equals(other.crowdAngle) &&
                        this.trackHeading.Equals(other.trackHeading);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as ElectricShovelKinematicPoints);

                    public override string ToString() => ElectricShovelKinematicPointsSupport.Instance.ToString(this);
                }

                public class HydraulicExcavatorKinematicPoints :  IEquatable<HydraulicExcavatorKinematicPoints>
                {
                    public double stickPositionX { get; set; }

                    public double stickPositionZ { get; set; }

                    public double bucketPivotX { get; set; }

                    public double bucketPivotZ { get; set; }

                    public double bucketWishbonePivotX { get; set; }

                    public double bucketWishbonePivotZ { get; set; }

                    public double bucketWishboneTipX { get; set; }

                    public double bucketWishboneTipZ { get; set; }

                    public double bucketLinkX { get; set; }

                    public double bucketLinkZ { get; set; }

                    public double trackHeading { get; set; }

                    public HydraulicExcavatorKinematicPoints()
                    {
                    }

                    public HydraulicExcavatorKinematicPoints(double  stickPositionX, double  stickPositionZ, double  bucketPivotX, double  bucketPivotZ, double  bucketWishbonePivotX, double  bucketWishbonePivotZ, double  bucketWishboneTipX, double  bucketWishboneTipZ, double  bucketLinkX, double  bucketLinkZ, double  trackHeading)
                    {
                        this.stickPositionX = stickPositionX;
                        this.stickPositionZ = stickPositionZ;
                        this.bucketPivotX = bucketPivotX;
                        this.bucketPivotZ = bucketPivotZ;
                        this.bucketWishbonePivotX = bucketWishbonePivotX;
                        this.bucketWishbonePivotZ = bucketWishbonePivotZ;
                        this.bucketWishboneTipX = bucketWishboneTipX;
                        this.bucketWishboneTipZ = bucketWishboneTipZ;
                        this.bucketLinkX = bucketLinkX;
                        this.bucketLinkZ = bucketLinkZ;
                        this.trackHeading = trackHeading;
                    }

                    public HydraulicExcavatorKinematicPoints(HydraulicExcavatorKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.stickPositionX = other.stickPositionX;
                        this.stickPositionZ = other.stickPositionZ;
                        this.bucketPivotX = other.bucketPivotX;
                        this.bucketPivotZ = other.bucketPivotZ;
                        this.bucketWishbonePivotX = other.bucketWishbonePivotX;
                        this.bucketWishbonePivotZ = other.bucketWishbonePivotZ;
                        this.bucketWishboneTipX = other.bucketWishboneTipX;
                        this.bucketWishboneTipZ = other.bucketWishboneTipZ;
                        this.bucketLinkX = other.bucketLinkX;
                        this.bucketLinkZ = other.bucketLinkZ;
                        this.trackHeading = other.trackHeading;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(stickPositionX);
                        hash.Add(stickPositionZ);
                        hash.Add(bucketPivotX);
                        hash.Add(bucketPivotZ);
                        hash.Add(bucketWishbonePivotX);
                        hash.Add(bucketWishbonePivotZ);
                        hash.Add(bucketWishboneTipX);
                        hash.Add(bucketWishboneTipZ);
                        hash.Add(bucketLinkX);
                        hash.Add(bucketLinkZ);
                        hash.Add(trackHeading);

                        return hash.ToHashCode();
                    }

                    public bool Equals(HydraulicExcavatorKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.stickPositionX.Equals(other.stickPositionX) &&
                        this.stickPositionZ.Equals(other.stickPositionZ) &&
                        this.bucketPivotX.Equals(other.bucketPivotX) &&
                        this.bucketPivotZ.Equals(other.bucketPivotZ) &&
                        this.bucketWishbonePivotX.Equals(other.bucketWishbonePivotX) &&
                        this.bucketWishbonePivotZ.Equals(other.bucketWishbonePivotZ) &&
                        this.bucketWishboneTipX.Equals(other.bucketWishboneTipX) &&
                        this.bucketWishboneTipZ.Equals(other.bucketWishboneTipZ) &&
                        this.bucketLinkX.Equals(other.bucketLinkX) &&
                        this.bucketLinkZ.Equals(other.bucketLinkZ) &&
                        this.trackHeading.Equals(other.trackHeading);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as HydraulicExcavatorKinematicPoints);

                    public override string ToString() => HydraulicExcavatorKinematicPointsSupport.Instance.ToString(this);
                }

                public class HydraulicShovelKinematicPoints :  IEquatable<HydraulicShovelKinematicPoints>
                {
                    public double stickPositionX { get; set; }

                    public double stickPositionZ { get; set; }

                    public double bucketPivotX { get; set; }

                    public double bucketPivotZ { get; set; }

                    public double bucketLinkX { get; set; }

                    public double bucketLinkZ { get; set; }

                    public double trackHeading { get; set; }

                    public HydraulicShovelKinematicPoints()
                    {
                    }

                    public HydraulicShovelKinematicPoints(double  stickPositionX, double  stickPositionZ, double  bucketPivotX, double  bucketPivotZ, double  bucketLinkX, double  bucketLinkZ, double  trackHeading)
                    {
                        this.stickPositionX = stickPositionX;
                        this.stickPositionZ = stickPositionZ;
                        this.bucketPivotX = bucketPivotX;
                        this.bucketPivotZ = bucketPivotZ;
                        this.bucketLinkX = bucketLinkX;
                        this.bucketLinkZ = bucketLinkZ;
                        this.trackHeading = trackHeading;
                    }

                    public HydraulicShovelKinematicPoints(HydraulicShovelKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.stickPositionX = other.stickPositionX;
                        this.stickPositionZ = other.stickPositionZ;
                        this.bucketPivotX = other.bucketPivotX;
                        this.bucketPivotZ = other.bucketPivotZ;
                        this.bucketLinkX = other.bucketLinkX;
                        this.bucketLinkZ = other.bucketLinkZ;
                        this.trackHeading = other.trackHeading;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(stickPositionX);
                        hash.Add(stickPositionZ);
                        hash.Add(bucketPivotX);
                        hash.Add(bucketPivotZ);
                        hash.Add(bucketLinkX);
                        hash.Add(bucketLinkZ);
                        hash.Add(trackHeading);

                        return hash.ToHashCode();
                    }

                    public bool Equals(HydraulicShovelKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.stickPositionX.Equals(other.stickPositionX) &&
                        this.stickPositionZ.Equals(other.stickPositionZ) &&
                        this.bucketPivotX.Equals(other.bucketPivotX) &&
                        this.bucketPivotZ.Equals(other.bucketPivotZ) &&
                        this.bucketLinkX.Equals(other.bucketLinkX) &&
                        this.bucketLinkZ.Equals(other.bucketLinkZ) &&
                        this.trackHeading.Equals(other.trackHeading);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as HydraulicShovelKinematicPoints);

                    public override string ToString() => HydraulicShovelKinematicPointsSupport.Instance.ToString(this);
                }

                public class WheelLoaderKinematicPoints :  IEquatable<WheelLoaderKinematicPoints>
                {
                    public double bucketPivotX { get; set; }

                    public double bucketPivotZ { get; set; }

                    [Optional]
                    public double? articulationAngle { get; set; }

                    public WheelLoaderKinematicPoints()
                    {
                    }

                    public WheelLoaderKinematicPoints(double  bucketPivotX, double  bucketPivotZ, double ?  articulationAngle)
                    {
                        this.bucketPivotX = bucketPivotX;
                        this.bucketPivotZ = bucketPivotZ;
                        this.articulationAngle = articulationAngle;
                    }

                    public WheelLoaderKinematicPoints(WheelLoaderKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.bucketPivotX = other.bucketPivotX;
                        this.bucketPivotZ = other.bucketPivotZ;
                        this.articulationAngle = other.articulationAngle;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(bucketPivotX);
                        hash.Add(bucketPivotZ);
                        hash.Add(articulationAngle);

                        return hash.ToHashCode();
                    }

                    public bool Equals(WheelLoaderKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.bucketPivotX.Equals(other.bucketPivotX) &&
                        this.bucketPivotZ.Equals(other.bucketPivotZ) &&
                        Equals(this.articulationAngle, other.articulationAngle);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as WheelLoaderKinematicPoints);

                    public override string ToString() => WheelLoaderKinematicPointsSupport.Instance.ToString(this);
                }

                public class LoadingUnitKinematicPoints :  IEquatable<LoadingUnitKinematicPoints>
                {

                    private Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints _ElectricShovelKinematics;

                    private Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints _HydraulicExcavatorKinematics;

                    private Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints _HydraulicShovelKinematics;

                    private Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints _WheelLoaderKinematics;

                    public Komatsu.Machine.SharedV1.Type.MachineTypeEnum Discriminator { get; private set; }

                    public const Komatsu.Machine.SharedV1.Type.MachineTypeEnum DefaultDiscriminator =  Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL;

                    public Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints ElectricShovelKinematics
                    {
                        get
                        {
                            if (Discriminator != Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL) 
                            {
                                throw new InvalidOperationException("ElectricShovelKinematics not selected");
                            }
                            return _ElectricShovelKinematics;
                        }

                        set
                        {
                            _ElectricShovelKinematics = value;
                            Discriminator = Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL;
                        }
                    }

                    public Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints HydraulicExcavatorKinematics
                    {
                        get
                        {
                            if (Discriminator != Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR) 
                            {
                                throw new InvalidOperationException("HydraulicExcavatorKinematics not selected");
                            }
                            return _HydraulicExcavatorKinematics;
                        }

                        set
                        {
                            _HydraulicExcavatorKinematics = value;
                            Discriminator = Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR;
                        }
                    }

                    public Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints HydraulicShovelKinematics
                    {
                        get
                        {
                            if (Discriminator != Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL) 
                            {
                                throw new InvalidOperationException("HydraulicShovelKinematics not selected");
                            }
                            return _HydraulicShovelKinematics;
                        }

                        set
                        {
                            _HydraulicShovelKinematics = value;
                            Discriminator = Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL;
                        }
                    }

                    public Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints WheelLoaderKinematics
                    {
                        get
                        {
                            if (Discriminator != Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER) 
                            {
                                throw new InvalidOperationException("WheelLoaderKinematics not selected");
                            }
                            return _WheelLoaderKinematics;
                        }

                        set
                        {
                            _WheelLoaderKinematics = value;
                            Discriminator = Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER;
                        }
                    }

                    public LoadingUnitKinematicPoints()
                    {
                        Discriminator = DefaultDiscriminator;
                        _ElectricShovelKinematics = new Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints();
                    }

                    public LoadingUnitKinematicPoints(LoadingUnitKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.Discriminator = other.Discriminator;
                        switch (Discriminator)
                        {
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                            this._ElectricShovelKinematics = new Komatsu.Machine.LoadingUnitV1.Type.ElectricShovelKinematicPoints(other.ElectricShovelKinematics);
                            break;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                            this._HydraulicExcavatorKinematics = new Komatsu.Machine.LoadingUnitV1.Type.HydraulicExcavatorKinematicPoints(other.HydraulicExcavatorKinematics);
                            break;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                            this._HydraulicShovelKinematics = new Komatsu.Machine.LoadingUnitV1.Type.HydraulicShovelKinematicPoints(other.HydraulicShovelKinematics);
                            break;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                            this._WheelLoaderKinematics = new Komatsu.Machine.LoadingUnitV1.Type.WheelLoaderKinematicPoints(other.WheelLoaderKinematics);
                            break;
                        }
                    }

                    public object Get()
                    {
                        switch (Discriminator)
                        {
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                            return ElectricShovelKinematics;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                            return HydraulicExcavatorKinematics;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                            return HydraulicShovelKinematics;
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                            return WheelLoaderKinematics;
                            default:
                            return null;
                        }
                    }

                    public override int GetHashCode()
                    {
                        switch (Discriminator)
                        {
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                            return HashCode.Combine(Discriminator, ElectricShovelKinematics);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                            return HashCode.Combine(Discriminator, HydraulicExcavatorKinematics);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                            return HashCode.Combine(Discriminator, HydraulicShovelKinematics);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                            return HashCode.Combine(Discriminator, WheelLoaderKinematics);
                        }

                        throw new InvalidOperationException("Invalid discriminator");
                    }

                    public bool Equals(LoadingUnitKinematicPoints other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        if (this.Discriminator != other.Discriminator)
                        {
                            return false;
                        }

                        switch (Discriminator)
                        {
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.ELECTRIC_SHOVEL:
                            return this.ElectricShovelKinematics.Equals(other.ElectricShovelKinematics);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_EXCAVATOR:
                            return this.HydraulicExcavatorKinematics.Equals(other.HydraulicExcavatorKinematics);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.HYDRAULIC_SHOVEL:
                            return this.HydraulicShovelKinematics.Equals(other.HydraulicShovelKinematics);
                            case Komatsu.Machine.SharedV1.Type.MachineTypeEnum.WHEEL_LOADER:
                            return this.WheelLoaderKinematics.Equals(other.WheelLoaderKinematics);
                        }
                        throw new InvalidOperationException("Invalid discriminator");
                    }

                    public override bool Equals(object obj) => this.Equals(obj as LoadingUnitKinematicPoints);

                    public override string ToString() => LoadingUnitKinematicPointsSupport.Instance.ToString(this);
                }

                public class LoadingUnitBase :  IEquatable<LoadingUnitBase>
                {
                    public Komatsu.Machine.SharedV1.Type.MachineTypeEnum MachineType { get; set; }

                    public LoadingUnitBase()
                    {
                        MachineType = (Komatsu.Machine.SharedV1.Type.MachineTypeEnum) 0;
                    }

                    public LoadingUnitBase(Komatsu.Machine.SharedV1.Type.MachineTypeEnum  MachineType)
                    {
                        this.MachineType = MachineType;
                    }

                    public LoadingUnitBase(LoadingUnitBase other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.MachineType = other.MachineType;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(MachineType);

                        return hash.ToHashCode();
                    }

                    public bool Equals(LoadingUnitBase other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.MachineType.Equals(other.MachineType);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as LoadingUnitBase);

                    public override string ToString() => LoadingUnitBaseSupport.Instance.ToString(this);
                }

                public class LoadingUnitConfigBase :  Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBase, IEquatable<LoadingUnitConfigBase>
                {
                    public Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints Geometry { get; set; }

                    public LoadingUnitConfigBase()
                    {
                        Geometry = new Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints();
                    }

                    public LoadingUnitConfigBase(Komatsu.Machine.SharedV1.Type.MachineTypeEnum  MachineType,  Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints  Geometry) : base(MachineType)
                    {
                        this.Geometry = Geometry;
                    }

                    public LoadingUnitConfigBase(LoadingUnitConfigBase other) : base(other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.Geometry = new Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints(other.Geometry);

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(base.GetHashCode());

                        hash.Add(Geometry);

                        return hash.ToHashCode();
                    }

                    public bool Equals(LoadingUnitConfigBase other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        if(!base.Equals(other))
                        {
                            return false;
                        }

                        return this.Geometry.Equals(other.Geometry);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as LoadingUnitConfigBase);

                    public override string ToString() => LoadingUnitConfigBaseSupport.Instance.ToString(this);
                }

                public class LoadingUnitGuidanceBase :  Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitBase, IEquatable<LoadingUnitGuidanceBase>
                {
                    public Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates Position { get; set; }

                    public Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates BucketPosition { get; set; }

                    public Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints Kinematics { get; set; }

                    [Optional]
                    public Komatsu.Machine.SharedV1.Type.MachineOrientation Orientation { get; set; }

                    [Optional]
                    public Komatsu.Machine.SharedV1.Type.GPSQualityData GPSQuality { get; set; }

                    [Optional]
                    public double? Speed { get; set; }

                    [Optional]
                    public double? Heading { get; set; }

                    public LoadingUnitGuidanceBase()
                    {
                        Position = new Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates();
                        BucketPosition = new Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates();
                        Kinematics = new Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints();
                    }

                    public LoadingUnitGuidanceBase(Komatsu.Machine.SharedV1.Type.MachineTypeEnum  MachineType,  Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates  Position, Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates  BucketPosition, Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints  Kinematics, Komatsu.Machine.SharedV1.Type.MachineOrientation  Orientation, Komatsu.Machine.SharedV1.Type.GPSQualityData  GPSQuality, double ?  Speed, double ?  Heading) : base(MachineType)
                    {
                        this.Position = Position;
                        this.BucketPosition = BucketPosition;
                        this.Kinematics = Kinematics;
                        this.Orientation = Orientation;
                        this.GPSQuality = GPSQuality;
                        this.Speed = Speed;
                        this.Heading = Heading;
                    }

                    public LoadingUnitGuidanceBase(LoadingUnitGuidanceBase other) : base(other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.Position = new Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates(other.Position);
                        this.BucketPosition = new Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates(other.BucketPosition);
                        this.Kinematics = new Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints(other.Kinematics);
                        if(other.Orientation != null)
                        {
                            this.Orientation = new Komatsu.Machine.SharedV1.Type.MachineOrientation(other.Orientation);
                        }
                        if(other.GPSQuality != null)
                        {
                            this.GPSQuality = new Komatsu.Machine.SharedV1.Type.GPSQualityData(other.GPSQuality);
                        }
                        this.Speed = other.Speed;
                        this.Heading = other.Heading;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(base.GetHashCode());

                        hash.Add(Position);
                        hash.Add(BucketPosition);
                        hash.Add(Kinematics);
                        hash.Add(Orientation);
                        hash.Add(GPSQuality);
                        hash.Add(Speed);
                        hash.Add(Heading);

                        return hash.ToHashCode();
                    }

                    public bool Equals(LoadingUnitGuidanceBase other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        if(!base.Equals(other))
                        {
                            return false;
                        }

                        return this.Position.Equals(other.Position) &&
                        this.BucketPosition.Equals(other.BucketPosition) &&
                        this.Kinematics.Equals(other.Kinematics) &&
                        Equals(this.Orientation, other.Orientation) &&
                        Equals(this.GPSQuality, other.GPSQuality) &&
                        Equals(this.Speed, other.Speed) &&
                        Equals(this.Heading, other.Heading);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as LoadingUnitGuidanceBase);

                    public override string ToString() => LoadingUnitGuidanceBaseSupport.Instance.ToString(this);
                }

            } // namespace Type
            namespace Message
            {
                public class LoadingUnitGuidance :  Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGuidanceBase, IEquatable<LoadingUnitGuidance>
                {
                    [Bound(30)]
                    public string TimeUtc { get; set; } = string.Empty;

                    public LoadingUnitGuidance()
                    {
                    }

                    public LoadingUnitGuidance(Komatsu.Machine.SharedV1.Type.MachineTypeEnum  MachineType, Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates  Position, Komatsu.Machine.SharedV1.Type.BucketPositionCoordinates  BucketPosition, Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitKinematicPoints  Kinematics, Komatsu.Machine.SharedV1.Type.MachineOrientation  Orientation, Komatsu.Machine.SharedV1.Type.GPSQualityData  GPSQuality, double ?  Speed, double ?  Heading,  string  TimeUtc) : base(MachineType, Position, BucketPosition, Kinematics, Orientation, GPSQuality, Speed, Heading)
                    {
                        this.TimeUtc = TimeUtc;
                    }

                    public LoadingUnitGuidance(LoadingUnitGuidance other) : base(other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.TimeUtc = other.TimeUtc;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(base.GetHashCode());

                        hash.Add(TimeUtc);

                        return hash.ToHashCode();
                    }

                    public bool Equals(LoadingUnitGuidance other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        if(!base.Equals(other))
                        {
                            return false;
                        }

                        return this.TimeUtc.Equals(other.TimeUtc);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as LoadingUnitGuidance);

                    public override string ToString() => LoadingUnitGuidanceSupport.Instance.ToString(this);
                }

                public class LoadingUnitConfig :  Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitConfigBase, IEquatable<LoadingUnitConfig>
                {

                    public LoadingUnitConfig()
                    {
                    }

                    public LoadingUnitConfig(Komatsu.Machine.SharedV1.Type.MachineTypeEnum  MachineType, Komatsu.Machine.LoadingUnitV1.Type.LoadingUnitGeometryPoints  Geometry ) : base(MachineType, Geometry)
                    {
                    }

                    public LoadingUnitConfig(LoadingUnitConfig other) : base(other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(base.GetHashCode());

                        return hash.ToHashCode();
                    }

                    public bool Equals(LoadingUnitConfig other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        if(!base.Equals(other))
                        {
                            return false;
                        }

                        return true;
                    }

                    public override bool Equals(object obj) => this.Equals(obj as LoadingUnitConfig);

                    public override string ToString() => LoadingUnitConfigSupport.Instance.ToString(this);
                }

            } // namespace Message
        } // namespace LoadingUnitV1
    } // namespace Machine
} // namespace Komatsu
