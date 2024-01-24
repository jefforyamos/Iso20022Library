﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NotionalOrUnitBased1Code.  ISO2002 ID# _xlFEgJ9WEeqxTNfi5y7ywQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the unit basis of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xlFEgJ9WEeqxTNfi5y7ywQ")]
[Description(@"Specifies the unit basis of a financial instrument.")]
[DerivedFrom(typeof(NotionalOrUnitBasedCode))]
public enum NotionalOrUnitBased1Code
{
    /// <summary>
    /// Basis of a financial instrument is unit.
    /// Encoded/decoded by serializers as "UNIT".
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_1AhQoZ9WEeqxTNfi5y7ywQ")]
    [Description(@"Basis of a financial instrument is unit.")]
    Unit = NotionalOrUnitBasedCode.Unit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Basis of a financial instrument is notional.
    /// Encoded/decoded by serializers as "NOTI".
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_1G6zkZ9WEeqxTNfi5y7ywQ")]
    [Description(@"Basis of a financial instrument is notional.")]
    Notional = NotionalOrUnitBasedCode.Notional, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NotionalOrUnitBased1CodeMetadataExtensions
{
    private static readonly NotionalOrUnitBased1CodeDropdownSource _dropdownSource = new NotionalOrUnitBased1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INotionalOrUnitBased1CodeDropdownRow GetMetadata(this NotionalOrUnitBased1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


