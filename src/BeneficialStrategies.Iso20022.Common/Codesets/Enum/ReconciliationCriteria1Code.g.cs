﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReconciliationCriteria1Code.  ISO2002 ID# _InBvQCpWEeuUucRY0yCMTA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Available criterion to group transactions when a reconliation is made.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_InBvQCpWEeuUucRY0yCMTA")]
[Description(@"Available criterion to group transactions when a reconliation is made.")]
[DerivedFrom(typeof(ReconciliationCriteriaCode))]
public enum ReconciliationCriteria1Code
{
    /// <summary>
    /// The set is defined by transactions made with cards belonging  to the same brand.
    /// Encoded/decoded by serializers as "CardBrand".
    /// </summary>
    [EnumMember(Value = "BRND")]
    [IsoId("_T3JYoSpWEeuUucRY0yCMTA")]
    [Description(@"The set is defined by transactions made with cards belonging  to the same brand.")]
    CardBrand,
    
    /// <summary>
    /// The set is defined by transactions made with cards sharing the same CardProductProfile.
    /// Encoded/decoded by serializers as "CardProductProfile".
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_UHVwwSpWEeuUucRY0yCMTA")]
    [Description(@"The set is defined by transactions made with cards sharing the same CardProductProfile.")]
    CardProductProfile,
    
    /// <summary>
    /// The set is defined by transactions processed by POIs identified with the same POIGroup.
    /// Encoded/decoded by serializers as "PoiGroup".
    /// </summary>
    [EnumMember(Value = "GRUP")]
    [IsoId("_UJQcUSpWEeuUucRY0yCMTA")]
    [Description(@"The set is defined by transactions processed by POIs identified with the same POIGroup.")]
    PoiGroup,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReconciliationCriteria1CodeMetadataExtensions
{
    private static readonly ReconciliationCriteria1CodeDropdownSource _dropdownSource = new ReconciliationCriteria1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReconciliationCriteria1CodeDropdownRow GetMetadata(this ReconciliationCriteria1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


