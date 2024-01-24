﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxReclaimMethod1Code.  ISO2002 ID# _5jRhwDEuEemzCpWiCwK4aQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains Tax Reclaim options
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5jRhwDEuEemzCpWiCwK4aQ")]
[Description(@"Contains Tax Reclaim options")]
[DerivedFrom(typeof(TaxReclaimMethodCode))]
public enum TaxReclaimMethod1Code
{
    /// <summary>
    /// Invoice printed and given to purchaser and then used for tax reclaim
    /// Encoded/decoded by serializers as "INPP".
    /// </summary>
    [EnumMember(Value = "INPP")]
    [IsoId("_8RyWcTEuEemzCpWiCwK4aQ")]
    [Description(@"Invoice printed and given to purchaser and then used for tax reclaim")]
    InvoicePrintedPrimary = TaxReclaimMethodCode.InvoicePrintedPrimary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invoice printed but treated as supplemental because electronic copy is used for tax reclaim
    /// Encoded/decoded by serializers as "INPS".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_8lwbUTEuEemzCpWiCwK4aQ")]
    [Description(@"Invoice printed but treated as supplemental because electronic copy is used for tax reclaim")]
    InvoicePrintedSupplimental = TaxReclaimMethodCode.InvoicePrintedSupplimental, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Printed invoice suppressed because electronic master version is used for tax reclaim
    /// Encoded/decoded by serializers as "INSU".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_866zATEuEemzCpWiCwK4aQ")]
    [Description(@"Printed invoice suppressed because electronic master version is used for tax reclaim")]
    InvoiceSuppressed = TaxReclaimMethodCode.InvoiceSuppressed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other tax reclaim method not elsewhere specified
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_9QYFoTEuEemzCpWiCwK4aQ")]
    [Description(@"Other tax reclaim method not elsewhere specified")]
    Other = TaxReclaimMethodCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxReclaimMethod1CodeMetadataExtensions
{
    private static readonly TaxReclaimMethod1CodeDropdownSource _dropdownSource = new TaxReclaimMethod1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxReclaimMethod1CodeDropdownRow GetMetadata(this TaxReclaimMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


