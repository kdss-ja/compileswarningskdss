/*
WARNING: THIS FILE IS AUTO-GENERATED. DO NOT MODIFY.

This file was generated from Machine.Status.V1.idl
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

            namespace Type
            {

                namespace Implementation
                {
                    internal class StatusEnumPlugin : Rti.Dds.NativeInterface.TypePlugin.EnumTypePlugin
                    {
                        public StatusEnumPlugin() : base(CreateDynamicType(isPublic: false))
                        {
                        }

                        internal static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            return dtf.BuildEnum()
                            .WithName("Komatsu::Machine::StatusV1::Type::StatusEnum")
                            .AddMember(new EnumMember("GOOD", 0))
                            .AddMember(new EnumMember("BAD", 1))
                            .AddMember(new EnumMember("DEGRADED", 2))
                            .WithExtensibility(ExtensibilityKind.Extensible)
                            .Create();
                        }
                    }
                }

                public class StatusEnumSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.StatusV1.Type.StatusEnum>
                {
                    public StatusEnumSupport() : base(
                        new Implementation.StatusEnumPlugin(),
                        new Lazy<DynamicType>(() =>Implementation.StatusEnumPlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static StatusEnumSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<StatusEnumSupport, Komatsu.Machine.StatusV1.Type.StatusEnum>();
                }

            } // namespace Type

            namespace Message
            {

                namespace Implementation
                {
                    public struct StatusMessageUnmanaged : Rti.Dds.NativeInterface.TypePlugin.INativeTopicType<Komatsu.Machine.StatusV1.Message.StatusMessage>
                    {

                        private Komatsu.Machine.StatusV1.Type.StatusEnum Status;

                        public void Destroy(bool optionalsOnly)
                        {
                        }

                        public void FromNative(Komatsu.Machine.StatusV1.Message.StatusMessage sample, bool keysOnly = false)
                        {

                            sample.Status = Status;
                        }

                        public void Initialize(bool allocatePointers = true, bool allocateMemory = true)
                        {
                            Status = (Komatsu.Machine.StatusV1.Type.StatusEnum) 0;
                        }

                        public void ToNative(Komatsu.Machine.StatusV1.Message.StatusMessage sample, bool keysOnly = false)
                        {
                            Status = sample.Status;
                        }
                    }

                    internal class StatusMessagePlugin : Rti.Dds.NativeInterface.TypePlugin.InterpretedTypePlugin<Komatsu.Machine.StatusV1.Message.StatusMessage, StatusMessageUnmanaged>
                    {
                        internal StatusMessagePlugin() : base("Komatsu.Machine.StatusV1.Message.StatusMessage", isKeyed: false, CreateDynamicType(isPublic: false))
                        {
                        }

                        public static DynamicType CreateDynamicType(bool isPublic = true)
                        {
                            var dtf = ServiceEnvironment.Instance.Internal.GetTypeFactory(isPublic);
                            var tsf = ServiceEnvironment.Instance.Internal.TypeSupportFactory;

                            // StatusMessage struct
                            var StatusMessageStructMembers = new StructMember[]
                            {
                                new StructMember("Status", Komatsu.Machine.StatusV1.Type.StatusEnumSupport.Instance.GetDynamicTypeInternal(isPublic), id: 0)
                            };

                            return tsf.CreateTypeWithAccessInfo<StatusMessageUnmanaged>(
                                dtf.BuildStruct()
                                .WithExtensibility(ExtensibilityKind.Extensible)
                                .WithName("Komatsu::Machine::StatusV1::Message::StatusMessage")
                                .AddMembers(StatusMessageStructMembers));
                        }
                    }
                }

                public class StatusMessageSupport : Rti.Dds.Topics.TypeSupport<Komatsu.Machine.StatusV1.Message.StatusMessage>
                {
                    public StatusMessageSupport() : base(
                        new Implementation.StatusMessagePlugin(),
                        new Lazy<DynamicType>(() =>Implementation.StatusMessagePlugin.CreateDynamicType(isPublic: true)))
                    {
                    }

                    public static StatusMessageSupport Instance { get; } =
                    ServiceEnvironment.Instance.Internal.TypeSupportFactory.CreateTypeSupport<StatusMessageSupport, Komatsu.Machine.StatusV1.Message.StatusMessage>();
                }

            } // namespace Message

        } // namespace StatusV1

    } // namespace Machine

} // namespace Komatsu

