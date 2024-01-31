﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestigationExecutionConfirmation5Code.  ISO2002 ID# _C7DOoB08EeiYoZGjIMHr2A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status on an investigation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_C7DOoB08EeiYoZGjIMHr2A")]
[Description(@"Provides the status on an investigation.")]
[DerivedFrom(typeof(InvestigationExecutionConfirmationCode))]
public enum InvestigationExecutionConfirmation5Code
{
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as "CNCL".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_S-p1IR08EeiYoZGjIMHr2A")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest = InvestigationExecutionConfirmationCode.CancelledAsPerRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation is pending.
    /// Encoded/decoded by serializers as "PDCR".
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_Uebl0h08EeiYoZGjIMHr2A")]
    [Description(@"Used when a requested cancellation is pending.")]
    PendingCancellationRequest = InvestigationExecutionConfirmationCode.PendingCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation has been rejected.
    /// Encoded/decoded by serializers as "RJCR".
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_VBa-Ih08EeiYoZGjIMHr2A")]
    [Description(@"Used when a requested cancellation has been rejected.")]
    RejectedCancellationRequest = InvestigationExecutionConfirmationCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestigationExecutionConfirmation5CodeMetadataExtensions
{
    private static readonly InvestigationExecutionConfirmation5CodeDropdownSource _dropdownSource = new InvestigationExecutionConfirmation5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestigationExecutionConfirmation5CodeDropdownRow GetMetadata(this InvestigationExecutionConfirmation5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


