﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Status.  ISO2002 ID# _aeWNUVNUEeijdq8ilaxyOA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus3Choice;

/// <summary>
/// Status of the transfer is received, accepted, sent to next party, matched, already executed, or settled.
/// </summary>
public partial record Status : TransferStatus3Choice_
     , IIsoXmlSerilizable<Status>
{
    #nullable enable
    
    public required TransferStatus6Code Value { get; init; } 
    /// <summary>
    /// Reason for the status.
    /// </summary>
    public IsoMax350Text? Reason { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
        if (Reason is IsoMax350Text ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(ReasonValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Status Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
