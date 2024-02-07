﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KeyIdentifier.  ISO2002 ID# _N1aSpWi0EeS87LmvcA55sg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Recipient4Choice;

/// <summary>
/// Identification of a protection key without a session key, shared and previously exchanged between the initiator and the recipient.
/// </summary>
public partial record KeyIdentifier : Recipient4Choice_
     , IIsoXmlSerilizable<KeyIdentifier>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the cryptographic key.
    /// </summary>
    public required IsoMax140Text KeyIdentification { get; init; } 
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    public required IsoMax140Text KeyVersion { get; init; } 
    /// <summary>
    /// Number of usages of the cryptographic key.
    /// </summary>
    public IsoNumber? SequenceNumber { get; init; } 
    /// <summary>
    /// Identification used for derivation of a unique key from a master key provided for the data protection.
    /// </summary>
    public IsoMin5Max16Binary? DerivationIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "KeyId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax140Text(KeyIdentification)); // data type Max140Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "KeyVrsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax140Text(KeyVersion)); // data type Max140Text System.String
        writer.WriteEndElement();
        if (SequenceNumber is IsoNumber SequenceNumberValue)
        {
            writer.WriteStartElement(null, "SeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(SequenceNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (DerivationIdentification is IsoMin5Max16Binary DerivationIdentificationValue)
        {
            writer.WriteStartElement(null, "DerivtnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMin5Max16Binary(DerivationIdentificationValue)); // data type Min5Max16Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static new KeyIdentifier Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
