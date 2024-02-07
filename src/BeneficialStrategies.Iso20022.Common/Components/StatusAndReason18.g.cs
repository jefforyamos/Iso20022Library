﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusAndReason18.  ISO2002 ID# _Dl-9wSRhEeO8sskhVI3IDA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of an instructed order.
/// </summary>
public partial record StatusAndReason18
     : IIsoXmlSerilizable<StatusAndReason18>
{
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    public required Status15Choice_ StatusAndReason { get; init; } 
    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    public Transaction35? Transaction { get; init; } 
    
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
        writer.WriteStartElement(null, "StsAndRsn", xmlNamespace );
        StatusAndReason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Transaction is Transaction35 TransactionValue)
        {
            writer.WriteStartElement(null, "Tx", xmlNamespace );
            TransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static StatusAndReason18 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
