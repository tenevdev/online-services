// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gateway/gateway_internal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Improbable.OnlineServices.Proto.Gateway {

  /// <summary>Holder for reflection information generated from gateway/gateway_internal.proto</summary>
  public static partial class GatewayInternalReflection {

    #region Descriptor
    /// <summary>File descriptor for gateway/gateway_internal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GatewayInternalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5nYXRld2F5L2dhdGV3YXlfaW50ZXJuYWwucHJvdG8SB2dhdGV3YXkaEXBh",
            "cnR5L3BhcnR5LnByb3RvIsIBCgpBc3NpZ25tZW50EhsKBXBhcnR5GAEgASgL",
            "MgwucGFydHkuUGFydHkSKgoGcmVzdWx0GAIgASgOMhouZ2F0ZXdheS5Bc3Np",
            "Z25tZW50LlJlc3VsdBIVCg1kZXBsb3ltZW50X2lkGAMgASgJEhcKD2RlcGxv",
            "eW1lbnRfbmFtZRgEIAEoCSI7CgZSZXN1bHQSCwoHVU5LTk9XThAAEgsKB01B",
            "VENIRUQQARIJCgVFUlJPUhACEgwKCFJFUVVFVUVEEAMiRAoYQXNzaWduRGVw",
            "bG95bWVudHNSZXF1ZXN0EigKC2Fzc2lnbm1lbnRzGAEgAygLMhMuZ2F0ZXdh",
            "eS5Bc3NpZ25tZW50IhsKGUFzc2lnbkRlcGxveW1lbnRzUmVzcG9uc2UiPQoY",
            "UG9wV2FpdGluZ1BhcnRpZXNSZXF1ZXN0EgwKBHR5cGUYASABKAkSEwoLbnVt",
            "X3BhcnRpZXMYAiABKA0ikwEKDFdhaXRpbmdQYXJ0eRIbCgVwYXJ0eRgBIAEo",
            "CzIMLnBhcnR5LlBhcnR5EjUKCG1ldGFkYXRhGAIgAygLMiMuZ2F0ZXdheS5X",
            "YWl0aW5nUGFydHkuTWV0YWRhdGFFbnRyeRovCg1NZXRhZGF0YUVudHJ5EgsK",
            "A2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAEiQwoZUG9wV2FpdGluZ1Bh",
            "cnRpZXNSZXNwb25zZRImCgdwYXJ0aWVzGAEgAygLMhUuZ2F0ZXdheS5XYWl0",
            "aW5nUGFydHky0AEKFkdhdGV3YXlJbnRlcm5hbFNlcnZpY2USWgoRQXNzaWdu",
            "RGVwbG95bWVudHMSIS5nYXRld2F5LkFzc2lnbkRlcGxveW1lbnRzUmVxdWVz",
            "dBoiLmdhdGV3YXkuQXNzaWduRGVwbG95bWVudHNSZXNwb25zZRJaChFQb3BX",
            "YWl0aW5nUGFydGllcxIhLmdhdGV3YXkuUG9wV2FpdGluZ1BhcnRpZXNSZXF1",
            "ZXN0GiIuZ2F0ZXdheS5Qb3BXYWl0aW5nUGFydGllc1Jlc3BvbnNlQiqqAidJ",
            "bXByb2JhYmxlLk9ubGluZVNlcnZpY2VzLlByb3RvLkdhdGV3YXliBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Improbable.OnlineServices.Proto.Party.PartyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.Assignment), global::Improbable.OnlineServices.Proto.Gateway.Assignment.Parser, new[]{ "Party", "Result", "DeploymentId", "DeploymentName" }, null, new[]{ typeof(global::Improbable.OnlineServices.Proto.Gateway.Assignment.Types.Result) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.AssignDeploymentsRequest), global::Improbable.OnlineServices.Proto.Gateway.AssignDeploymentsRequest.Parser, new[]{ "Assignments" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.AssignDeploymentsResponse), global::Improbable.OnlineServices.Proto.Gateway.AssignDeploymentsResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.PopWaitingPartiesRequest), global::Improbable.OnlineServices.Proto.Gateway.PopWaitingPartiesRequest.Parser, new[]{ "Type", "NumParties" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.WaitingParty), global::Improbable.OnlineServices.Proto.Gateway.WaitingParty.Parser, new[]{ "Party", "Metadata" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.PopWaitingPartiesResponse), global::Improbable.OnlineServices.Proto.Gateway.PopWaitingPartiesResponse.Parser, new[]{ "Parties" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Assignment : pb::IMessage<Assignment> {
    private static readonly pb::MessageParser<Assignment> _parser = new pb::MessageParser<Assignment>(() => new Assignment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Assignment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayInternalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Assignment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Assignment(Assignment other) : this() {
      party_ = other.party_ != null ? other.party_.Clone() : null;
      result_ = other.result_;
      deploymentId_ = other.deploymentId_;
      deploymentName_ = other.deploymentName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Assignment Clone() {
      return new Assignment(this);
    }

    /// <summary>Field number for the "party" field.</summary>
    public const int PartyFieldNumber = 1;
    private global::Improbable.OnlineServices.Proto.Party.Party party_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Improbable.OnlineServices.Proto.Party.Party Party {
      get { return party_; }
      set {
        party_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 2;
    private global::Improbable.OnlineServices.Proto.Gateway.Assignment.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Improbable.OnlineServices.Proto.Gateway.Assignment.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "deployment_id" field.</summary>
    public const int DeploymentIdFieldNumber = 3;
    private string deploymentId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeploymentId {
      get { return deploymentId_; }
      set {
        deploymentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deployment_name" field.</summary>
    public const int DeploymentNameFieldNumber = 4;
    private string deploymentName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeploymentName {
      get { return deploymentName_; }
      set {
        deploymentName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Assignment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Assignment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Party, other.Party)) return false;
      if (Result != other.Result) return false;
      if (DeploymentId != other.DeploymentId) return false;
      if (DeploymentName != other.DeploymentName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (party_ != null) hash ^= Party.GetHashCode();
      if (Result != 0) hash ^= Result.GetHashCode();
      if (DeploymentId.Length != 0) hash ^= DeploymentId.GetHashCode();
      if (DeploymentName.Length != 0) hash ^= DeploymentName.GetHashCode();
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
      if (party_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Party);
      }
      if (Result != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Result);
      }
      if (DeploymentId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DeploymentId);
      }
      if (DeploymentName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DeploymentName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (party_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Party);
      }
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (DeploymentId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeploymentId);
      }
      if (DeploymentName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeploymentName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Assignment other) {
      if (other == null) {
        return;
      }
      if (other.party_ != null) {
        if (party_ == null) {
          party_ = new global::Improbable.OnlineServices.Proto.Party.Party();
        }
        Party.MergeFrom(other.Party);
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.DeploymentId.Length != 0) {
        DeploymentId = other.DeploymentId;
      }
      if (other.DeploymentName.Length != 0) {
        DeploymentName = other.DeploymentName;
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
            if (party_ == null) {
              party_ = new global::Improbable.OnlineServices.Proto.Party.Party();
            }
            input.ReadMessage(party_);
            break;
          }
          case 16: {
            result_ = (global::Improbable.OnlineServices.Proto.Gateway.Assignment.Types.Result) input.ReadEnum();
            break;
          }
          case 26: {
            DeploymentId = input.ReadString();
            break;
          }
          case 34: {
            DeploymentName = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Assignment message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("MATCHED")] Matched = 1,
        [pbr::OriginalName("ERROR")] Error = 2,
        [pbr::OriginalName("REQUEUED")] Requeued = 3,
      }

    }
    #endregion

  }

  public sealed partial class AssignDeploymentsRequest : pb::IMessage<AssignDeploymentsRequest> {
    private static readonly pb::MessageParser<AssignDeploymentsRequest> _parser = new pb::MessageParser<AssignDeploymentsRequest>(() => new AssignDeploymentsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AssignDeploymentsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayInternalReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssignDeploymentsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssignDeploymentsRequest(AssignDeploymentsRequest other) : this() {
      assignments_ = other.assignments_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssignDeploymentsRequest Clone() {
      return new AssignDeploymentsRequest(this);
    }

    /// <summary>Field number for the "assignments" field.</summary>
    public const int AssignmentsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Improbable.OnlineServices.Proto.Gateway.Assignment> _repeated_assignments_codec
        = pb::FieldCodec.ForMessage(10, global::Improbable.OnlineServices.Proto.Gateway.Assignment.Parser);
    private readonly pbc::RepeatedField<global::Improbable.OnlineServices.Proto.Gateway.Assignment> assignments_ = new pbc::RepeatedField<global::Improbable.OnlineServices.Proto.Gateway.Assignment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Improbable.OnlineServices.Proto.Gateway.Assignment> Assignments {
      get { return assignments_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AssignDeploymentsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AssignDeploymentsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!assignments_.Equals(other.assignments_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= assignments_.GetHashCode();
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
      assignments_.WriteTo(output, _repeated_assignments_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += assignments_.CalculateSize(_repeated_assignments_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AssignDeploymentsRequest other) {
      if (other == null) {
        return;
      }
      assignments_.Add(other.assignments_);
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
            assignments_.AddEntriesFrom(input, _repeated_assignments_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class AssignDeploymentsResponse : pb::IMessage<AssignDeploymentsResponse> {
    private static readonly pb::MessageParser<AssignDeploymentsResponse> _parser = new pb::MessageParser<AssignDeploymentsResponse>(() => new AssignDeploymentsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AssignDeploymentsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayInternalReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssignDeploymentsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssignDeploymentsResponse(AssignDeploymentsResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssignDeploymentsResponse Clone() {
      return new AssignDeploymentsResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AssignDeploymentsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AssignDeploymentsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AssignDeploymentsResponse other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class PopWaitingPartiesRequest : pb::IMessage<PopWaitingPartiesRequest> {
    private static readonly pb::MessageParser<PopWaitingPartiesRequest> _parser = new pb::MessageParser<PopWaitingPartiesRequest>(() => new PopWaitingPartiesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PopWaitingPartiesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayInternalReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PopWaitingPartiesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PopWaitingPartiesRequest(PopWaitingPartiesRequest other) : this() {
      type_ = other.type_;
      numParties_ = other.numParties_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PopWaitingPartiesRequest Clone() {
      return new PopWaitingPartiesRequest(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "num_parties" field.</summary>
    public const int NumPartiesFieldNumber = 2;
    private uint numParties_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint NumParties {
      get { return numParties_; }
      set {
        numParties_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PopWaitingPartiesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PopWaitingPartiesRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (NumParties != other.NumParties) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (NumParties != 0) hash ^= NumParties.GetHashCode();
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
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (NumParties != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(NumParties);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (NumParties != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NumParties);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PopWaitingPartiesRequest other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.NumParties != 0) {
        NumParties = other.NumParties;
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
            Type = input.ReadString();
            break;
          }
          case 16: {
            NumParties = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class WaitingParty : pb::IMessage<WaitingParty> {
    private static readonly pb::MessageParser<WaitingParty> _parser = new pb::MessageParser<WaitingParty>(() => new WaitingParty());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WaitingParty> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayInternalReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WaitingParty() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WaitingParty(WaitingParty other) : this() {
      party_ = other.party_ != null ? other.party_.Clone() : null;
      metadata_ = other.metadata_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WaitingParty Clone() {
      return new WaitingParty(this);
    }

    /// <summary>Field number for the "party" field.</summary>
    public const int PartyFieldNumber = 1;
    private global::Improbable.OnlineServices.Proto.Party.Party party_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Improbable.OnlineServices.Proto.Party.Party Party {
      get { return party_; }
      set {
        party_ = value;
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_metadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 18);
    private readonly pbc::MapField<string, string> metadata_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Metadata {
      get { return metadata_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WaitingParty);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WaitingParty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Party, other.Party)) return false;
      if (!Metadata.Equals(other.Metadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (party_ != null) hash ^= Party.GetHashCode();
      hash ^= Metadata.GetHashCode();
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
      if (party_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Party);
      }
      metadata_.WriteTo(output, _map_metadata_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (party_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Party);
      }
      size += metadata_.CalculateSize(_map_metadata_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WaitingParty other) {
      if (other == null) {
        return;
      }
      if (other.party_ != null) {
        if (party_ == null) {
          party_ = new global::Improbable.OnlineServices.Proto.Party.Party();
        }
        Party.MergeFrom(other.Party);
      }
      metadata_.Add(other.metadata_);
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
            if (party_ == null) {
              party_ = new global::Improbable.OnlineServices.Proto.Party.Party();
            }
            input.ReadMessage(party_);
            break;
          }
          case 18: {
            metadata_.AddEntriesFrom(input, _map_metadata_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PopWaitingPartiesResponse : pb::IMessage<PopWaitingPartiesResponse> {
    private static readonly pb::MessageParser<PopWaitingPartiesResponse> _parser = new pb::MessageParser<PopWaitingPartiesResponse>(() => new PopWaitingPartiesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PopWaitingPartiesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayInternalReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PopWaitingPartiesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PopWaitingPartiesResponse(PopWaitingPartiesResponse other) : this() {
      parties_ = other.parties_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PopWaitingPartiesResponse Clone() {
      return new PopWaitingPartiesResponse(this);
    }

    /// <summary>Field number for the "parties" field.</summary>
    public const int PartiesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Improbable.OnlineServices.Proto.Gateway.WaitingParty> _repeated_parties_codec
        = pb::FieldCodec.ForMessage(10, global::Improbable.OnlineServices.Proto.Gateway.WaitingParty.Parser);
    private readonly pbc::RepeatedField<global::Improbable.OnlineServices.Proto.Gateway.WaitingParty> parties_ = new pbc::RepeatedField<global::Improbable.OnlineServices.Proto.Gateway.WaitingParty>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Improbable.OnlineServices.Proto.Gateway.WaitingParty> Parties {
      get { return parties_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PopWaitingPartiesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PopWaitingPartiesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!parties_.Equals(other.parties_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= parties_.GetHashCode();
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
      parties_.WriteTo(output, _repeated_parties_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += parties_.CalculateSize(_repeated_parties_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PopWaitingPartiesResponse other) {
      if (other == null) {
        return;
      }
      parties_.Add(other.parties_);
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
            parties_.AddEntriesFrom(input, _repeated_parties_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code