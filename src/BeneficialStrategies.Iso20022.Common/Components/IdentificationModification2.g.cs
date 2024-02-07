﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IdentificationModification2.  ISO2002 ID# _tpZdUlkyEeGeoaLUQk__nA_-1518673695.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification data that is advised to be modified.
/// </summary>
public partial record IdentificationModification2
     : IIsoXmlSerilizable<IdentificationModification2>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the message.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    public IdentificationInformation2? OriginalPartyAndAccountIdentification { get; init; } 
    /// <summary>
    /// Provides updated party and/or account identification information.
    /// </summary>
    public required IdentificationInformation2 UpdatedPartyAndAccountIdentification { get; init; } 
    /// <summary>
    /// Additional information, in free text form, to complement the modification information.
    /// </summary>
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OriginalPartyAndAccountIdentification is IdentificationInformation2 OriginalPartyAndAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlPtyAndAcctId", xmlNamespace );
            OriginalPartyAndAccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "UpdtdPtyAndAcctId", xmlNamespace );
        UpdatedPartyAndAccountIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalInformation is IsoMax140Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(AdditionalInformationValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static IdentificationModification2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
