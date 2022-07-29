
/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.Postioning.V1.idl
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
        namespace EquipmentPositioningV1
        {
            namespace Message
            {
                public class EquipmentPositioning :  IEquatable<EquipmentPositioning>
                {
                    [Bound(30)]
                    public string TimeUtc { get; set; } = string.Empty;

                    public Komatsu.Machine.SharedV1.Type.MachineTypeEnum MachineType { get; set; }

                    public Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates Position { get; set; }

                    [Optional]
                    public Komatsu.Machine.SharedV1.Type.MachineOrientation Orientation { get; set; }

                    [Optional]
                    public Komatsu.Machine.SharedV1.Type.GPSQualityData GPSQuality { get; set; }

                    [Optional]
                    public double? Speed { get; set; }

                    [Optional]
                    public double? Heading { get; set; }

                    public EquipmentPositioning()
                    {
                        MachineType = (Komatsu.Machine.SharedV1.Type.MachineTypeEnum) 0;
                        Position = new Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates();
                    }

                    public EquipmentPositioning(string  TimeUtc, Komatsu.Machine.SharedV1.Type.MachineTypeEnum  MachineType, Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates  Position, Komatsu.Machine.SharedV1.Type.MachineOrientation  Orientation, Komatsu.Machine.SharedV1.Type.GPSQualityData  GPSQuality, double ?  Speed, double ?  Heading)
                    {
                        this.TimeUtc = TimeUtc;
                        this.MachineType = MachineType;
                        this.Position = Position;
                        this.Orientation = Orientation;
                        this.GPSQuality = GPSQuality;
                        this.Speed = Speed;
                        this.Heading = Heading;
                    }

                    public EquipmentPositioning(EquipmentPositioning other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.TimeUtc = other.TimeUtc;
                        this.MachineType = other.MachineType;
                        this.Position = new Komatsu.Machine.SharedV1.Type.MachinePositionCoordinates(other.Position);
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

                        hash.Add(TimeUtc);
                        hash.Add(MachineType);
                        hash.Add(Position);
                        hash.Add(Orientation);
                        hash.Add(GPSQuality);
                        hash.Add(Speed);
                        hash.Add(Heading);

                        return hash.ToHashCode();
                    }

                    public bool Equals(EquipmentPositioning other)
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
                        this.MachineType.Equals(other.MachineType) &&
                        this.Position.Equals(other.Position) &&
                        Equals(this.Orientation, other.Orientation) &&
                        Equals(this.GPSQuality, other.GPSQuality) &&
                        Equals(this.Speed, other.Speed) &&
                        Equals(this.Heading, other.Heading);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as EquipmentPositioning);

                    public override string ToString() => EquipmentPositioningSupport.Instance.ToString(this);
                }

            } // namespace Message
        } // namespace EquipmentPositioningV1
    } // namespace Machine
} // namespace Komatsu
