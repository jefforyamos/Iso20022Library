﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ICCResetData1.  ISO2002 ID# _SNfVUN7IEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data of a Chip Card related to the reset of the chip.
/// </summary>
public partial record ICCResetData1
     : IIsoXmlSerilizable<ICCResetData1>
{
    #nullable enable
    
    /// <summary>
    /// Value of the Answer To Reset of a chip card.
    /// </summary>
    public IsoMax140Binary? ATRValue { get; init; } 
    /// <summary>
    /// Status of a smartcard response to a command (SW1-SW2).
    /// </summary>
    public IsoMax35Binary? CardStatus { get; init; } 
    
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
        if (ATRValue is IsoMax140Binary ATRValueValue)
        {
            writer.WriteStartElement(null, "ATRVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Binary(ATRValueValue)); // data type Max140Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (CardStatus is IsoMax35Binary CardStatusValue)
        {
            writer.WriteStartElement(null, "CardSts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Binary(CardStatusValue)); // data type Max35Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static ICCResetData1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
