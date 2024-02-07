﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Seller.  ISO2002 ID# _GiI3cx5dEeWE3PufGMdJ3w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Counterparty9Choice;

/// <summary>
/// Party that sells goods or services, or a financial instrument.
/// </summary>
public partial record Seller : Counterparty9Choice_
     , IIsoXmlSerilizable<Seller>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification71Choice_ Identification { get; init; } 
    /// <summary>
    /// Legal Entity Identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount24? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    public DateAndDateTimeChoice_? ProcessingDate { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LEI is IsoLEIIdentifier LEIValue)
        {
            writer.WriteStartElement(null, "LEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LEIValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (AlternateIdentification is AlternatePartyIdentification7 AlternateIdentificationValue)
        {
            writer.WriteStartElement(null, "AltrnId", xmlNamespace );
            AlternateIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is SecuritiesAccount24 SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            SafekeepingAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProcessingDate is DateAndDateTimeChoice_ ProcessingDateValue)
        {
            writer.WriteStartElement(null, "PrcgDt", xmlNamespace );
            ProcessingDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProcessingIdentification is IsoMax35Text ProcessingIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcgId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessingIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is PartyTextInformation1 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Seller Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
