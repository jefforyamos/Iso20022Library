﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction41Code.  ISO2002 ID# _Vb_nYQ0xEeqUVL7sB4m7NA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of message supporting a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vb_nYQ0xEeqUVL7sB4m7NA")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction41Code
{
    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as "AuthorisationRequest".
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_VoGwwQ0xEeqUVL7sB4m7NA")]
    [Description(@"The initiator requests an authorisation without financial impact to complete the transaction.")]
    AuthorisationRequest,
    
    /// <summary>
    /// Response for authorisation without financial capture.
    /// Encoded/decoded by serializers as "AuthorisationResponse".
    /// </summary>
    [EnumMember(Value = "AUTP")]
    [IsoId("_VoGwww0xEeqUVL7sB4m7NA")]
    [Description(@"Response for authorisation without financial capture.")]
    AuthorisationResponse,
    
    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as "CancellationAdvice".
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_VoGwxQ0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice,
    
    /// <summary>
    /// Advice response for cancellation.
    /// Encoded/decoded by serializers as "CancellationAdviceResponse".
    /// </summary>
    [EnumMember(Value = "CCAK")]
    [IsoId("_VoGwxw0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for cancellation.")]
    CancellationAdviceResponse,
    
    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as "CancellationRequest".
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_VoGwyQ0xEeqUVL7sB4m7NA")]
    [Description(@"Request for cancellation.")]
    CancellationRequest,
    
    /// <summary>
    /// Response for cancellation.
    /// Encoded/decoded by serializers as "CancellationResponse".
    /// </summary>
    [EnumMember(Value = "CCAP")]
    [IsoId("_VoGwyw0xEeqUVL7sB4m7NA")]
    [Description(@"Response for cancellation.")]
    CancellationResponse,
    
    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as "CompletionAdvice".
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_VoGwzQ0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice,
    
    /// <summary>
    /// Advice response for completion without financial capture.
    /// Encoded/decoded by serializers as "CompletionAdviceResponse".
    /// </summary>
    [EnumMember(Value = "CMPK")]
    [IsoId("_VoGwzw0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for completion without financial capture.")]
    CompletionAdviceResponse,
    
    /// <summary>
    /// Advice for dynamic currency conversion.
    /// Encoded/decoded by serializers as "CurrencyConversionAdvice".
    /// </summary>
    [EnumMember(Value = "DCAV")]
    [IsoId("_VoGw0Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for dynamic currency conversion.")]
    CurrencyConversionAdvice,
    
    /// <summary>
    /// Advice response for the currency conversion from the service provider to the acceptor.
    /// Encoded/decoded by serializers as "CurrencyConversionAdviceResponse".
    /// </summary>
    [EnumMember(Value = "DCRR")]
    [IsoId("_VoGw0w0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for the currency conversion from the service provider to the acceptor.")]
    CurrencyConversionAdviceResponse,
    
    /// <summary>
    /// Request for dynamic currency conversion.
    /// Encoded/decoded by serializers as "CurrencyConversionRequest".
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_VoGw1Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request for dynamic currency conversion.")]
    CurrencyConversionRequest,
    
    /// <summary>
    /// Response from a dynamic currency conversion.
    /// Encoded/decoded by serializers as "CurrencyConversionResponse".
    /// </summary>
    [EnumMember(Value = "DCCP")]
    [IsoId("_VoGw1w0xEeqUVL7sB4m7NA")]
    [Description(@"Response from a dynamic currency conversion.")]
    CurrencyConversionResponse,
    
    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as "DiagnosticRequest".
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_VoGw2Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest,
    
    /// <summary>
    /// Response for diagnostic.
    /// Encoded/decoded by serializers as "DiagnosticResponse".
    /// </summary>
    [EnumMember(Value = "DGNQ")]
    [IsoId("_VoGw2w0xEeqUVL7sB4m7NA")]
    [Description(@"Response for diagnostic.")]
    DiagnosticResponse,
    
    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as "FinancialAuthorisationRequest".
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_VoGw3Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest,
    
    /// <summary>
    /// Response for authorisation with financial capture.
    /// Encoded/decoded by serializers as "FinancialAuthorisationResponse".
    /// </summary>
    [EnumMember(Value = "FAUP")]
    [IsoId("_VoGw3w0xEeqUVL7sB4m7NA")]
    [Description(@"Response for authorisation with financial capture.")]
    FinancialAuthorisationResponse,
    
    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as "FinancialCompletionAdvice".
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_VoGw4Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice,
    
    /// <summary>
    /// Advice response for completion with financial capture.
    /// Encoded/decoded by serializers as "FinancialCompletionAdviceResponse".
    /// </summary>
    [EnumMember(Value = "FCMK")]
    [IsoId("_VoGw4w0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for completion with financial capture.")]
    FinancialCompletionAdviceResponse,
    
    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as "FinancialReversalAdvice".
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_VoGw5Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice,
    
    /// <summary>
    /// Advice response for reversal with financial capture.
    /// Encoded/decoded by serializers as "FinancialReversalAdviceResponse".
    /// </summary>
    [EnumMember(Value = "FRVR")]
    [IsoId("_VoGw5w0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for reversal with financial capture.")]
    FinancialReversalAdviceResponse,
    
    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as "ReconciliationRequest".
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_VoGw6Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest,
    
    /// <summary>
    /// Response for reconciliation.
    /// Encoded/decoded by serializers as "ReconciliationResponse".
    /// </summary>
    [EnumMember(Value = "RCLP")]
    [IsoId("_VoGw6w0xEeqUVL7sB4m7NA")]
    [Description(@"Response for reconciliation.")]
    ReconciliationResponse,
    
    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as "ReversalAdvice".
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_VoGw7Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice,
    
    /// <summary>
    /// Advice response for reversal without financial capture.
    /// Encoded/decoded by serializers as "ReversalAdviceResponse".
    /// </summary>
    [EnumMember(Value = "RVRR")]
    [IsoId("_VoGw7w0xEeqUVL7sB4m7NA")]
    [Description(@"Advice response for reversal without financial capture.")]
    ReversalAdviceResponse,
    
    /// <summary>
    /// Advice for a Card Direct Debit.
    /// Encoded/decoded by serializers as "CardDebitAdvice".
    /// </summary>
    [EnumMember(Value = "CDDQ")]
    [IsoId("_VoGw8Q0xEeqUVL7sB4m7NA")]
    [Description(@"Advice for a Card Direct Debit.")]
    CardDebitAdvice,
    
    /// <summary>
    /// Response to a Card Direct Debit Advice.
    /// Encoded/decoded by serializers as "CardDebitAdviceResponse".
    /// </summary>
    [EnumMember(Value = "CDDK")]
    [IsoId("_VoGw8w0xEeqUVL7sB4m7NA")]
    [Description(@"Response to a Card Direct Debit Advice.")]
    CardDebitAdviceResponse,
    
    /// <summary>
    /// Request to initiate a Card Direct Debit.
    /// Encoded/decoded by serializers as "CardDebitRequest".
    /// </summary>
    [EnumMember(Value = "CDDR")]
    [IsoId("_VoGw9Q0xEeqUVL7sB4m7NA")]
    [Description(@"Request to initiate a Card Direct Debit.")]
    CardDebitRequest,
    
    /// <summary>
    /// Response to a Card Direct Debit Request.
    /// Encoded/decoded by serializers as "CardDebitResponse".
    /// </summary>
    [EnumMember(Value = "CDDP")]
    [IsoId("_VoGw9w0xEeqUVL7sB4m7NA")]
    [Description(@"Response to a Card Direct Debit Request.")]
    CardDebitResponse,
    
    /// <summary>
    /// Response to a transaction advice.
    /// Encoded/decoded by serializers as "TransactionAdviceResponse".
    /// </summary>
    [EnumMember(Value = "TRNR")]
    [IsoId("_2kmNsQ02EeqUVL7sB4m7NA")]
    [Description(@"Response to a transaction advice.")]
    TransactionAdviceResponse,
    
    /// <summary>
    /// Advise of the transaction's processing.
    /// Encoded/decoded by serializers as "TransactionAdvice".
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_2odaAQ02EeqUVL7sB4m7NA")]
    [Description(@"Advise of the transaction's processing.")]
    TransactionAdvice,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction41CodeMetadataExtensions
{
    private static readonly MessageFunction41CodeDropdownSource _dropdownSource = new MessageFunction41CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction41CodeDropdownRow GetMetadata(this MessageFunction41Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


