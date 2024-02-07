﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction128.  ISO2002 ID# _LTvzAXG7Ee2TbaNWBpRZpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation response from the acquirer.
/// </summary>
public partial record CardPaymentTransaction128
     : IIsoXmlSerilizable<CardPaymentTransaction128>
{
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    public required AuthorisationResult17 AuthorisationResult { get; init; } 
    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    /// <summary>
    /// Product code which are allowed by the payment card.
    /// </summary>
    public Product4? AllowedProductCode { get; init; } 
    /// <summary>
    /// Product code not allowed by the payment card.
    /// </summary>
    public Product4? NotAllowedProductCode { get; init; } 
    /// <summary>
    /// Products that may be added to the purchase after the authorisation.
    /// </summary>
    public Product5? AdditionalAvailableProduct { get; init; } 
    /// <summary>
    /// Balance and currency code of the account, related to the payment.
    /// </summary>
    public AmountAndDirection93? Balance { get; init; } 
    /// <summary>
    /// Encrypted balance of the account.
    /// </summary>
    public ContentInformationType35? ProtectedBalance { get; init; } 
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    public Action14? Action { get; init; } 
    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be proposed to the cardholder.
    /// </summary>
    public CurrencyConversion26? CurrencyConversionEligibility { get; init; } 
    
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
        writer.WriteStartElement(null, "AuthstnRslt", xmlNamespace );
        AuthorisationResult.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TransactionVerificationResult is TransactionVerificationResult4 TransactionVerificationResultValue)
        {
            writer.WriteStartElement(null, "TxVrfctnRslt", xmlNamespace );
            TransactionVerificationResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AllowedProductCode is Product4 AllowedProductCodeValue)
        {
            writer.WriteStartElement(null, "AllwdPdctCd", xmlNamespace );
            AllowedProductCodeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NotAllowedProductCode is Product4 NotAllowedProductCodeValue)
        {
            writer.WriteStartElement(null, "NotAllwdPdctCd", xmlNamespace );
            NotAllowedProductCodeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalAvailableProduct is Product5 AdditionalAvailableProductValue)
        {
            writer.WriteStartElement(null, "AddtlAvlblPdct", xmlNamespace );
            AdditionalAvailableProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Balance is AmountAndDirection93 BalanceValue)
        {
            writer.WriteStartElement(null, "Bal", xmlNamespace );
            BalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedBalance is ContentInformationType35 ProtectedBalanceValue)
        {
            writer.WriteStartElement(null, "PrtctdBal", xmlNamespace );
            ProtectedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Action is Action14 ActionValue)
        {
            writer.WriteStartElement(null, "Actn", xmlNamespace );
            ActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CurrencyConversionEligibility is CurrencyConversion26 CurrencyConversionEligibilityValue)
        {
            writer.WriteStartElement(null, "CcyConvsElgblty", xmlNamespace );
            CurrencyConversionEligibilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransaction128 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
