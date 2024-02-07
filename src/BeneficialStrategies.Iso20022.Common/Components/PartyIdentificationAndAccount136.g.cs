﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount136.  ISO2002 ID# _5nIqiZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
public partial record PartyIdentificationAndAccount136
     : IIsoXmlSerilizable<PartyIdentificationAndAccount136>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification104Choice_ Identification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification9? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public IsoRestrictedFINXMax35Text? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    public PartyTextInformation3? AdditionalInformation { get; init; } 
    
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
        if (LEI is IsoLEIIdentifier LEIValue)
        {
            writer.WriteStartElement(null, "LEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LEIValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (AlternateIdentification is AlternatePartyIdentification9 AlternateIdentificationValue)
        {
            writer.WriteStartElement(null, "AltrnId", xmlNamespace );
            AlternateIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is IsoRestrictedFINXMax35Text SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax35Text(SafekeepingAccountValue)); // data type RestrictedFINXMax35Text System.String
            writer.WriteEndElement();
        }
        if (ProcessingIdentification is IsoRestrictedFINXMax16Text ProcessingIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcgId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ProcessingIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is PartyTextInformation3 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentificationAndAccount136 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
