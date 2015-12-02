using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Data {
    
    /// <summary>
    /// Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.
    /// </summary>
    /// <value>Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.</value>
    [DataMember(Name="data_id", EmitDefaultValue=false)]
    public string DataId { get; set; }

    
    /// <summary>
    /// Description of data.
    /// </summary>
    /// <value>Description of data.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    public string Description { get; set; }

    
    /// <summary>
    /// Display name of data.
    /// </summary>
    /// <value>Display name of data.</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    public string DisplayName { get; set; }

    
    /// <summary>
    /// Capacity of data.
    /// </summary>
    /// <value>Capacity of data.</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    public string Capacity { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Data {\n");
      
      sb.Append("  DataId: ").Append(DataId).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
