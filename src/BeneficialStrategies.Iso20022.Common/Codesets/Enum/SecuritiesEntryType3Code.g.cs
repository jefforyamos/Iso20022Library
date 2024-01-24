﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesEntryType3Code.  ISO2002 ID# _AJfyYDUFEe2tRf29bleifQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities entry on an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AJfyYDUFEe2tRf29bleifQ")]
[Description(@"Specifies the type of securities entry on an account.")]
[DerivedFrom(typeof(SecuritiesEntryTypeCode))]
public enum SecuritiesEntryType3Code
{
    /// <summary>
    /// Total number of securities eligible for this event.
    /// Encoded/decoded by serializers as "ELIG".
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_RmChwTUFEe2tRf29bleifQ")]
    [Description(@"Total number of securities eligible for this event.")]
    Eligible = SecuritiesEntryTypeCode.Eligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of uninstructed position.
    /// Encoded/decoded by serializers as "UNBA".
    /// </summary>
    [EnumMember(Value = "UNBA")]
    [IsoId("_SBw0cTUFEe2tRf29bleifQ")]
    [Description(@"Balance of uninstructed position.")]
    UninstructedBalance = SecuritiesEntryTypeCode.UninstructedBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of instructed position.
    /// Encoded/decoded by serializers as "INBA".
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_SrfG4TUFEe2tRf29bleifQ")]
    [Description(@"Balance of instructed position.")]
    InstructedBalance = SecuritiesEntryTypeCode.InstructedBalance, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesEntryType3CodeMetadataExtensions
{
    private static readonly SecuritiesEntryType3CodeDropdownSource _dropdownSource = new SecuritiesEntryType3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesEntryType3CodeDropdownRow GetMetadata(this SecuritiesEntryType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


