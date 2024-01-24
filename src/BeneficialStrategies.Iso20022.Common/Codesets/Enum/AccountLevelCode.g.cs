﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountLevelCode.  ISO2002 ID# _6Ukd8pqlEeGSON8vddiWzQ_1919731713.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the level of an account within the account hierarchy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Ukd8pqlEeGSON8vddiWzQ_1919731713")]
[Description(@"Defines the level of an account within the account hierarchy.")]
[Derivations(typeof(AccountLevel2Code),typeof(AccountLevel1Code))]
public enum AccountLevelCode
{
    /// <summary>
    /// Intermediate level within an account hierarchy.
    /// Encoded/decoded by serializers as "INTM".
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_6Ukd85qlEeGSON8vddiWzQ_-2115419931")]
    [Description(@"Intermediate level within an account hierarchy.")]
    Intermediate,
    
    /// <summary>
    /// Highest level within an account hierarchy.
    /// Encoded/decoded by serializers as "SMRY".
    /// </summary>
    [EnumMember(Value = "SMRY")]
    [IsoId("_6Ukd9JqlEeGSON8vddiWzQ_-1741194392")]
    [Description(@"Highest level within an account hierarchy.")]
    Summary,
    
    /// <summary>
    /// Account is a real deposit/current account.
    /// Encoded/decoded by serializers as "DETL".
    /// </summary>
    [EnumMember(Value = "DETL")]
    [IsoId("_6Ukd9ZqlEeGSON8vddiWzQ_-1690984951")]
    [Description(@"Account is a real deposit/current account.")]
    Detail,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountLevelCodeMetadataExtensions
{
    private static readonly AccountLevelCodeDropdownSource _dropdownSource = new AccountLevelCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountLevelCodeDropdownRow GetMetadata(this AccountLevelCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


