﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeniedReason6Code.  ISO2002 ID# _-_kAAFhdEeS8HfHHd4stCA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-_kAAFhdEeS8HfHHd4stCA")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(SettlementDeniedReasonCode))]
public enum DeniedReason6Code
{
    /// <summary>
    /// Received after the account servicer's deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_p17eYVheEeS8HfHHd4stCA")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed = SettlementDeniedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is denied due to a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as "CDCY".
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_qVxcEVheEeS8HfHHd4stCA")]
    [Description(@"Execution is denied due to a process linked to the currency of the transaction.")]
    ConditionalCurrency = SettlementDeniedReasonCode.ConditionalCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is denied due to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as "CDRE".
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_qrDIgVheEeS8HfHHd4stCA")]
    [Description(@"Execution is denied due to the execution of a process of realignment at the issuer CSD.")]
    ConditionalRealignement = SettlementDeniedReasonCode.ConditionalRealignement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request was denied since the instruction has been cancelled.
    /// Encoded/decoded by serializers as "DCAN".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_2nJuIVheEeS8HfHHd4stCA")]
    [Description(@"Request was denied since the instruction has been cancelled.")]
    DeniedSinceCancelled = SettlementDeniedReasonCode.DeniedSinceCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request was denied because the instruction was settled.
    /// Encoded/decoded by serializers as "DSET".
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_3B7loVheEeS8HfHHd4stCA")]
    [Description(@"Request was denied because the instruction was settled.")]
    DeniedSinceSettled = SettlementDeniedReasonCode.DeniedSinceSettled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request was denied because the process of settlement is in progress.
    /// Encoded/decoded by serializers as "DPRG".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_3iXZMVheEeS8HfHHd4stCA")]
    [Description(@"Request was denied because the process of settlement is in progress.")]
    DeniedSinceInProgress = SettlementDeniedReasonCode.DeniedSinceInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request was denied because the repo was cancelled.
    /// Encoded/decoded by serializers as "DREP".
    /// </summary>
    [EnumMember(Value = "DREP")]
    [IsoId("_3_0xQVheEeS8HfHHd4stCA")]
    [Description(@"Request was denied because the repo was cancelled.")]
    DeniedSinceRepoEnded = SettlementDeniedReasonCode.DeniedSinceRepoEnded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_4Y-REVheEeS8HfHHd4stCA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = SettlementDeniedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_4mzRsVheEeS8HfHHd4stCA")]
    [Description(@"Other. See Narrative.")]
    Other = SettlementDeniedReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is denied due to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as "CDRG".
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_AENlYV24EeS_LPIA7qJ58w")]
    [Description(@"Execution is denied due to the execution of a process at the registrar.")]
    ConditionalRegistrar = SettlementDeniedReasonCode.ConditionalRegistrar, // same ordinal as derivation source for type conversions
    
}
