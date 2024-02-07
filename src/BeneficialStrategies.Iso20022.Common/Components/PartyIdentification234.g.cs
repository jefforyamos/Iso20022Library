﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification234.  ISO2002 ID# _bfb5OwVSEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the beneficial owner of the securities.
/// </summary>
public partial record PartyIdentification234
     : IIsoXmlSerilizable<PartyIdentification234>
{
    #nullable enable
    
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    public required PartyIdentification137Choice_ OwnerIdentification { get; init; } 
    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    public IsoLEIIdentifier? LEIIdentification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification9? AlternateIdentification { get; init; } 
    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a person's permanent home).
    /// </summary>
    public CountryCode? DomicileCountry { get; init; } 
    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    public CountryCode? NonDomicileCountry { get; init; } 
    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    public required FinancialInstrumentQuantity15Choice_ OwnedSecuritiesQuantity { get; init; } 
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    public BeneficiaryCertificationType11Choice_? CertificationType { get; init; } 
    /// <summary>
    /// Requested percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public RateAndAmountFormat46Choice_? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    public IsoRestrictedFINXMax350Text? CertificationBreakdown { get; init; } 
    
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
        writer.WriteStartElement(null, "OwnrId", xmlNamespace );
        OwnerIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LEIIdentification is IsoLEIIdentifier LEIIdentificationValue)
        {
            writer.WriteStartElement(null, "LEIId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LEIIdentificationValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (AlternateIdentification is AlternatePartyIdentification9 AlternateIdentificationValue)
        {
            writer.WriteStartElement(null, "AltrnId", xmlNamespace );
            AlternateIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DomicileCountry is CountryCode DomicileCountryValue)
        {
            writer.WriteStartElement(null, "DmclCtry", xmlNamespace );
            writer.WriteValue(DomicileCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NonDomicileCountry is CountryCode NonDomicileCountryValue)
        {
            writer.WriteStartElement(null, "NonDmclCtry", xmlNamespace );
            writer.WriteValue(NonDomicileCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OwndSctiesQty", xmlNamespace );
        OwnedSecuritiesQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CertificationType is BeneficiaryCertificationType11Choice_ CertificationTypeValue)
        {
            writer.WriteStartElement(null, "CertfctnTp", xmlNamespace );
            CertificationTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WithholdingTaxRate is RateAndAmountFormat46Choice_ WithholdingTaxRateValue)
        {
            writer.WriteStartElement(null, "WhldgTaxRate", xmlNamespace );
            WithholdingTaxRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CertificationBreakdown is IsoRestrictedFINXMax350Text CertificationBreakdownValue)
        {
            writer.WriteStartElement(null, "CertfctnBrkdwn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax350Text(CertificationBreakdownValue)); // data type RestrictedFINXMax350Text System.String
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification234 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
