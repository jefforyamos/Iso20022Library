﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction6Code.  ISO2002 ID# _r7c3QHrKEeSfJf8ETXpBxg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of process related to the message. It partially correspond to the message type identifier (MTI) of ISO 8583.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r7c3QHrKEeSfJf8ETXpBxg")]
[Description(@"Identifies the type of process related to the message. It partially correspond to the message type identifier (MTI) of ISO 8583.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction6Code
{
    /// <summary>
    /// Advice of transaction totals from an acquirer.
    /// Encoded/decoded by serializers as "RCAV".
    /// </summary>
    [EnumMember(Value = "RCAV")]
    [IsoId("_uFKVwXrKEeSfJf8ETXpBxg")]
    [Description(@"Advice of transaction totals from an acquirer.")]
    AcquirerReconciliationAdvice = MessageFunctionCode.AcquirerReconciliationAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification of transaction totals from an acquirer.
    /// Encoded/decoded by serializers as "RCAN".
    /// </summary>
    [EnumMember(Value = "RCAN")]
    [IsoId("_uZm7wXrKEeSfJf8ETXpBxg")]
    [Description(@"Notification of transaction totals from an acquirer.")]
    AcquirerReconciliationNotification = MessageFunctionCode.AcquirerReconciliationNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request of transaction totals exchange from an acquirer.
    /// Encoded/decoded by serializers as "RCAQ".
    /// </summary>
    [EnumMember(Value = "RCAQ")]
    [IsoId("_uiZrYXrKEeSfJf8ETXpBxg")]
    [Description(@"Request of transaction totals exchange from an acquirer.")]
    AcquirerReconciliationRequest = MessageFunctionCode.AcquirerReconciliationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reject of a message by an acquirer.
    /// Encoded/decoded by serializers as "REJA".
    /// </summary>
    [EnumMember(Value = "REJA")]
    [IsoId("_ux5f8XrKEeSfJf8ETXpBxg")]
    [Description(@"Reject of a message by an acquirer.")]
    AcquirerReject = MessageFunctionCode.AcquirerReject, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal advice of an authorisation or a financial message.
    /// Encoded/decoded by serializers as "REVV".
    /// </summary>
    [EnumMember(Value = "REVV")]
    [IsoId("_vDXqcXrKEeSfJf8ETXpBxg")]
    [Description(@"Reversal advice of an authorisation or a financial message.")]
    AcquirerReversalAdvice = MessageFunctionCode.AcquirerReversalAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal notification of an authorisation or a financial message.
    /// Encoded/decoded by serializers as "REVN".
    /// </summary>
    [EnumMember(Value = "REVN")]
    [IsoId("_vYhbEXrKEeSfJf8ETXpBxg")]
    [Description(@"Reversal notification of an authorisation or a financial message.")]
    AcquirerReversalNotification = MessageFunctionCode.AcquirerReversalNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal request of an authorisation or a financial message.
    /// Encoded/decoded by serializers as "REVQ".
    /// </summary>
    [EnumMember(Value = "REVQ")]
    [IsoId("_vhw2oXrKEeSfJf8ETXpBxg")]
    [Description(@"Reversal request of an authorisation or a financial message.")]
    AcquirerReversalRequest = MessageFunctionCode.AcquirerReversalRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice of transaction totals from a processor.
    /// Encoded/decoded by serializers as "RCPV".
    /// </summary>
    [EnumMember(Value = "RCPV")]
    [IsoId("_vx7ZkXrKEeSfJf8ETXpBxg")]
    [Description(@"Advice of transaction totals from a processor.")]
    AgentReconciliationAdvice = MessageFunctionCode.AgentReconciliationAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification of transaction totals from a processor.
    /// Encoded/decoded by serializers as "RCPN".
    /// </summary>
    [EnumMember(Value = "RCPN")]
    [IsoId("_wISEEXrKEeSfJf8ETXpBxg")]
    [Description(@"Notification of transaction totals from a processor.")]
    AgentReconciliationNotification = MessageFunctionCode.AgentReconciliationNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request of transaction totals exchange from a processor.
    /// Encoded/decoded by serializers as "RCPQ".
    /// </summary>
    [EnumMember(Value = "RCPQ")]
    [IsoId("_wUYmYXrKEeSfJf8ETXpBxg")]
    [Description(@"Request of transaction totals exchange from a processor.")]
    AgentReconciliationRequest = MessageFunctionCode.AgentReconciliationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reject of a message by an agent.
    /// Encoded/decoded by serializers as "REJP".
    /// </summary>
    [EnumMember(Value = "REJP")]
    [IsoId("_wjUaQXrKEeSfJf8ETXpBxg")]
    [Description(@"Reject of a message by an agent.")]
    AgentReject = MessageFunctionCode.AgentReject, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initiator of the message advises the recipient about the result of an authorisation already performed.
    /// Encoded/decoded by serializers as "AUTV".
    /// </summary>
    [EnumMember(Value = "AUTV")]
    [IsoId("_2kMXkXrKEeSfJf8ETXpBxg")]
    [Description(@"Initiator of the message advises the recipient about the result of an authorisation already performed.")]
    AuthorisationAdvice = MessageFunctionCode.AuthorisationAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information about an authorisation.
    /// Encoded/decoded by serializers as "AUTN".
    /// </summary>
    [EnumMember(Value = "AUTN")]
    [IsoId("_2y7-MXrKEeSfJf8ETXpBxg")]
    [Description(@"Information about an authorisation.")]
    AuthorisationNotification = MessageFunctionCode.AuthorisationNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as "AUTQ".
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_27by4XrKEeSfJf8ETXpBxg")]
    [Description(@"The initiator requests an authorisation without financial impact to complete the transaction.")]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response for authorisation without financial capture.
    /// Encoded/decoded by serializers as "AUTP".
    /// </summary>
    [EnumMember(Value = "AUTP")]
    [IsoId("_3E87QXrKEeSfJf8ETXpBxg")]
    [Description(@"Response for authorisation without financial capture.")]
    AuthorisationResponse = MessageFunctionCode.AuthorisationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initiator of the message advises the receptor that an authorisation has been successfully delivered or completed with a final amount, and requests the clearing of the transaction.
    /// Encoded/decoded by serializers as "FNCV".
    /// </summary>
    [EnumMember(Value = "FNCV")]
    [IsoId("_5HLRsXrKEeSfJf8ETXpBxg")]
    [Description(@"Initiator of the message advises the receptor that an authorisation has been successfully delivered or completed with a final amount, and requests the clearing of the transaction.")]
    FinancialAdvice = MessageFunctionCode.FinancialAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initiator requests the clearing of the transaction.
    /// Encoded/decoded by serializers as "FNCN".
    /// </summary>
    [EnumMember(Value = "FNCN")]
    [IsoId("_5sC5UXrKEeSfJf8ETXpBxg")]
    [Description(@"Initiator requests the clearing of the transaction.")]
    FinancialNotification = MessageFunctionCode.FinancialNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initiator of the message requests both the authorisation and the clearing of the transaction.
    /// Encoded/decoded by serializers as "FNCQ".
    /// </summary>
    [EnumMember(Value = "FNCQ")]
    [IsoId("_5yv-QXrKEeSfJf8ETXpBxg")]
    [Description(@"Initiator of the message requests both the authorisation and the clearing of the transaction.")]
    FinancialRequest = MessageFunctionCode.FinancialRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice of transaction totals from an issuer.
    /// Encoded/decoded by serializers as "RCIV".
    /// </summary>
    [EnumMember(Value = "RCIV")]
    [IsoId("_7MpJYXrKEeSfJf8ETXpBxg")]
    [Description(@"Advice of transaction totals from an issuer.")]
    IssuerReconciliationAdvice = MessageFunctionCode.IssuerReconciliationAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification of transaction totals from an issuer.
    /// Encoded/decoded by serializers as "RCIN".
    /// </summary>
    [EnumMember(Value = "RCIN")]
    [IsoId("_7Y3AcXrKEeSfJf8ETXpBxg")]
    [Description(@"Notification of transaction totals from an issuer.")]
    IssuerReconciliationNotification = MessageFunctionCode.IssuerReconciliationNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request of transaction totals exchange from an issuer.
    /// Encoded/decoded by serializers as "RCIQ".
    /// </summary>
    [EnumMember(Value = "RCIQ")]
    [IsoId("_7fAEsXrKEeSfJf8ETXpBxg")]
    [Description(@"Request of transaction totals exchange from an issuer.")]
    IssuerReconciliationRequest = MessageFunctionCode.IssuerReconciliationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reject of a message by an issuer.
    /// Encoded/decoded by serializers as "REJI".
    /// </summary>
    [EnumMember(Value = "REJI")]
    [IsoId("_7tw5cXrKEeSfJf8ETXpBxg")]
    [Description(@"Reject of a message by an issuer.")]
    IssuerReject = MessageFunctionCode.IssuerReject, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advise of a performed key update.
    /// Encoded/decoded by serializers as "KEYV".
    /// </summary>
    [EnumMember(Value = "KEYV")]
    [IsoId("_719zMXrKEeSfJf8ETXpBxg")]
    [Description(@"Advise of a performed key update.")]
    KeyExchangeAdvice = MessageFunctionCode.KeyExchangeAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request of a key exchange.
    /// Encoded/decoded by serializers as "KEYQ".
    /// </summary>
    [EnumMember(Value = "KEYQ")]
    [IsoId("_8DX9EXrKEeSfJf8ETXpBxg")]
    [Description(@"Request of a key exchange.")]
    KeyExchangeRequest = MessageFunctionCode.KeyExchangeRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advise of a performed network management service.
    /// Encoded/decoded by serializers as "MGTV".
    /// </summary>
    [EnumMember(Value = "MGTV")]
    [IsoId("_8Tp0wXrKEeSfJf8ETXpBxg")]
    [Description(@"Advise of a performed network management service.")]
    NetworkManagementAdvice = MessageFunctionCode.NetworkManagementAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request of a network management service.
    /// Encoded/decoded by serializers as "MGTQ".
    /// </summary>
    [EnumMember(Value = "MGTQ")]
    [IsoId("_8hgqkXrKEeSfJf8ETXpBxg")]
    [Description(@"Request of a network management service.")]
    NetworkManagementRequest = MessageFunctionCode.NetworkManagementRequest, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction6CodeMetadataExtensions
{
    private static readonly MessageFunction6CodeDropdownSource _dropdownSource = new MessageFunction6CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction6CodeDropdownRow GetMetadata(this MessageFunction6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


