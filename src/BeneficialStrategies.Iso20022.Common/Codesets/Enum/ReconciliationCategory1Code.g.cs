﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReconciliationCategory1Code.  ISO2002 ID# _Z1GFgC7NEemIy6A-26wnAg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the reconciliation category.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z1GFgC7NEemIy6A-26wnAg")]
[Description(@"Contains the reconciliation category.")]
[DerivedFrom(typeof(ReconciliationCategoryCode))]
public enum ReconciliationCategory1Code
{
    /// <summary>
    /// Reconciliation category is reversal.
    /// Encoded/decoded by serializers as "Reversal".
    /// </summary>
    [EnumMember(Value = "RVSL")]
    [IsoId("_cav5IS7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is reversal.")]
    Reversal,
    
    /// <summary>
    /// Reconciliation category is other private
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_cfaWsS7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is other private")]
    OtherPrivate,
    
    /// <summary>
    /// Reconciliation category is other national.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_cjOfsS7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is other national.")]
    OtherNational,
    
    /// <summary>
    /// Reconciliation category is financial.
    /// Encoded/decoded by serializers as "Financial".
    /// </summary>
    [EnumMember(Value = "FNCL")]
    [IsoId("_cquO0S7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is financial.")]
    Financial,
    
    /// <summary>
    /// Reconciliation category is a chargeback.
    /// Encoded/decoded by serializers as "Chargeback".
    /// </summary>
    [EnumMember(Value = "CGBK")]
    [IsoId("_cu_DwS7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is a chargeback.")]
    Chargeback,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReconciliationCategory1CodeMetadataExtensions
{
    private static readonly ReconciliationCategory1CodeDropdownSource _dropdownSource = new ReconciliationCategory1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReconciliationCategory1CodeDropdownRow GetMetadata(this ReconciliationCategory1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


