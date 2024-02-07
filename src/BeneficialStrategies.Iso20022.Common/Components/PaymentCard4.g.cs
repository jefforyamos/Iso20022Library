﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard4.  ISO2002 ID# _t6iQoFkyEeGeoaLUQk__nA_2134907969.
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
public partial record PaymentCard4
     : IIsoXmlSerilizable<PaymentCard4>
{
    #nullable enable
    
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    public PlainCardData1? PlainCardData { get; init; } 
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    public IsoExact3NumericText? CardCountryCode { get; init; } 
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    public GenericIdentification1? CardBrand { get; init; } 
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
        if (PlainCardData is PlainCardData1 PlainCardDataValue)
        {
            writer.WriteStartElement(null, "PlainCardData", xmlNamespace );
            PlainCardDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardCountryCode is IsoExact3NumericText CardCountryCodeValue)
        {
            writer.WriteStartElement(null, "CardCtryCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact3NumericText(CardCountryCodeValue)); // data type Exact3NumericText System.String
            writer.WriteEndElement();
        }
        if (CardBrand is GenericIdentification1 CardBrandValue)
        {
            writer.WriteStartElement(null, "CardBrnd", xmlNamespace );
            CardBrandValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalCardData is IsoMax70Text AdditionalCardDataValue)
        {
            writer.WriteStartElement(null, "AddtlCardData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AdditionalCardDataValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static PaymentCard4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
