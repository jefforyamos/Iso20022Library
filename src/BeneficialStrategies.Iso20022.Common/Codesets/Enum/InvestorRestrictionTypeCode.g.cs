﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestorRestrictionTypeCode.  ISO2002 ID# _adQAAtp-Ed-ak6NoX_4Aeg_935487797.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies to whom or what the restriction applies.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_adQAAtp-Ed-ak6NoX_4Aeg_935487797")]
[Description(@"Specifies to whom or what the restriction applies.")]
[Derivations(typeof(InvestorRestrictionType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum InvestorRestrictionTypeCode
{
    /// <summary>
    /// Restriction applies to a legal resident.
    /// Encoded/decoded by serializers as "LERE".
    /// </summary>
    [EnumMember(Value = "LERE")]
    [IsoId("_adQAA9p-Ed-ak6NoX_4Aeg_1438807698")]
    [Description(@"Restriction applies to a legal resident.")]
    LegalResident,
    
    /// <summary>
    /// Restriction applies to a citizen.
    /// Encoded/decoded by serializers as "CITI".
    /// </summary>
    [EnumMember(Value = "CITI")]
    [IsoId("_adQABNp-Ed-ak6NoX_4Aeg_1439730879")]
    [Description(@"Restriction applies to a citizen.")]
    Citizen,
    
    /// <summary>
    /// Restriction applies to an individual.
    /// Encoded/decoded by serializers as "INDV".
    /// </summary>
    [EnumMember(Value = "INDV")]
    [IsoId("_adQABdp-Ed-ak6NoX_4Aeg_1441575812")]
    [Description(@"Restriction applies to an individual.")]
    Individual,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestorRestrictionTypeCodeMetadataExtensions
{
    private static readonly InvestorRestrictionTypeCodeDropdownSource _dropdownSource = new InvestorRestrictionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestorRestrictionTypeCodeDropdownRow GetMetadata(this InvestorRestrictionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


