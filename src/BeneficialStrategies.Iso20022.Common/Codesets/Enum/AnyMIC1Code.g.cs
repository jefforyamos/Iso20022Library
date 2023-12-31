﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AnyMIC1Code.  ISO2002 ID# _PWEXMB3ZEeWNp95x0ENf8w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a market identification code (MIC).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PWEXMB3ZEeWNp95x0ENf8w")]
[Description(@"Specifies a market identification code (MIC).")]
[DerivedFrom(typeof(SpecialPurposeCode))]
public enum AnyMIC1Code
{
    /// <summary>
    /// Any MIC code.
    /// Encoded/decoded by serializers as "AnyMIC".
    /// </summary>
    [EnumMember(Value = "ANYM")]
    [IsoId("_SW4c0R3ZEeWNp95x0ENf8w")]
    [Description(@"Any MIC code.")]
    AnyMIC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AnyMIC1CodeMetadataExtensions
{
    private static readonly AnyMIC1CodeDropdownSource _dropdownSource = new AnyMIC1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAnyMIC1CodeDropdownRow GetMetadata(this AnyMIC1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


