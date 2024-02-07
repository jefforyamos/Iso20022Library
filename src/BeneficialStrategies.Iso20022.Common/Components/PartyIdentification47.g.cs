﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification47.  ISO2002 ID# _yWPB0fL9Ed-3lpUMQaXLjQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification of the party.
/// </summary>
public partial record PartyIdentification47
     : IIsoXmlSerilizable<PartyIdentification47>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a party.
    /// </summary>
    public required PartyIdentification39Choice_ Identification { get; init; } 
    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Provides alternate identification for a party using an id type, a country code and a text field.
    /// </summary>
    public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProcessingIdentification is IsoMax35Text ProcessingIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcgId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessingIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is IsoMax350Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (AlternateIdentification is AlternatePartyIdentification2 AlternateIdentificationValue)
        {
            writer.WriteStartElement(null, "AltrnId", xmlNamespace );
            AlternateIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification47 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
