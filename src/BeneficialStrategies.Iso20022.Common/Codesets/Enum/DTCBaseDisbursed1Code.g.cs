﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCBaseDisbursed1Code.  ISO2002 ID# _1qBZgzL3EeKU9IrkkToqcw_633983663.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code qualifying whether the calculation basis is on base (original) or disbursed (distributed) security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1qBZgzL3EeKU9IrkkToqcw_633983663")]
[Description(@"Code qualifying whether the calculation basis is on base (original) or disbursed (distributed) security.")]
[DerivedFrom(typeof(DTCBaseDisbursedCode))]
public enum DTCBaseDisbursed1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Base".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1qBZhDL3EeKU9IrkkToqcw_-1482681313")]
    [Description(@"??")]
    Base,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Disbursed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1qBZhTL3EeKU9IrkkToqcw_-1596520379")]
    [Description(@"??")]
    Disbursed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCBaseDisbursed1CodeMetadataExtensions
{
    private static readonly DTCBaseDisbursed1CodeDropdownSource _dropdownSource = new DTCBaseDisbursed1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCBaseDisbursed1CodeDropdownRow GetMetadata(this DTCBaseDisbursed1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

