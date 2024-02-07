﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionStatus3.  ISO2002 ID# _RKFyk9p-Ed-ak6NoX_4Aeg_-489445133.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the status of the transaction by means of a code.
/// </summary>
public partial record TransactionStatus3
     : IIsoXmlSerilizable<TransactionStatus3>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    public required BaselineStatus2Code Status { get; init; } 
    
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
    }
    public static TransactionStatus3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
