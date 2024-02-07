﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard29.  ISO2002 ID# _N8z6EZTBEemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
/// </summary>
public partial record PaymentCard29
     : IIsoXmlSerilizable<PaymentCard29>
{
    #nullable enable
    
    /// <summary>
    /// Type of card, for example, credit card.
    /// </summary>
    public required CardType1Code Type { get; init; } 
    /// <summary>
    /// Number embossed on a card that links the card to the account owner and account servicer.
    /// </summary>
    public required IsoMax35Text Number { get; init; } 
    /// <summary>
    /// Party entitled by a card issuer to use a card.
    /// </summary>
    public required IsoMax35Text HolderName { get; init; } 
    /// <summary>
    /// Year and month the card is available for use.
    /// </summary>
    public IsoISOYearMonth? StartDate { get; init; } 
    /// <summary>
    /// Year and month the card expires.
    /// </summary>
    public required IsoISOYearMonth ExpiryDate { get; init; } 
    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    public IsoMax35Text? CardIssuerName { get; init; } 
    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    public PartyIdentification125Choice_? CardIssuerIdentification { get; init; } 
    /// <summary>
    /// Security code written on, or in, the card.
    /// </summary>
    public IsoMax35Text? SecurityCode { get; init; } 
    /// <summary>
    /// Number distinguishing two or more payment cards with the same account number.
    /// </summary>
    public IsoMax3Text? SequenceNumber { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Nb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Number)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "HldrNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(HolderName)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (StartDate is IsoISOYearMonth StartDateValue)
        {
            writer.WriteStartElement(null, "StartDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISOYearMonth(StartDateValue)); // data type ISOYearMonth System.UInt16
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "XpryDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISOYearMonth(ExpiryDate)); // data type ISOYearMonth System.UInt16
        writer.WriteEndElement();
        if (CardIssuerName is IsoMax35Text CardIssuerNameValue)
        {
            writer.WriteStartElement(null, "CardIssrNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CardIssuerNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CardIssuerIdentification is PartyIdentification125Choice_ CardIssuerIdentificationValue)
        {
            writer.WriteStartElement(null, "CardIssrId", xmlNamespace );
            CardIssuerIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecurityCode is IsoMax35Text SecurityCodeValue)
        {
            writer.WriteStartElement(null, "SctyCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SecurityCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SequenceNumber is IsoMax3Text SequenceNumberValue)
        {
            writer.WriteStartElement(null, "SeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3Text(SequenceNumberValue)); // data type Max3Text System.String
            writer.WriteEndElement();
        }
    }
    public static PaymentCard29 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
