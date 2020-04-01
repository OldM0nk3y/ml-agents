// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: animalai/communicator_objects/items_to_spawn_proto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AAIOCommunicators {

  /// <summary>Holder for reflection information generated from animalai/communicator_objects/items_to_spawn_proto.proto</summary>
  internal static partial class ItemsToSpawnProtoReflection {

    #region Descriptor
    /// <summary>File descriptor for animalai/communicator_objects/items_to_spawn_proto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemsToSpawnProtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhhbmltYWxhaS9jb21tdW5pY2F0b3Jfb2JqZWN0cy9pdGVtc190b19zcGF3",
            "bl9wcm90by5wcm90bxIUY29tbXVuaWNhdG9yX29iamVjdHMaMGFuaW1hbGFp",
            "L2NvbW11bmljYXRvcl9vYmplY3RzL3ZlY3Rvcl9wcm90by5wcm90byLOAQoQ",
            "SXRlbVRvU3Bhd25Qcm90bxIMCgRuYW1lGAEgASgJEjQKCXBvc2l0aW9ucxgD",
            "IAMoCzIhLmNvbW11bmljYXRvcl9vYmplY3RzLlZlY3RvclByb3RvEhEKCXJv",
            "dGF0aW9ucxgEIAMoAhIwCgVzaXplcxgFIAMoCzIhLmNvbW11bmljYXRvcl9v",
            "YmplY3RzLlZlY3RvclByb3RvEjEKBmNvbG9ycxgGIAMoCzIhLmNvbW11bmlj",
            "YXRvcl9vYmplY3RzLlZlY3RvclByb3RvQhSqAhFBQUlPQ29tbXVuaWNhdG9y",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AAIOCommunicators.VectorProtoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AAIOCommunicators.ItemToSpawnProto), global::AAIOCommunicators.ItemToSpawnProto.Parser, new[]{ "Name", "Positions", "Rotations", "Sizes", "Colors" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ItemToSpawnProto : pb::IMessage<ItemToSpawnProto> {
    private static readonly pb::MessageParser<ItemToSpawnProto> _parser = new pb::MessageParser<ItemToSpawnProto>(() => new ItemToSpawnProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ItemToSpawnProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AAIOCommunicators.ItemsToSpawnProtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemToSpawnProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemToSpawnProto(ItemToSpawnProto other) : this() {
      name_ = other.name_;
      positions_ = other.positions_.Clone();
      rotations_ = other.rotations_.Clone();
      sizes_ = other.sizes_.Clone();
      colors_ = other.colors_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemToSpawnProto Clone() {
      return new ItemToSpawnProto(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "positions" field.</summary>
    public const int PositionsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::AAIOCommunicators.VectorProto> _repeated_positions_codec
        = pb::FieldCodec.ForMessage(26, global::AAIOCommunicators.VectorProto.Parser);
    private readonly pbc::RepeatedField<global::AAIOCommunicators.VectorProto> positions_ = new pbc::RepeatedField<global::AAIOCommunicators.VectorProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AAIOCommunicators.VectorProto> Positions {
      get { return positions_; }
    }

    /// <summary>Field number for the "rotations" field.</summary>
    public const int RotationsFieldNumber = 4;
    private static readonly pb::FieldCodec<float> _repeated_rotations_codec
        = pb::FieldCodec.ForFloat(34);
    private readonly pbc::RepeatedField<float> rotations_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Rotations {
      get { return rotations_; }
    }

    /// <summary>Field number for the "sizes" field.</summary>
    public const int SizesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::AAIOCommunicators.VectorProto> _repeated_sizes_codec
        = pb::FieldCodec.ForMessage(42, global::AAIOCommunicators.VectorProto.Parser);
    private readonly pbc::RepeatedField<global::AAIOCommunicators.VectorProto> sizes_ = new pbc::RepeatedField<global::AAIOCommunicators.VectorProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AAIOCommunicators.VectorProto> Sizes {
      get { return sizes_; }
    }

    /// <summary>Field number for the "colors" field.</summary>
    public const int ColorsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::AAIOCommunicators.VectorProto> _repeated_colors_codec
        = pb::FieldCodec.ForMessage(50, global::AAIOCommunicators.VectorProto.Parser);
    private readonly pbc::RepeatedField<global::AAIOCommunicators.VectorProto> colors_ = new pbc::RepeatedField<global::AAIOCommunicators.VectorProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AAIOCommunicators.VectorProto> Colors {
      get { return colors_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ItemToSpawnProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ItemToSpawnProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!positions_.Equals(other.positions_)) return false;
      if(!rotations_.Equals(other.rotations_)) return false;
      if(!sizes_.Equals(other.sizes_)) return false;
      if(!colors_.Equals(other.colors_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= positions_.GetHashCode();
      hash ^= rotations_.GetHashCode();
      hash ^= sizes_.GetHashCode();
      hash ^= colors_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      positions_.WriteTo(output, _repeated_positions_codec);
      rotations_.WriteTo(output, _repeated_rotations_codec);
      sizes_.WriteTo(output, _repeated_sizes_codec);
      colors_.WriteTo(output, _repeated_colors_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += positions_.CalculateSize(_repeated_positions_codec);
      size += rotations_.CalculateSize(_repeated_rotations_codec);
      size += sizes_.CalculateSize(_repeated_sizes_codec);
      size += colors_.CalculateSize(_repeated_colors_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ItemToSpawnProto other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      positions_.Add(other.positions_);
      rotations_.Add(other.rotations_);
      sizes_.Add(other.sizes_);
      colors_.Add(other.colors_);
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
            Name = input.ReadString();
            break;
          }
          case 26: {
            positions_.AddEntriesFrom(input, _repeated_positions_codec);
            break;
          }
          case 34:
          case 37: {
            rotations_.AddEntriesFrom(input, _repeated_rotations_codec);
            break;
          }
          case 42: {
            sizes_.AddEntriesFrom(input, _repeated_sizes_codec);
            break;
          }
          case 50: {
            colors_.AddEntriesFrom(input, _repeated_colors_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
