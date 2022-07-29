
/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.Status.V1.Guidance.idl
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
        namespace StatusV1
        {
            namespace Guidance
            {
                namespace Type
                {
                    public enum GnssFix
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
                    public enum KinematicSolutionQuality
                    {
                        NOT_AVAILABLE,
                        AVAILABLE
                    }
                    public class GnssQualityInfo :  IEquatable<GnssQualityInfo>
                    {
                        public short NumberOfSatellites { get; set; }

                        public Komatsu.Machine.StatusV1.Guidance.Type.GnssFix FixType { get; set; }

                        public GnssQualityInfo()
                        {
                            FixType = (Komatsu.Machine.StatusV1.Guidance.Type.GnssFix) 0;
                        }

                        public GnssQualityInfo(short  NumberOfSatellites, Komatsu.Machine.StatusV1.Guidance.Type.GnssFix  FixType)
                        {
                            this.NumberOfSatellites = NumberOfSatellites;
                            this.FixType = FixType;
                        }

                        public GnssQualityInfo(GnssQualityInfo other)
                        {
                            if (other == null)
                            {
                                return;
                            }

                            this.NumberOfSatellites = other.NumberOfSatellites;
                            this.FixType = other.FixType;

                        }

                        public override int GetHashCode()
                        {
                            var hash = new HashCode();

                            hash.Add(NumberOfSatellites);
                            hash.Add(FixType);

                            return hash.ToHashCode();
                        }

                        public bool Equals(GnssQualityInfo other)
                        {
                            if (other == null)
                            {
                                return false;
                            }

                            if (ReferenceEquals(this, other))
                            {
                                return true;
                            }

                            return this.NumberOfSatellites.Equals(other.NumberOfSatellites) &&
                            this.FixType.Equals(other.FixType);
                        }

                        public override bool Equals(object obj) => this.Equals(obj as GnssQualityInfo);

                        public override string ToString() => GnssQualityInfoSupport.Instance.ToString(this);
                    }

                } // namespace Type
                namespace Message
                {
                    public class GuidanceStatusMessage :  Komatsu.Machine.StatusV1.Message.StatusMessage, IEquatable<GuidanceStatusMessage>
                    {
                        public Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo GnssQuality { get; set; }

                        public Komatsu.Machine.StatusV1.Guidance.Type.KinematicSolutionQuality KinematicSolution { get; set; }

                        public GuidanceStatusMessage()
                        {
                            GnssQuality = new Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo();
                            KinematicSolution = (Komatsu.Machine.StatusV1.Guidance.Type.KinematicSolutionQuality) 0;
                        }

                        public GuidanceStatusMessage(Komatsu.Machine.StatusV1.Type.StatusEnum  Status,  Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo  GnssQuality, Komatsu.Machine.StatusV1.Guidance.Type.KinematicSolutionQuality  KinematicSolution) : base(Status)
                        {
                            this.GnssQuality = GnssQuality;
                            this.KinematicSolution = KinematicSolution;
                        }

                        public GuidanceStatusMessage(GuidanceStatusMessage other) : base(other)
                        {
                            if (other == null)
                            {
                                return;
                            }

                            this.GnssQuality = new Komatsu.Machine.StatusV1.Guidance.Type.GnssQualityInfo(other.GnssQuality);
                            this.KinematicSolution = other.KinematicSolution;

                        }

                        public override int GetHashCode()
                        {
                            var hash = new HashCode();

                            hash.Add(base.GetHashCode());

                            hash.Add(GnssQuality);
                            hash.Add(KinematicSolution);

                            return hash.ToHashCode();
                        }

                        public bool Equals(GuidanceStatusMessage other)
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

                            return this.GnssQuality.Equals(other.GnssQuality) &&
                            this.KinematicSolution.Equals(other.KinematicSolution);
                        }

                        public override bool Equals(object obj) => this.Equals(obj as GuidanceStatusMessage);

                        public override string ToString() => GuidanceStatusMessageSupport.Instance.ToString(this);
                    }

                } // namespace Message
            } // namespace Guidance
        } // namespace StatusV1
    } // namespace Machine
} // namespace Komatsu
