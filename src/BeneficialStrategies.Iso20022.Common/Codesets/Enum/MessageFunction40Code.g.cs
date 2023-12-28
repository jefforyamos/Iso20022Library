﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction40Code.  ISO2002 ID# _FtTOIQu2Eeq4I6UJxZQ2Qw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of message supporting a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FtTOIQu2Eeq4I6UJxZQ2Qw")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction40Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FinancialAuthorisationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxgQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    FinancialAuthorisationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancellationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxgwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    CancellationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompletionAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxhQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    CompletionAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DiagnosticRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxhwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    DiagnosticRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReconciliationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxiQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    ReconciliationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancellationAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxiwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    CancellationAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BatchTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxjQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    BatchTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FinancialReversalAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxjwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    FinancialReversalAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AuthorisationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxkQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    AuthorisationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FinancialCompletionAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxkwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    FinancialCompletionAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CurrencyConversionRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxlQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    CurrencyConversionRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReversalAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxlwu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    ReversalAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CurrencyConversionAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F4fxmQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"??")]
    CurrencyConversionAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TransactionAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_5qUogQ02EeqUVL7sB4m7NA")]
    [Description(@"??")]
    TransactionAdvice,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction40CodeMetadataExtensions
{
    private static readonly MessageFunction40CodeDropdownSource _dropdownSource = new MessageFunction40CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction40CodeDropdownRow GetMetadata(this MessageFunction40Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

