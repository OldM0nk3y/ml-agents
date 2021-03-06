// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: animalai/communicator_objects/arena_configuration_proto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AAIOCommunicators {

  /// <summary>Holder for reflection information generated from animalai/communicator_objects/arena_configuration_proto.proto</summary>
  internal static partial class ArenaConfigurationProtoReflection {

    #region Descriptor
    /// <summary>File descriptor for animalai/communicator_objects/arena_configuration_proto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArenaConfigurationProtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1hbmltYWxhaS9jb21tdW5pY2F0b3Jfb2JqZWN0cy9hcmVuYV9jb25maWd1",
            "cmF0aW9uX3Byb3RvLnByb3RvEhRjb21tdW5pY2F0b3Jfb2JqZWN0cxo4YW5p",
            "bWFsYWkvY29tbXVuaWNhdG9yX29iamVjdHMvaXRlbXNfdG9fc3Bhd25fcHJv",
            "dG8ucHJvdG8igQEKF0FyZW5hQ29uZmlndXJhdGlvblByb3RvEgkKAXQYASAB",
            "KAUSEQoJcGFzc19tYXJrGAIgASgCEjUKBWl0ZW1zGAMgAygLMiYuY29tbXVu",
            "aWNhdG9yX29iamVjdHMuSXRlbVRvU3Bhd25Qcm90bxIRCglibGFja291dHMY",
            "BCADKAVCFKoCEUFBSU9Db21tdW5pY2F0b3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AAIOCommunicators.ItemsToSpawnProtoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AAIOCommunicators.ArenaConfigurationProto), global::AAIOCommunicators.ArenaConfigurationProto.Parser, new[]{ "T", "PassMark", "Items", "Blackouts" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ArenaConfigurationProto : pb::IMessage<ArenaConfigurationProto> {
    private static readonly pb::MessageParser<ArenaConfigurationProto> _parser = new pb::MessageParser<ArenaConfigurationProto>(() => new ArenaConfigurationProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArenaConfigurationProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AAIOCommunicators.ArenaConfigurationProtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArenaConfigurationProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArenaConfigurationProto(ArenaConfigurationProto other) : this() {
      t_ = other.t_;
      passMark_ = other.passMark_;
      items_ = other.items_.Clone();
      blackouts_ = other.blackouts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArenaConfigurationProto Clone() {
      return new ArenaConfigurationProto(this);
    }

    /// <summary>Field number for the "t" field.</summary>
    public const int TFieldNumber = 1;
    private int t_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int T {
      get { return t_; }
      set {
        t_ = value;
      }
    }

    /// <summary>Field number for the "pass_mark" field.</summary>
    public const int PassMarkFieldNumber = 2;
    private float passMark_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PassMark {
      get { return passMark_; }
      set {
        passMark_ = value;
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::AAIOCommunicators.ItemToSpawnProto> _repeated_items_codec
        = pb::FieldCodec.ForMessage(26, global::AAIOCommunicators.ItemToSpawnProto.Parser);
    private readonly pbc::RepeatedField<global::AAIOCommunicators.ItemToSpawnProto> items_ = new pbc::RepeatedField<global::AAIOCommunicators.ItemToSpawnProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AAIOCommunicators.ItemToSpawnProto> Items {
      get { return items_; }
    }

    /// <summary>Field number for the "blackouts" field.</summary>
    public const int BlackoutsFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_blackouts_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> blackouts_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Blackouts {
      get { return blackouts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArenaConfigurationProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArenaConfigurationProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (T != other.T) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PassMark, other.PassMark)) return false;
      if(!items_.Equals(other.items_)) return false;
      if(!blackouts_.Equals(other.blackouts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (T != 0) hash ^= T.GetHashCode();
      if (PassMark != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PassMark);
      hash ^= items_.GetHashCode();
      hash ^= blackouts_.GetHashCode();
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
      if (T != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(T);
      }
      if (PassMark != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(PassMark);
      }
      items_.WriteTo(output, _repeated_items_codec);
      blackouts_.WriteTo(output, _repeated_blackouts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (T != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(T);
      }
      if (PassMark != 0F) {
        size += 1 + 4;
      }
      size += items_.CalculateSize(_repeated_items_codec);
      size += blackouts_.CalculateSize(_repeated_blackouts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArenaConfigurationProto other) {
      if (other == null) {
        return;
      }
      if (other.T != 0) {
        T = other.T;
      }
      if (other.PassMark != 0F) {
        PassMark = other.PassMark;
      }
      items_.Add(other.items_);
      blackouts_.Add(other.blackouts_);
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
          case 8: {
            T = input.ReadInt32();
            break;
          }
          case 21: {
            PassMark = input.ReadFloat();
            break;
          }
          case 26: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
          case 34:
          case 32: {
            blackouts_.AddEntriesFrom(input, _repeated_blackouts_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
