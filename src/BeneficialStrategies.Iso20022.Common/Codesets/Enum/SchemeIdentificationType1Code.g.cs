﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SchemeIdentificationType1Code.  ISO2002 ID# _GvWnULh1Eea3PLWeF1tJsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Domain of an identifier.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GvWnULh1Eea3PLWeF1tJsQ")]
[Description(@"Domain of an identifier.")]
[DerivedFrom(typeof(SchemeIdentificationTypeCode))]
public enum SchemeIdentificationType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarginAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Gz2FkXa-Eee2GNSe_4BSzQ")]
    [Description(@"??")]
    MarginAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CollateralAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_G6lmwXa-Eee2GNSe_4BSzQ")]
    [Description(@"??")]
    CollateralAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PositionAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_HFG0sXa-Eee2GNSe_4BSzQ")]
    [Description(@"??")]
    PositionAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClearingMemberAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YWoVkXtNEee8tZ67_DQBAw")]
    [Description(@"??")]
    ClearingMemberAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SchemeIdentificationType1CodeMetadataExtensions
{
    private static readonly SchemeIdentificationType1CodeDropdownSource _dropdownSource = new SchemeIdentificationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISchemeIdentificationType1CodeDropdownRow GetMetadata(this SchemeIdentificationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


