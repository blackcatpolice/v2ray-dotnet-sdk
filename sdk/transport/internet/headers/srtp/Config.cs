// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: v2ray.com/core/transport/internet/headers/srtp/config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace V2Ray.Core.Transport.Internet.Headers.Srtp {

  /// <summary>Holder for reflection information generated from v2ray.com/core/transport/internet/headers/srtp/config.proto</summary>
  public static partial class ConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for v2ray.com/core/transport/internet/headers/srtp/config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjt2MnJheS5jb20vY29yZS90cmFuc3BvcnQvaW50ZXJuZXQvaGVhZGVycy9z",
            "cnRwL2NvbmZpZy5wcm90bxIqdjJyYXkuY29yZS50cmFuc3BvcnQuaW50ZXJu",
            "ZXQuaGVhZGVycy5zcnRwIncKBkNvbmZpZxIPCgd2ZXJzaW9uGAEgASgNEg8K",
            "B3BhZGRpbmcYAiABKAgSEQoJZXh0ZW5zaW9uGAMgASgIEhIKCmNzcmNfY291",
            "bnQYBCABKA0SDgoGbWFya2VyGAUgASgIEhQKDHBheWxvYWRfdHlwZRgGIAEo",
            "DUJlCi5jb20udjJyYXkuY29yZS50cmFuc3BvcnQuaW50ZXJuZXQuaGVhZGVy",
            "cy5zcnRwUAFaBHNydHCqAipWMlJheS5Db3JlLlRyYW5zcG9ydC5JbnRlcm5l",
            "dC5IZWFkZXJzLlNydHBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::V2Ray.Core.Transport.Internet.Headers.Srtp.Config), global::V2Ray.Core.Transport.Internet.Headers.Srtp.Config.Parser, new[]{ "Version", "Padding", "Extension", "CsrcCount", "Marker", "PayloadType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Config : pb::IMessage<Config> {
    private static readonly pb::MessageParser<Config> _parser = new pb::MessageParser<Config>(() => new Config());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Config> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::V2Ray.Core.Transport.Internet.Headers.Srtp.ConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Config() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Config(Config other) : this() {
      version_ = other.version_;
      padding_ = other.padding_;
      extension_ = other.extension_;
      csrcCount_ = other.csrcCount_;
      marker_ = other.marker_;
      payloadType_ = other.payloadType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Config Clone() {
      return new Config(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private uint version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "padding" field.</summary>
    public const int PaddingFieldNumber = 2;
    private bool padding_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Padding {
      get { return padding_; }
      set {
        padding_ = value;
      }
    }

    /// <summary>Field number for the "extension" field.</summary>
    public const int ExtensionFieldNumber = 3;
    private bool extension_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Extension {
      get { return extension_; }
      set {
        extension_ = value;
      }
    }

    /// <summary>Field number for the "csrc_count" field.</summary>
    public const int CsrcCountFieldNumber = 4;
    private uint csrcCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CsrcCount {
      get { return csrcCount_; }
      set {
        csrcCount_ = value;
      }
    }

    /// <summary>Field number for the "marker" field.</summary>
    public const int MarkerFieldNumber = 5;
    private bool marker_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Marker {
      get { return marker_; }
      set {
        marker_ = value;
      }
    }

    /// <summary>Field number for the "payload_type" field.</summary>
    public const int PayloadTypeFieldNumber = 6;
    private uint payloadType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint PayloadType {
      get { return payloadType_; }
      set {
        payloadType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Config);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Config other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (Padding != other.Padding) return false;
      if (Extension != other.Extension) return false;
      if (CsrcCount != other.CsrcCount) return false;
      if (Marker != other.Marker) return false;
      if (PayloadType != other.PayloadType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version != 0) hash ^= Version.GetHashCode();
      if (Padding != false) hash ^= Padding.GetHashCode();
      if (Extension != false) hash ^= Extension.GetHashCode();
      if (CsrcCount != 0) hash ^= CsrcCount.GetHashCode();
      if (Marker != false) hash ^= Marker.GetHashCode();
      if (PayloadType != 0) hash ^= PayloadType.GetHashCode();
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
      if (Version != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Version);
      }
      if (Padding != false) {
        output.WriteRawTag(16);
        output.WriteBool(Padding);
      }
      if (Extension != false) {
        output.WriteRawTag(24);
        output.WriteBool(Extension);
      }
      if (CsrcCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CsrcCount);
      }
      if (Marker != false) {
        output.WriteRawTag(40);
        output.WriteBool(Marker);
      }
      if (PayloadType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PayloadType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Version != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
      }
      if (Padding != false) {
        size += 1 + 1;
      }
      if (Extension != false) {
        size += 1 + 1;
      }
      if (CsrcCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CsrcCount);
      }
      if (Marker != false) {
        size += 1 + 1;
      }
      if (PayloadType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PayloadType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Config other) {
      if (other == null) {
        return;
      }
      if (other.Version != 0) {
        Version = other.Version;
      }
      if (other.Padding != false) {
        Padding = other.Padding;
      }
      if (other.Extension != false) {
        Extension = other.Extension;
      }
      if (other.CsrcCount != 0) {
        CsrcCount = other.CsrcCount;
      }
      if (other.Marker != false) {
        Marker = other.Marker;
      }
      if (other.PayloadType != 0) {
        PayloadType = other.PayloadType;
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
          case 8: {
            Version = input.ReadUInt32();
            break;
          }
          case 16: {
            Padding = input.ReadBool();
            break;
          }
          case 24: {
            Extension = input.ReadBool();
            break;
          }
          case 32: {
            CsrcCount = input.ReadUInt32();
            break;
          }
          case 40: {
            Marker = input.ReadBool();
            break;
          }
          case 48: {
            PayloadType = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
