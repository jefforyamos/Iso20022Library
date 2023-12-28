﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReconciliationCriteriaCode.  ISO2002 ID# _7DGFoCpUEeuUucRY0yCMTA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Available criterion to group transactions when a reconliation is made.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7DGFoCpUEeuUucRY0yCMTA")]
[Description(@"Available criterion to group transactions when a reconliation is made.")]
[Derivations(typeof(ReconciliationCriteria1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ReconciliationCriteriaCode
{
    /// <summary>
    /// The set is defined by transactions processed by POIs identified with the same POIGroup.
    /// Encoded/decoded by serializers as "GRUP".
    /// </summary>
    [EnumMember(Value = "GRUP")]
    [IsoId("_ZNckYCpVEeuUucRY0yCMTA")]
    [Description(@"The set is defined by transactions processed by POIs identified with the same POIGroup.")]
    PoiGroup,
    
    /// <summary>
    /// The set is defined by transactions made with cards sharing the same CardProductProfile.
    /// Encoded/decoded by serializers as "PROF".
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_t62AgCpVEeuUucRY0yCMTA")]
    [Description(@"The set is defined by transactions made with cards sharing the same CardProductProfile.")]
    CardProductProfile,
    
    /// <summary>
    /// The set is defined by transactions made with cards belonging  to the same brand.
    /// Encoded/decoded by serializers as "BRND".
    /// </summary>
    [EnumMember(Value = "BRND")]
    [IsoId("_7_6dwCpVEeuUucRY0yCMTA")]
    [Description(@"The set is defined by transactions made with cards belonging  to the same brand.")]
    CardBrand,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReconciliationCriteriaCodeMetadataExtensions
{
    private static readonly ReconciliationCriteriaCodeDropdownSource _dropdownSource = new ReconciliationCriteriaCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReconciliationCriteriaCodeDropdownRow GetMetadata(this ReconciliationCriteriaCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


