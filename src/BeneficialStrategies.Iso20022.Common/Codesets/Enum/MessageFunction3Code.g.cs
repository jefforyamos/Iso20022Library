﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction3Code.  ISO2002 ID# _KSlT1n1DEeCF8NjrBemJWQ_-948451951.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of message supporting a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KSlT1n1DEeCF8NjrBemJWQ_-948451951")]
[Description(@"Type of message supporting a service.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction3Code
{
    /// <summary>
    /// Request for authorisation with financial capture.
    /// Encoded/decoded by serializers as "FAUQ".
    /// </summary>
    [EnumMember(Value = "FAUQ")]
    [IsoId("_KSlT131DEeCF8NjrBemJWQ_-2015531584")]
    [Description(@"Request for authorisation with financial capture.")]
    FinancialAuthorisationRequest = MessageFunctionCode.FinancialAuthorisationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for cancellation.
    /// Encoded/decoded by serializers as "CCAQ".
    /// </summary>
    [EnumMember(Value = "CCAQ")]
    [IsoId("_KSlT2H1DEeCF8NjrBemJWQ_-370264149")]
    [Description(@"Request for cancellation.")]
    CancellationRequest = MessageFunctionCode.CancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for completion without financial capture.
    /// Encoded/decoded by serializers as "CMPV".
    /// </summary>
    [EnumMember(Value = "CMPV")]
    [IsoId("_KSvE0H1DEeCF8NjrBemJWQ_-1367336502")]
    [Description(@"Advice for completion without financial capture.")]
    CompletionAdvice = MessageFunctionCode.CompletionAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for diagnostic.
    /// Encoded/decoded by serializers as "DGNP".
    /// </summary>
    [EnumMember(Value = "DGNP")]
    [IsoId("_KSvE0X1DEeCF8NjrBemJWQ_1930558441")]
    [Description(@"Request for diagnostic.")]
    DiagnosticRequest = MessageFunctionCode.DiagnosticRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for reconciliation.
    /// Encoded/decoded by serializers as "RCLQ".
    /// </summary>
    [EnumMember(Value = "RCLQ")]
    [IsoId("_KSvE0n1DEeCF8NjrBemJWQ_933486088")]
    [Description(@"Request for reconciliation.")]
    ReconciliationRequest = MessageFunctionCode.ReconciliationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for cancellation.
    /// Encoded/decoded by serializers as "CCAV".
    /// </summary>
    [EnumMember(Value = "CCAV")]
    [IsoId("_KSvE031DEeCF8NjrBemJWQ_-63586265")]
    [Description(@"Advice for cancellation.")]
    CancellationAdvice = MessageFunctionCode.CancellationAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer the financial data as a collection of transction.
    /// Encoded/decoded by serializers as "BTCH".
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("_KSvE1H1DEeCF8NjrBemJWQ_-1060658618")]
    [Description(@"Transfer the financial data as a collection of transction.")]
    BatchTransfer = MessageFunctionCode.BatchTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for reversal with financial capture.
    /// Encoded/decoded by serializers as "FRVA".
    /// </summary>
    [EnumMember(Value = "FRVA")]
    [IsoId("_KSvE1X1DEeCF8NjrBemJWQ_-405103463")]
    [Description(@"Advice for reversal with financial capture.")]
    FinancialReversalAdvice = MessageFunctionCode.FinancialReversalAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The initiator requests an authorisation without financial impact to complete the transaction.
    /// Encoded/decoded by serializers as "AUTQ".
    /// </summary>
    [EnumMember(Value = "AUTQ")]
    [IsoId("_KSvE1n1DEeCF8NjrBemJWQ_1240163972")]
    [Description(@"The initiator requests an authorisation without financial impact to complete the transaction.")]
    AuthorisationRequest = MessageFunctionCode.AuthorisationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for completion with financial capture.
    /// Encoded/decoded by serializers as "FCMV".
    /// </summary>
    [EnumMember(Value = "FCMV")]
    [IsoId("_KSvE131DEeCF8NjrBemJWQ_243091619")]
    [Description(@"Advice for completion with financial capture.")]
    FinancialCompletionAdvice = MessageFunctionCode.FinancialCompletionAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as "RVRA".
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_KSvE2H1DEeCF8NjrBemJWQ_1781880061")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction3CodeMetadataExtensions
{
    private static readonly MessageFunction3CodeDropdownSource _dropdownSource = new MessageFunction3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction3CodeDropdownRow GetMetadata(this MessageFunction3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


