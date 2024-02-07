﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard11.  ISO2002 ID# _o19lQWlsEeSGkpGpjm7tzg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment card performing the transaction.
/// </summary>
public partial record PaymentCard11
     : IIsoXmlSerilizable<PaymentCard11>
{
    #nullable enable
    
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType10? ProtectedCardData { get; init; } 
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    public PlainCardData9? PlainCardData { get; init; } 
    /// <summary>
    /// Masked PAN to be printed the payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as '*'.
    /// </summary>
    public IsoMax30Text? MaskedPAN { get; init; } 
    /// <summary>
    /// Bank identifier number of the issuer for routing purpose.
    /// </summary>
    public IsoMax15NumericText? IssuerBIN { get; init; } 
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    public IsoMax3Text? CardCountryCode { get; init; } 
    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; } 
    /// <summary>
    /// Defines a category of cards related to the acceptance processing rules defined by the acquirer.
    /// </summary>
    public IsoMax35Text? CardProductProfile { get; init; } 
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    public IsoMax35Text? CardBrand { get; init; } 
    /// <summary>
    /// Type of card product.
    /// </summary>
    public CardProductType1Code? CardProductType { get; init; } 
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    public IsoMax70Text? AdditionalCardData { get; init; } 
    
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
        if (ProtectedCardData is ContentInformationType10 ProtectedCardDataValue)
        {
            writer.WriteStartElement(null, "PrtctdCardData", xmlNamespace );
            ProtectedCardDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlainCardData is PlainCardData9 PlainCardDataValue)
        {
            writer.WriteStartElement(null, "PlainCardData", xmlNamespace );
            PlainCardDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MaskedPAN is IsoMax30Text MaskedPANValue)
        {
            writer.WriteStartElement(null, "MskdPAN", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax30Text(MaskedPANValue)); // data type Max30Text System.String
            writer.WriteEndElement();
        }
        if (IssuerBIN is IsoMax15NumericText IssuerBINValue)
        {
            writer.WriteStartElement(null, "IssrBIN", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15NumericText(IssuerBINValue)); // data type Max15NumericText System.String
            writer.WriteEndElement();
        }
        if (CardCountryCode is IsoMax3Text CardCountryCodeValue)
        {
            writer.WriteStartElement(null, "CardCtryCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3Text(CardCountryCodeValue)); // data type Max3Text System.String
            writer.WriteEndElement();
        }
        if (CardCurrencyCode is IsoExact3AlphaNumericText CardCurrencyCodeValue)
        {
            writer.WriteStartElement(null, "CardCcyCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact3AlphaNumericText(CardCurrencyCodeValue)); // data type Exact3AlphaNumericText System.String
            writer.WriteEndElement();
        }
        if (CardProductProfile is IsoMax35Text CardProductProfileValue)
        {
            writer.WriteStartElement(null, "CardPdctPrfl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CardProductProfileValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CardBrand is IsoMax35Text CardBrandValue)
        {
            writer.WriteStartElement(null, "CardBrnd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CardBrandValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CardProductType is CardProductType1Code CardProductTypeValue)
        {
            writer.WriteStartElement(null, "CardPdctTp", xmlNamespace );
            writer.WriteValue(CardProductTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AdditionalCardData is IsoMax70Text AdditionalCardDataValue)
        {
            writer.WriteStartElement(null, "AddtlCardData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AdditionalCardDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static PaymentCard11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
