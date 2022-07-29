
/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.Shared.V1.idl
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
        namespace SharedV1
        {
            namespace Type
            {
                public enum MachineTypeEnum
                {
                    ELECTRIC_SHOVEL,
                    HYDRAULIC_EXCAVATOR,
                    HYDRAULIC_SHOVEL,
                    WHEEL_LOADER
                }
                public class Coordinate :  IEquatable<Coordinate>
                {
                    public double X { get; set; }

                    public double Y { get; set; }

                    public double Z { get; set; }

                    public Coordinate()
                    {
                    }

                    public Coordinate(double  X, double  Y, double  Z)
                    {
                        this.X = X;
                        this.Y = Y;
                        this.Z = Z;
                    }

                    public Coordinate(Coordinate other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.X = other.X;
                        this.Y = other.Y;
                        this.Z = other.Z;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(X);
                        hash.Add(Y);
                        hash.Add(Z);

                        return hash.ToHashCode();
                    }

                    public bool Equals(Coordinate other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.X.Equals(other.X) &&
                        this.Y.Equals(other.Y) &&
                        this.Z.Equals(other.Z);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as Coordinate);

                    public override string ToString() => CoordinateSupport.Instance.ToString(this);
                }

                public class GeographicCoordinate :  IEquatable<GeographicCoordinate>
                {
                    public double Latitude { get; set; }

                    public double Longitude { get; set; }

                    [Optional]
                    public float? Elevation { get; set; }

                    public GeographicCoordinate()
                    {
                    }

                    public GeographicCoordinate(double  Latitude, double  Longitude, float ?  Elevation)
                    {
                        this.Latitude = Latitude;
                        this.Longitude = Longitude;
                        this.Elevation = Elevation;
                    }

                    public GeographicCoordinate(GeographicCoordinate other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.Latitude = other.Latitude;
                        this.Longitude = other.Longitude;
                        this.Elevation = other.Elevation;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(Latitude);
                        hash.Add(Longitude);
                        hash.Add(Elevation);

                        return hash.ToHashCode();
                    }

                    public bool Equals(GeographicCoordinate other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.Latitude.Equals(other.Latitude) &&
                        this.Longitude.Equals(other.Longitude) &&
                        Equals(this.Elevation, other.Elevation);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as GeographicCoordinate);

                    public override string ToString() => GeographicCoordinateSupport.Instance.ToString(this);
                }

                public class ProjectedCoordinate :  IEquatable<ProjectedCoordinate>
                {
                    public double Easting { get; set; }

                    public double Northing { get; set; }

                    public float Elevation { get; set; }

                    public ProjectedCoordinate()
                    {
                    }

                    public ProjectedCoordinate(double  Easting, double  Northing, float  Elevation)
                    {
                        this.Easting = Easting;
                        this.Northing = Northing;
                        this.Elevation = Elevation;
                    }

                    public ProjectedCoordinate(ProjectedCoordinate other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.Easting = other.Easting;
                        this.Northing = other.Northing;
                        this.Elevation = other.Elevation;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(Easting);
                        hash.Add(Northing);
                        hash.Add(Elevation);

                        return hash.ToHashCode();
                    }

                    public bool Equals(ProjectedCoordinate other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.Easting.Equals(other.Easting) &&
                        this.Northing.Equals(other.Northing) &&
                        this.Elevation.Equals(other.Elevation);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as ProjectedCoordinate);

                    public override string ToString() => ProjectedCoordinateSupport.Instance.ToString(this);
                }

                public class GPSAntennaPositionCoordinates :  IEquatable<GPSAntennaPositionCoordinates>
                {
                    public Komatsu.Machine.SharedV1.Type.GeographicCoordinate LocalGeographicPosition { get; set; }

                    public Komatsu.Machine.SharedV1.Type.ProjectedCoordinate LocalPosition { get; set; }

                    public GPSAntennaPositionCoordinates()
                    {
                        LocalGeographicPosition = new Komatsu.Machine.SharedV1.Type.GeographicCoordinate();
                        LocalPosition = new Komatsu.Machine.SharedV1.Type.ProjectedCoordinate();
                    }

                    public GPSAntennaPositionCoordinates(Komatsu.Machine.SharedV1.Type.GeographicCoordinate  LocalGeographicPosition, Komatsu.Machine.SharedV1.Type.ProjectedCoordinate  LocalPosition)
                    {
                        this.LocalGeographicPosition = LocalGeographicPosition;
                        this.LocalPosition = LocalPosition;
                    }

                    public GPSAntennaPositionCoordinates(GPSAntennaPositionCoordinates other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.LocalGeographicPosition = new Komatsu.Machine.SharedV1.Type.GeographicCoordinate(other.LocalGeographicPosition);
                        this.LocalPosition = new Komatsu.Machine.SharedV1.Type.ProjectedCoordinate(other.LocalPosition);

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(LocalGeographicPosition);
                        hash.Add(LocalPosition);

                        return hash.ToHashCode();
                    }

                    public bool Equals(GPSAntennaPositionCoordinates other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.LocalGeographicPosition.Equals(other.LocalGeographicPosition) &&
                        this.LocalPosition.Equals(other.LocalPosition);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as GPSAntennaPositionCoordinates);

                    public override string ToString() => GPSAntennaPositionCoordinatesSupport.Instance.ToString(this);
                }

                public class MachinePositionCoordinates :  IEquatable<MachinePositionCoordinates>
                {
                    public Komatsu.Machine.SharedV1.Type.GeographicCoordinate LocalGeographicPosition { get; set; }

                    public Komatsu.Machine.SharedV1.Type.ProjectedCoordinate LocalPosition { get; set; }

                    public MachinePositionCoordinates()
                    {
                        LocalGeographicPosition = new Komatsu.Machine.SharedV1.Type.GeographicCoordinate();
                        LocalPosition = new Komatsu.Machine.SharedV1.Type.ProjectedCoordinate();
                    }

                    public MachinePositionCoordinates(Komatsu.Machine.SharedV1.Type.GeographicCoordinate  LocalGeographicPosition, Komatsu.Machine.SharedV1.Type.ProjectedCoordinate  LocalPosition)
                    {
                        this.LocalGeographicPosition = LocalGeographicPosition;
                        this.LocalPosition = LocalPosition;
                    }

                    public MachinePositionCoordinates(MachinePositionCoordinates other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.LocalGeographicPosition = new Komatsu.Machine.SharedV1.Type.GeographicCoordinate(other.LocalGeographicPosition);
                        this.LocalPosition = new Komatsu.Machine.SharedV1.Type.ProjectedCoordinate(other.LocalPosition);

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(LocalGeographicPosition);
                        hash.Add(LocalPosition);

                        return hash.ToHashCode();
                    }

                    public bool Equals(MachinePositionCoordinates other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.LocalGeographicPosition.Equals(other.LocalGeographicPosition) &&
                        this.LocalPosition.Equals(other.LocalPosition);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as MachinePositionCoordinates);

                    public override string ToString() => MachinePositionCoordinatesSupport.Instance.ToString(this);
                }

                public class BucketPositionCoordinates :  IEquatable<BucketPositionCoordinates>
                {
                    public Komatsu.Machine.SharedV1.Type.Coordinate BucketXZCoordinate { get; set; }

                    [Optional]
                    public Komatsu.Machine.SharedV1.Type.ProjectedCoordinate BucketLocalCoordinate { get; set; }

                    public BucketPositionCoordinates()
                    {
                        BucketXZCoordinate = new Komatsu.Machine.SharedV1.Type.Coordinate();
                    }

                    public BucketPositionCoordinates(Komatsu.Machine.SharedV1.Type.Coordinate  BucketXZCoordinate, Komatsu.Machine.SharedV1.Type.ProjectedCoordinate  BucketLocalCoordinate)
                    {
                        this.BucketXZCoordinate = BucketXZCoordinate;
                        this.BucketLocalCoordinate = BucketLocalCoordinate;
                    }

                    public BucketPositionCoordinates(BucketPositionCoordinates other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.BucketXZCoordinate = new Komatsu.Machine.SharedV1.Type.Coordinate(other.BucketXZCoordinate);
                        if(other.BucketLocalCoordinate != null)
                        {
                            this.BucketLocalCoordinate = new Komatsu.Machine.SharedV1.Type.ProjectedCoordinate(other.BucketLocalCoordinate);
                        }

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(BucketXZCoordinate);
                        hash.Add(BucketLocalCoordinate);

                        return hash.ToHashCode();
                    }

                    public bool Equals(BucketPositionCoordinates other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.BucketXZCoordinate.Equals(other.BucketXZCoordinate) &&
                        Equals(this.BucketLocalCoordinate, other.BucketLocalCoordinate);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as BucketPositionCoordinates);

                    public override string ToString() => BucketPositionCoordinatesSupport.Instance.ToString(this);
                }

                public class MachineOrientation :  IEquatable<MachineOrientation>
                {
                    [Optional]
                    public float? Yaw { get; set; }

                    [Optional]
                    public float? Pitch { get; set; }

                    [Optional]
                    public float? Roll { get; set; }

                    public MachineOrientation()
                    {
                    }

                    public MachineOrientation(float ?  Yaw, float ?  Pitch, float ?  Roll)
                    {
                        this.Yaw = Yaw;
                        this.Pitch = Pitch;
                        this.Roll = Roll;
                    }

                    public MachineOrientation(MachineOrientation other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.Yaw = other.Yaw;
                        this.Pitch = other.Pitch;
                        this.Roll = other.Roll;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(Yaw);
                        hash.Add(Pitch);
                        hash.Add(Roll);

                        return hash.ToHashCode();
                    }

                    public bool Equals(MachineOrientation other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return Equals(this.Yaw, other.Yaw) &&
                        Equals(this.Pitch, other.Pitch) &&
                        Equals(this.Roll, other.Roll);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as MachineOrientation);

                    public override string ToString() => MachineOrientationSupport.Instance.ToString(this);
                }

                public enum GPSFixType
                {
                    INVALID = 0,
                    FIX = 1,
                    DGPS = 2,
                    PPS = 3,
                    RTK = 4,
                    RTK_FLOAT = 5,
                    ESTIMATED = 6,
                    MANUAL = 7,
                    SIMULATION = 8
                }
                public class GPSQualityOfService :  IEquatable<GPSQualityOfService>
                {
                    public Komatsu.Machine.SharedV1.Type.GPSFixType FixType { get; set; }

                    public short NumberOfSatellites { get; set; }

                    public double PositionDilutionOfPrecision { get; set; }

                    public double HorizontalDilutionOfPrecision { get; set; }

                    public double VerticalDilutionOfPrecision { get; set; }

                    public GPSQualityOfService()
                    {
                        FixType = (Komatsu.Machine.SharedV1.Type.GPSFixType) 0;
                    }

                    public GPSQualityOfService(Komatsu.Machine.SharedV1.Type.GPSFixType  FixType, short  NumberOfSatellites, double  PositionDilutionOfPrecision, double  HorizontalDilutionOfPrecision, double  VerticalDilutionOfPrecision)
                    {
                        this.FixType = FixType;
                        this.NumberOfSatellites = NumberOfSatellites;
                        this.PositionDilutionOfPrecision = PositionDilutionOfPrecision;
                        this.HorizontalDilutionOfPrecision = HorizontalDilutionOfPrecision;
                        this.VerticalDilutionOfPrecision = VerticalDilutionOfPrecision;
                    }

                    public GPSQualityOfService(GPSQualityOfService other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.FixType = other.FixType;
                        this.NumberOfSatellites = other.NumberOfSatellites;
                        this.PositionDilutionOfPrecision = other.PositionDilutionOfPrecision;
                        this.HorizontalDilutionOfPrecision = other.HorizontalDilutionOfPrecision;
                        this.VerticalDilutionOfPrecision = other.VerticalDilutionOfPrecision;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(FixType);
                        hash.Add(NumberOfSatellites);
                        hash.Add(PositionDilutionOfPrecision);
                        hash.Add(HorizontalDilutionOfPrecision);
                        hash.Add(VerticalDilutionOfPrecision);

                        return hash.ToHashCode();
                    }

                    public bool Equals(GPSQualityOfService other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.FixType.Equals(other.FixType) &&
                        this.NumberOfSatellites.Equals(other.NumberOfSatellites) &&
                        this.PositionDilutionOfPrecision.Equals(other.PositionDilutionOfPrecision) &&
                        this.HorizontalDilutionOfPrecision.Equals(other.HorizontalDilutionOfPrecision) &&
                        this.VerticalDilutionOfPrecision.Equals(other.VerticalDilutionOfPrecision);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as GPSQualityOfService);

                    public override string ToString() => GPSQualityOfServiceSupport.Instance.ToString(this);
                }

                public class GPSData :  IEquatable<GPSData>
                {
                    [Bound(30)]
                    public string TimeUtc { get; set; } = string.Empty;

                    public Komatsu.Machine.SharedV1.Type.GeographicCoordinate AntennaGeoPosition { get; set; }

                    [Optional]
                    public Komatsu.Machine.SharedV1.Type.ProjectedCoordinate AntennaProjectedPosition { get; set; }

                    [Optional]
                    public float? GpsHeading { get; set; }

                    [Optional]
                    public float? GpsSpeed { get; set; }

                    [Optional]
                    public Komatsu.Machine.SharedV1.Type.GPSQualityOfService GpsQoS { get; set; }

                    public GPSData()
                    {
                        AntennaGeoPosition = new Komatsu.Machine.SharedV1.Type.GeographicCoordinate();
                    }

                    public GPSData(string  TimeUtc, Komatsu.Machine.SharedV1.Type.GeographicCoordinate  AntennaGeoPosition, Komatsu.Machine.SharedV1.Type.ProjectedCoordinate  AntennaProjectedPosition, float ?  GpsHeading, float ?  GpsSpeed, Komatsu.Machine.SharedV1.Type.GPSQualityOfService  GpsQoS)
                    {
                        this.TimeUtc = TimeUtc;
                        this.AntennaGeoPosition = AntennaGeoPosition;
                        this.AntennaProjectedPosition = AntennaProjectedPosition;
                        this.GpsHeading = GpsHeading;
                        this.GpsSpeed = GpsSpeed;
                        this.GpsQoS = GpsQoS;
                    }

                    public GPSData(GPSData other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.TimeUtc = other.TimeUtc;
                        this.AntennaGeoPosition = new Komatsu.Machine.SharedV1.Type.GeographicCoordinate(other.AntennaGeoPosition);
                        if(other.AntennaProjectedPosition != null)
                        {
                            this.AntennaProjectedPosition = new Komatsu.Machine.SharedV1.Type.ProjectedCoordinate(other.AntennaProjectedPosition);
                        }
                        this.GpsHeading = other.GpsHeading;
                        this.GpsSpeed = other.GpsSpeed;
                        if(other.GpsQoS != null)
                        {
                            this.GpsQoS = new Komatsu.Machine.SharedV1.Type.GPSQualityOfService(other.GpsQoS);
                        }

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(TimeUtc);
                        hash.Add(AntennaGeoPosition);
                        hash.Add(AntennaProjectedPosition);
                        hash.Add(GpsHeading);
                        hash.Add(GpsSpeed);
                        hash.Add(GpsQoS);

                        return hash.ToHashCode();
                    }

                    public bool Equals(GPSData other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.TimeUtc.Equals(other.TimeUtc) &&
                        this.AntennaGeoPosition.Equals(other.AntennaGeoPosition) &&
                        Equals(this.AntennaProjectedPosition, other.AntennaProjectedPosition) &&
                        Equals(this.GpsHeading, other.GpsHeading) &&
                        Equals(this.GpsSpeed, other.GpsSpeed) &&
                        Equals(this.GpsQoS, other.GpsQoS);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as GPSData);

                    public override string ToString() => GPSDataSupport.Instance.ToString(this);
                }

                public enum GPSQualityTypeEmun
                {
                    GOOD,
                    BAD,
                    DEGRADED_LOW_SATELLITES
                }
                public class GPSQualityData :  IEquatable<GPSQualityData>
                {
                    public Komatsu.Machine.SharedV1.Type.GPSQualityTypeEmun QualityType { get; set; }

                    public short NumberOfSatellites { get; set; }

                    public Komatsu.Machine.SharedV1.Type.GPSFixType FixType { get; set; }

                    public GPSQualityData()
                    {
                        QualityType = (Komatsu.Machine.SharedV1.Type.GPSQualityTypeEmun) 0;
                        FixType = (Komatsu.Machine.SharedV1.Type.GPSFixType) 0;
                    }

                    public GPSQualityData(Komatsu.Machine.SharedV1.Type.GPSQualityTypeEmun  QualityType, short  NumberOfSatellites, Komatsu.Machine.SharedV1.Type.GPSFixType  FixType)
                    {
                        this.QualityType = QualityType;
                        this.NumberOfSatellites = NumberOfSatellites;
                        this.FixType = FixType;
                    }

                    public GPSQualityData(GPSQualityData other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.QualityType = other.QualityType;
                        this.NumberOfSatellites = other.NumberOfSatellites;
                        this.FixType = other.FixType;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(QualityType);
                        hash.Add(NumberOfSatellites);
                        hash.Add(FixType);

                        return hash.ToHashCode();
                    }

                    public bool Equals(GPSQualityData other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.QualityType.Equals(other.QualityType) &&
                        this.NumberOfSatellites.Equals(other.NumberOfSatellites) &&
                        this.FixType.Equals(other.FixType);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as GPSQualityData);

                    public override string ToString() => GPSQualityDataSupport.Instance.ToString(this);
                }

            } // namespace Type
        } // namespace SharedV1
    } // namespace Machine
} // namespace Komatsu
