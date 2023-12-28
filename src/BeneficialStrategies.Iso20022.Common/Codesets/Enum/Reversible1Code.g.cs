﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Reversible1Code.  ISO2002 ID# __v1ShtojEeC60axPepSq7g_1110549094.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__v1ShtojEeC60axPepSq7g_1110549094")]
[Description(@"Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date.")]
[DerivedFrom(typeof(ReversibleCode))]
public enum Reversible1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reversible".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__v_DgNojEeC60axPepSq7g_-721289092")]
    [Description(@"??")]
    Reversible,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Fixed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__v_DgdojEeC60axPepSq7g_745859671")]
    [Description(@"??")]
    Fixed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CallBack".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__v_DgtojEeC60axPepSq7g_589215960")]
    [Description(@"??")]
    CallBack,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Reversible1CodeMetadataExtensions
{
    private static readonly Reversible1CodeDropdownSource _dropdownSource = new Reversible1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReversible1CodeDropdownRow GetMetadata(this Reversible1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

