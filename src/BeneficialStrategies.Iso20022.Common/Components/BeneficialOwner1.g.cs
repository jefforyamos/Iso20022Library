﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BeneficialOwner1.  ISO2002 ID# _UDK4gtp-Ed-ak6NoX_4Aeg_988649524.
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
public partial record BeneficialOwner1
     : IIsoXmlSerilizable<BeneficialOwner1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party that is the beneficial owner of the specified securities.
    /// </summary>
    public required PartyIdentification2Choice_ BeneficialOwnerIdentification { get; init; } 
    /// <summary>
    /// Additional identification of the party that is the beneficial owner of the specified securities.
    /// </summary>
    public GenericIdentification16? AdditionalIdentification { get; init; } 
    /// <summary>
    /// Nationality of the beneficial owner.
    /// </summary>
    public CountryCode? Nationality { get; init; } 
    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a persons permanent home).
    /// </summary>
    public CountryCode? DomicileCountry { get; init; } 
    /// <summary>
    /// The holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    public CountryCode? NonDomicileCountry { get; init; } 
    /// <summary>
    /// Whether or not certification is required from the account owner. |Yes: certification required |No: no certification required.
    /// </summary>
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    /// <summary>
    /// Provides declaration details narrative relative to the financial instrument, eg, beneficial ownership.
    /// </summary>
    public IsoMax350Text? DeclarationDetails { get; init; } 
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    public SecurityIdentification7? SecurityIdentification { get; init; } 
    /// <summary>
    /// Quantity of securities elected by to the beneficial owner.
    /// </summary>
    public required UnitOrFaceAmount1Choice_ ElectedSecuritiesQuantity { get; init; } 
    
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
        writer.WriteStartElement(null, "BnfclOwnrId", xmlNamespace );
        BeneficialOwnerIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalIdentification is GenericIdentification16 AdditionalIdentificationValue)
        {
            writer.WriteStartElement(null, "AddtlId", xmlNamespace );
            AdditionalIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Nationality is CountryCode NationalityValue)
        {
            writer.WriteStartElement(null, "Ntlty", xmlNamespace );
            writer.WriteValue(NationalityValue.ToString()); // Enum value
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
        if (CertificationIndicator is IsoYesNoIndicator CertificationIndicatorValue)
        {
            writer.WriteStartElement(null, "CertfctnInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CertificationIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CertificationType is BeneficiaryCertificationType1FormatChoice_ CertificationTypeValue)
        {
            writer.WriteStartElement(null, "CertfctnTp", xmlNamespace );
            CertificationTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeclarationDetails is IsoMax350Text DeclarationDetailsValue)
        {
            writer.WriteStartElement(null, "DclrtnDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(DeclarationDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (SecurityIdentification is SecurityIdentification7 SecurityIdentificationValue)
        {
            writer.WriteStartElement(null, "SctyId", xmlNamespace );
            SecurityIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ElctdSctiesQty", xmlNamespace );
        ElectedSecuritiesQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static BeneficialOwner1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
