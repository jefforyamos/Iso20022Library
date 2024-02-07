﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherTransactionIdentification.  ISO2002 ID# _UR6fLNp-Ed-ak6NoX_4Aeg_1661514414.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.References4Choice;

/// <summary>
/// Reference to a transaction that cannot be identified using a standard reference element present in the message.
/// </summary>
public partial record OtherTransactionIdentification : References4Choice_
     , IIsoXmlSerilizable<OtherTransactionIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    /// <summary>
    /// Identification of the document.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    
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
        if (MessageNumber is DocumentNumber1Choice_ MessageNumberValue)
        {
            writer.WriteStartElement(null, "MsgNb", xmlNamespace );
            MessageNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new OtherTransactionIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
