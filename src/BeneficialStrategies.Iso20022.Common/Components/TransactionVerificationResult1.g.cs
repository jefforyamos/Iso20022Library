﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionVerificationResult1.  ISO2002 ID# _SxbqoAEcEeCQm6a_G2yO_w_1847653135.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the verifications performed by the issuer to deliver or decline the authorisation.
/// </summary>
public partial record TransactionVerificationResult1
     : IIsoXmlSerilizable<TransactionVerificationResult1>
{
    #nullable enable
    
    /// <summary>
    /// Result of an e-commerce authentication process.
    /// </summary>
    public IsoMax500Text? ElectronicCommerceAuthenticationResult { get; init; } 
    /// <summary>
    /// Result of the printed card security code (CSC) validation.
    /// </summary>
    public CSCResult1Code? CSCResult { get; init; } 
    /// <summary>
    /// Result of the cardholder verification address checks on the street number and the postal code.
    /// </summary>
    public CardholderAddressVerificationResult1Code? CardholderAddressVerificationResult { get; init; } 
    /// <summary>
    /// Product code for which the authorisation was declined.
    /// </summary>
    public IsoMax70Text? DeclinedProductCode { get; init; } 
    
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
        if (ElectronicCommerceAuthenticationResult is IsoMax500Text ElectronicCommerceAuthenticationResultValue)
        {
            writer.WriteStartElement(null, "ElctrncComrcAuthntcnRslt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax500Text(ElectronicCommerceAuthenticationResultValue)); // data type Max500Text System.String
            writer.WriteEndElement();
        }
        if (CSCResult is CSCResult1Code CSCResultValue)
        {
            writer.WriteStartElement(null, "CSCRslt", xmlNamespace );
            writer.WriteValue(CSCResultValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CardholderAddressVerificationResult is CardholderAddressVerificationResult1Code CardholderAddressVerificationResultValue)
        {
            writer.WriteStartElement(null, "CrdhldrAdrVrfctnRslt", xmlNamespace );
            writer.WriteValue(CardholderAddressVerificationResultValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DeclinedProductCode is IsoMax70Text DeclinedProductCodeValue)
        {
            writer.WriteStartElement(null, "DclndPdctCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(DeclinedProductCodeValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static TransactionVerificationResult1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
