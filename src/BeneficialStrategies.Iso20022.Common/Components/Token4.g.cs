﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Token4.  ISO2002 ID# _dJ3vMZx7EeuwYeL1lHu9zw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unencrypted sensitive data of a token.
/// </summary>
public partial record Token4
     : IIsoXmlSerilizable<Token4>
{
    #nullable enable
    
    /// <summary>
    /// Surrogate value of the PAN.
    /// </summary>
    public IsoMax19NumericText? PaymentToken { get; init; } 
    /// <summary>
    /// Expiry date of the payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    public IsoISOYearMonth? TokenExpiryDate { get; init; } 
    /// <summary>
    /// Identification of a party requesting a token.
    /// </summary>
    public IsoMax11NumericText? TokenRequestorIdentification { get; init; } 
    /// <summary>
    /// Supporting information for the Token Assurance Method.
    /// </summary>
    public IsoMax140Text? TokenAssuranceData { get; init; } 
    /// <summary>
    /// Value that allows a Token Service Provider to indicate the identification and verification performed representing the binding of the payment token to the underlying PAN and cardholder.
    /// </summary>
    public IsoMax2NumericText? TokenAssuranceMethod { get; init; } 
    /// <summary>
    /// A reference to the token.
    /// </summary>
    public IsoMax35Text? TokenReferenceIdentification { get; init; } 
    
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
        if (PaymentToken is IsoMax19NumericText PaymentTokenValue)
        {
            writer.WriteStartElement(null, "PmtTkn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax19NumericText(PaymentTokenValue)); // data type Max19NumericText System.String
            writer.WriteEndElement();
        }
        if (TokenExpiryDate is IsoISOYearMonth TokenExpiryDateValue)
        {
            writer.WriteStartElement(null, "TknXpryDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISOYearMonth(TokenExpiryDateValue)); // data type ISOYearMonth System.UInt16
            writer.WriteEndElement();
        }
        if (TokenRequestorIdentification is IsoMax11NumericText TokenRequestorIdentificationValue)
        {
            writer.WriteStartElement(null, "TknRqstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax11NumericText(TokenRequestorIdentificationValue)); // data type Max11NumericText System.String
            writer.WriteEndElement();
        }
        if (TokenAssuranceData is IsoMax140Text TokenAssuranceDataValue)
        {
            writer.WriteStartElement(null, "TknAssrncData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(TokenAssuranceDataValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (TokenAssuranceMethod is IsoMax2NumericText TokenAssuranceMethodValue)
        {
            writer.WriteStartElement(null, "TknAssrncMtd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2NumericText(TokenAssuranceMethodValue)); // data type Max2NumericText System.String
            writer.WriteEndElement();
        }
        if (TokenReferenceIdentification is IsoMax35Text TokenReferenceIdentificationValue)
        {
            writer.WriteStartElement(null, "TknRefId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TokenReferenceIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static Token4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
