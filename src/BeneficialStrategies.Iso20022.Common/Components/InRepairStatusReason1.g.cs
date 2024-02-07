﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InRepairStatusReason1.  ISO2002 ID# _Ut7sx9p-Ed-ak6NoX_4Aeg_-41189078.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a status in repair.
/// </summary>
public partial record InRepairStatusReason1
     : IIsoXmlSerilizable<InRepairStatusReason1>
{
    #nullable enable
    
    /// <summary>
    /// Reason for an in repair status in free format text.
    /// </summary>
    public required IsoMax350Text AdditionalInformation { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalInformation)); // data type Max350Text System.String
        writer.WriteEndElement();
    }
    public static InRepairStatusReason1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
