using System.Runtime.Serialization;

namespace DataSerialization
{
  [DataContract]
  [KnownType(typeof(AppStateData))]
  class AppData
  {
    [DataMember]
    public int TheAnswer { get; set; }
    [DataMember]
    public AppStates State { get; set; }
    [DataMember]
    public object StateData { get; set; }

  }
}
