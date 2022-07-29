
/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.Status.V1.idl
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
            namespace Type
            {
                public enum StatusEnum
                {
                    GOOD,
                    BAD,
                    DEGRADED
                }
            } // namespace Type
            namespace Message
            {
                public class StatusMessage :  IEquatable<StatusMessage>
                {
                    public Komatsu.Machine.StatusV1.Type.StatusEnum Status { get; set; }

                    public StatusMessage()
                    {
                        Status = (Komatsu.Machine.StatusV1.Type.StatusEnum) 0;
                    }

                    public StatusMessage(Komatsu.Machine.StatusV1.Type.StatusEnum  Status)
                    {
                        this.Status = Status;
                    }

                    public StatusMessage(StatusMessage other)
                    {
                        if (other == null)
                        {
                            return;
                        }

                        this.Status = other.Status;

                    }

                    public override int GetHashCode()
                    {
                        var hash = new HashCode();

                        hash.Add(Status);

                        return hash.ToHashCode();
                    }

                    public bool Equals(StatusMessage other)
                    {
                        if (other == null)
                        {
                            return false;
                        }

                        if (ReferenceEquals(this, other))
                        {
                            return true;
                        }

                        return this.Status.Equals(other.Status);
                    }

                    public override bool Equals(object obj) => this.Equals(obj as StatusMessage);

                    public override string ToString() => StatusMessageSupport.Instance.ToString(this);
                }

            } // namespace Message
        } // namespace StatusV1
    } // namespace Machine
} // namespace Komatsu
