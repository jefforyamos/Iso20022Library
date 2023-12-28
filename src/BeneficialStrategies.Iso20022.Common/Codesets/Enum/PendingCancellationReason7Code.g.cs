﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingCancellationReason7Code.  ISO2002 ID# _K1iIwBUOEeuYppTwWp55gA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_K1iIwBUOEeuYppTwWp55gA")]
[Description(@"Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum PendingCancellationReason7Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_REiosRUOEeuYppTwWp55gA")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as "AwaitingConfirmation".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_RTuUMRUOEeuYppTwWp55gA")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_SVU7IRUOEeuYppTwWp55gA")]
    [Description(@"Other. See Narrative.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingCancellationReason7CodeMetadataExtensions
{
    private static readonly PendingCancellationReason7CodeDropdownSource _dropdownSource = new PendingCancellationReason7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingCancellationReason7CodeDropdownRow GetMetadata(this PendingCancellationReason7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


