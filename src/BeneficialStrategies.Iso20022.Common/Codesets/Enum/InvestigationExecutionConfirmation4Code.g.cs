﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestigationExecutionConfirmation4Code.  ISO2002 ID# _abTfSdp-Ed-ak6NoX_4Aeg_-698007078.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the result of an investigation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_abTfSdp-Ed-ak6NoX_4Aeg_-698007078")]
[Description(@"Indicates the result of an investigation.")]
[DerivedFrom(typeof(InvestigationExecutionConfirmationCode))]
public enum InvestigationExecutionConfirmation4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyExecutedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_abdQQNp-Ed-ak6NoX_4Aeg_-698006802")]
    [Description(@"??")]
    PartiallyExecutedCancellationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_abdQQdp-Ed-ak6NoX_4Aeg_-698006801")]
    [Description(@"??")]
    RejectedCancellationRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestigationExecutionConfirmation4CodeMetadataExtensions
{
    private static readonly InvestigationExecutionConfirmation4CodeDropdownSource _dropdownSource = new InvestigationExecutionConfirmation4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestigationExecutionConfirmation4CodeDropdownRow GetMetadata(this InvestigationExecutionConfirmation4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


