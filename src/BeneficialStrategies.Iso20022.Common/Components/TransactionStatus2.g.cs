﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionStatus2.  ISO2002 ID# _Ut7swNp-Ed-ak6NoX_4Aeg_97707535.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the future status of the transaction by means of a code and a period.
/// </summary>
public partial record TransactionStatus2
     : IIsoXmlSerilizable<TransactionStatus2>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    public required BaselineStatus1Code Status { get; init; } 
    /// <summary>
    /// Date and time at which the current status will change.
    /// </summary>
    public required IsoISODateTime ChangeDateTime { get; init; } 
    
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
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        writer.WriteValue(Status.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ChngDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(ChangeDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
    }
    public static TransactionStatus2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
