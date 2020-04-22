// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: animalai/communicator_objects/arenas_configurations_proto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AAIOCommunicators {

  /// <summary>Holder for reflection information generated from animalai/communicator_objects/arenas_configurations_proto.proto</summary>
  internal static partial class ArenasConfigurationsProtoReflection {

    #region Descriptor
    /// <summary>File descriptor for animalai/communicator_objects/arenas_configurations_proto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArenasConfigurationsProtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9hbmltYWxhaS9jb21tdW5pY2F0b3Jfb2JqZWN0cy9hcmVuYXNfY29uZmln",
            "dXJhdGlvbnNfcHJvdG8ucHJvdG8SFGNvbW11bmljYXRvcl9vYmplY3RzGj1h",
            "bmltYWxhaS9jb21tdW5pY2F0b3Jfb2JqZWN0cy9hcmVuYV9jb25maWd1cmF0",
            "aW9uX3Byb3RvLnByb3RvItQBChlBcmVuYXNDb25maWd1cmF0aW9uc1Byb3Rv",
            "EksKBmFyZW5hcxgBIAMoCzI7LmNvbW11bmljYXRvcl9vYmplY3RzLkFyZW5h",
            "c0NvbmZpZ3VyYXRpb25zUHJvdG8uQXJlbmFzRW50cnkSDAoEc2VlZBgCIAEo",
            "BRpcCgtBcmVuYXNFbnRyeRILCgNrZXkYASABKAUSPAoFdmFsdWUYAiABKAsy",
            "LS5jb21tdW5pY2F0b3Jfb2JqZWN0cy5BcmVuYUNvbmZpZ3VyYXRpb25Qcm90",
            "bzoCOAFCFKoCEUFBSU9Db21tdW5pY2F0b3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AAIOCommunicators.ArenaConfigurationProtoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AAIOCommunicators.ArenasConfigurationsProto), global::AAIOCommunicators.ArenasConfigurationsProto.Parser, new[]{ "Arenas", "Seed" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ArenasConfigurationsProto : pb::IMessage<ArenasConfigurationsProto> {
    private static readonly pb::MessageParser<ArenasConfigurationsProto> _parser = new pb::MessageParser<ArenasConfigurationsProto>(() => new ArenasConfigurationsProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArenasConfigurationsProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AAIOCommunicators.ArenasConfigurationsProtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArenasConfigurationsProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArenasConfigurationsProto(ArenasConfigurationsProto other) : this() {
      arenas_ = other.arenas_.Clone();
      seed_ = other.seed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArenasConfigurationsProto Clone() {
      return new ArenasConfigurationsProto(this);
    }

    /// <summary>Field number for the "arenas" field.</summary>
    public const int ArenasFieldNumber = 1;
    private static readonly pbc::MapField<int, global::AAIOCommunicators.ArenaConfigurationProto>.Codec _map_arenas_codec
        = new pbc::MapField<int, global::AAIOCommunicators.ArenaConfigurationProto>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::AAIOCommunicators.ArenaConfigurationProto.Parser), 10);
    private readonly pbc::MapField<int, global::AAIOCommunicators.ArenaConfigurationProto> arenas_ = new pbc::MapField<int, global::AAIOCommunicators.ArenaConfigurationProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::AAIOCommunicators.ArenaConfigurationProto> Arenas {
      get { return arenas_; }
    }

    /// <summary>Field number for the "seed" field.</summary>
    public const int SeedFieldNumber = 2;
    private int seed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Seed {
      get { return seed_; }
      set {
        seed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArenasConfigurationsProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArenasConfigurationsProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Arenas.Equals(other.Arenas)) return false;
      if (Seed != other.Seed) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Arenas.GetHashCode();
      if (Seed != 0) hash ^= Seed.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      arenas_.WriteTo(output, _map_arenas_codec);
      if (Seed != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Seed);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += arenas_.CalculateSize(_map_arenas_codec);
      if (Seed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Seed);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArenasConfigurationsProto other) {
      if (other == null) {
        return;
      }
      arenas_.Add(other.arenas_);
      if (other.Seed != 0) {
        Seed = other.Seed;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            arenas_.AddEntriesFrom(input, _map_arenas_codec);
            break;
          }
          case 16: {
            Seed = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
