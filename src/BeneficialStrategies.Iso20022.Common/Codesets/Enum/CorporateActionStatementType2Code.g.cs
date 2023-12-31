﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionStatementType2Code.  ISO2002 ID# _0mALAbtEEeilsanBGAzy4A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the statement contains missing instructions only or all instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mALAbtEEeilsanBGAzy4A")]
[Description(@"Indicates whether the statement contains missing instructions only or all instructions.")]
[DerivedFrom(typeof(CorporateActionStatementTypeCode))]
public enum CorporateActionStatementType2Code
{
    /// <summary>
    /// Statement contains missing instructions.
    /// Encoded/decoded by serializers as "Missing".
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_03aEEbtEEeilsanBGAzy4A")]
    [Description(@"Statement contains missing instructions.")]
    Missing,
    
    /// <summary>
    /// Statement contains all instructions.
    /// Encoded/decoded by serializers as "All".
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_03aEE7tEEeilsanBGAzy4A")]
    [Description(@"Statement contains all instructions.")]
    All,
    
    /// <summary>
    /// Balance information with no instruction details provided.
    /// Encoded/decoded by serializers as "BalanceOnlyNotification".
    /// </summary>
    [EnumMember(Value = "BALO")]
    [IsoId("_WIwwAbtFEeilsanBGAzy4A")]
    [Description(@"Balance information with no instruction details provided.")]
    BalanceOnlyNotification,
    
    /// <summary>
    /// Balance information with instruction details.
    /// Encoded/decoded by serializers as "BalanceInformation".
    /// </summary>
    [EnumMember(Value = "BALI")]
    [IsoId("_WSKjortFEeilsanBGAzy4A")]
    [Description(@"Balance information with instruction details.")]
    BalanceInformation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionStatementType2CodeMetadataExtensions
{
    private static readonly CorporateActionStatementType2CodeDropdownSource _dropdownSource = new CorporateActionStatementType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionStatementType2CodeDropdownRow GetMetadata(this CorporateActionStatementType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


