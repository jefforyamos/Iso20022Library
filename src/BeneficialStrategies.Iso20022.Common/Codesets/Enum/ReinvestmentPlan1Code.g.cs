﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReinvestmentPlan1Code.  ISO2002 ID# _INWe4Ff9EeOuDtoQo1qilA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the specific reinvestment plan type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_INWe4Ff9EeOuDtoQo1qilA")]
[Description(@"Indicates the specific reinvestment plan type.")]
[DerivedFrom(typeof(ReinvestmentPlanCode))]
public enum ReinvestmentPlan1Code
{
    /// <summary>
    /// Reinvestment plan is for retail investors only.
    /// Encoded/decoded by serializers as "ForRetailInvestorsOnly".
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_Jc8egVf9EeOuDtoQo1qilA")]
    [Description(@"Reinvestment plan is for retail investors only.")]
    ForRetailInvestorsOnly,
    
    /// <summary>
    /// Full reinvestment plan offered.
    /// Encoded/decoded by serializers as "FullReinvestmentPlanOffered".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_JkiUQVf9EeOuDtoQo1qilA")]
    [Description(@"Full reinvestment plan offered.")]
    FullReinvestmentPlanOffered,
    
    /// <summary>
    /// Reinvestment plan is subject to shareholder approval.
    /// Encoded/decoded by serializers as "SubjectToShareholderApproval".
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("_JuNNoVf9EeOuDtoQo1qilA")]
    [Description(@"Reinvestment plan is subject to shareholder approval.")]
    SubjectToShareholderApproval,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReinvestmentPlan1CodeMetadataExtensions
{
    private static readonly ReinvestmentPlan1CodeDropdownSource _dropdownSource = new ReinvestmentPlan1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReinvestmentPlan1CodeDropdownRow GetMetadata(this ReinvestmentPlan1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


