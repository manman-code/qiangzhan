//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: message_other.hxx
// Note: requires additional types generated from: message_guid.hxx
// Note: requires additional types generated from: message_property.hxx
namespace Message
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"msg_other_player_request")]
  public partial class msg_other_player_request : global::ProtoBuf.IExtensible
  {
    public msg_other_player_request() {}
    
    private ulong _guid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong guid
    {
      get { return _guid; }
      set { _guid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"msg_other_player_respond")]
  public partial class msg_other_player_respond : global::ProtoBuf.IExtensible
  {
    public msg_other_player_respond() {}
    
    private ulong _guid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong guid
    {
      get { return _guid; }
      set { _guid = value; }
    }
    private uint _errorcode;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"errorcode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint errorcode
    {
      get { return _errorcode; }
      set { _errorcode = value; }
    }

    private role_property _pro = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pro", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public role_property pro
    {
      get { return _pro; }
      set { _pro = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}