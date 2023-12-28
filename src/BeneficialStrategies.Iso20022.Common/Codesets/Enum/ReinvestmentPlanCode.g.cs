﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReinvestmentPlanCode.  ISO2002 ID# _tyUxkVf8EeOuDtoQo1qilA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the specific reinvestment plan type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tyUxkVf8EeOuDtoQo1qilA")]
[Description(@"Indicates the specific reinvestment plan type.")]
public enum ReinvestmentPlanCode
{
    /// <summary>
    /// Reinvestment plan is for retail investors only.
    /// Encoded/decoded by serializers as "RETA".
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_0FXc8Ff8EeOuDtoQo1qilA")]
    [Description(@"Reinvestment plan is for retail investors only.")]
    ForRetailInvestorsOnly,
    
    /// <summary>
    /// Full reinvestment plan offered.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_6eN1YFf8EeOuDtoQo1qilA")]
    [Description(@"Full reinvestment plan offered.")]
    FullReinvestmentPlanOffered,
    
    /// <summary>
    /// Reinvestment plan is subject to shareholder approval.
    /// Encoded/decoded by serializers as "SUAP".
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("__Q_n4Ff8EeOuDtoQo1qilA")]
    [Description(@"Reinvestment plan is subject to shareholder approval.")]
    SubjectToShareholderApproval,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReinvestmentPlanCodeMetadataExtensions
{
    private static readonly ReinvestmentPlanCodeDropdownSource _dropdownSource = new ReinvestmentPlanCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReinvestmentPlanCodeDropdownRow GetMetadata(this ReinvestmentPlanCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


