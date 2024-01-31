﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Provided1Code.  ISO2002 ID# _UbfaUBKFEeKj15WxqwlXPw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether items have been provided.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UbfaUBKFEeKj15WxqwlXPw")]
[Description(@"Specifies whether items have been provided.")]
[DerivedFrom(typeof(ProvidedCode))]
public enum Provided1Code
{
    /// <summary>
    /// Not provided.
    /// Encoded/decoded by serializers as "NPRO".
    /// </summary>
    [EnumMember(Value = "NPRO")]
    [IsoId("_ba2ZIRKFEeKj15WxqwlXPw")]
    [Description(@"Not provided.")]
    NotProvided = ProvidedCode.NotProvided, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provided.
    /// Encoded/decoded by serializers as "PROV".
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_bllCcRKFEeKj15WxqwlXPw")]
    [Description(@"Provided.")]
    Provided = ProvidedCode.Provided, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Provided1CodeMetadataExtensions
{
    private static readonly Provided1CodeDropdownSource _dropdownSource = new Provided1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProvided1CodeDropdownRow GetMetadata(this Provided1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


