﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard19.  ISO2002 ID# _5ZgMYY0tEeW1W6lLicSC4w.
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
public partial record PaymentCard19
     : IIsoXmlSerilizable<PaymentCard19>
{
    #nullable enable
    
    /// <summary>
    /// Sensitive data of the card (PlainCardData1 including the envelope), encrypted with a cryptographic key.
    /// </summary>
    public ContentInformationType10? ProtectedCardData { get; init; } 
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    public PlainCardData8? PlainCardData { get; init; } 
    /// <summary>
    /// Unique reference to the card, used by both merchants and acquirers to link tokenized and non-tokenized transactions associated to the same underlying card.
    /// </summary>
    public IsoMax70Text? PaymentAccountReference { get; init; } 
    /// <summary>
    /// Masked PAN to be printed on payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as '*'.
    /// </summary>
    public IsoMax30Text? MaskedPAN { get; init; } 
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    public IsoMax35Text? CardBrand { get; init; } 
    /// <summary>
    /// Type of card product.
    /// </summary>
    public CardProductType1Code? CardProductType { get; init; } 
    
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
        if (PlainCardData is PlainCardData8 PlainCardDataValue)
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
    }
    public static PaymentCard19 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
