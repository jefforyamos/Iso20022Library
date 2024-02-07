﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard28.  ISO2002 ID# _lVLekdqjEeearpaEPXv9UA.
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
public partial record PaymentCard28
     : IIsoXmlSerilizable<PaymentCard28>
{
    #nullable enable
    
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType17? ProtectedCardData { get; init; } 
    /// <summary>
    /// Replacement of the message element PlainCardData by a private envelope.
    /// </summary>
    public IsoMax100KBinary? PrivateCardData { get; init; } 
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    public PlainCardData15? PlainCardData { get; init; } 
    /// <summary>
    /// Unique reference to the card, used by both merchants and acquirers to link tokenized and non-tokenized transactions associated to the same underlying card.
    /// </summary>
    public IsoMax70Text? PaymentAccountReference { get; init; } 
    /// <summary>
    /// Masked PAN to be printed on payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as '*'.
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
    /// Additionnal information to identify CardProduct.
    /// </summary>
    public IsoMax35Text? CardProductSubType { get; init; } 
    /// <summary>
    /// True if the card may be used abroad.
    /// </summary>
    public IsoTrueFalseIndicator? InternationalCard { get; init; } 
    /// <summary>
    /// Product that can be purchased with the card.
    /// </summary>
    public IsoMax70Text? AllowedProduct { get; init; } 
    /// <summary>
    /// Options to the service provided by the card.
    /// </summary>
    public IsoMax35Text? ServiceOption { get; init; } 
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
        if (ProtectedCardData is ContentInformationType17 ProtectedCardDataValue)
        {
            writer.WriteStartElement(null, "PrtctdCardData", xmlNamespace );
            ProtectedCardDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrivateCardData is IsoMax100KBinary PrivateCardDataValue)
        {
            writer.WriteStartElement(null, "PrvtCardData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax100KBinary(PrivateCardDataValue)); // data type Max100KBinary System.Byte[]
            writer.WriteEndElement();
        }
        if (PlainCardData is PlainCardData15 PlainCardDataValue)
        {
            writer.WriteStartElement(null, "PlainCardData", xmlNamespace );
            PlainCardDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentAccountReference is IsoMax70Text PaymentAccountReferenceValue)
        {
            writer.WriteStartElement(null, "PmtAcctRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(PaymentAccountReferenceValue)); // data type Max70Text System.String
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
        if (CardProductSubType is IsoMax35Text CardProductSubTypeValue)
        {
            writer.WriteStartElement(null, "CardPdctSubTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CardProductSubTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InternationalCard is IsoTrueFalseIndicator InternationalCardValue)
        {
            writer.WriteStartElement(null, "IntrnlCard", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(InternationalCardValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (AllowedProduct is IsoMax70Text AllowedProductValue)
        {
            writer.WriteStartElement(null, "AllwdPdct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AllowedProductValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (ServiceOption is IsoMax35Text ServiceOptionValue)
        {
            writer.WriteStartElement(null, "SvcOptn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ServiceOptionValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalCardData is IsoMax70Text AdditionalCardDataValue)
        {
            writer.WriteStartElement(null, "AddtlCardData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AdditionalCardDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static PaymentCard28 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
