﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountLevel2Code.  ISO2002 ID# _6Uas9pqlEeGSON8vddiWzQ_-1016370047.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the level of an account within the account hierarchy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Uas9pqlEeGSON8vddiWzQ_-1016370047")]
[Description(@"Defines the level of an account within the account hierarchy.")]
[DerivedFrom(typeof(AccountLevelCode))]
public enum AccountLevel2Code
{
    /// <summary>
    /// Intermediate level within an account hierarchy.
    /// Encoded/decoded by serializers as "Intermediate".
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_6Uas95qlEeGSON8vddiWzQ_-77486222")]
    [Description(@"Intermediate level within an account hierarchy.")]
    Intermediate,
    
    /// <summary>
    /// Highest level within an account hierarchy.
    /// Encoded/decoded by serializers as "Summary".
    /// </summary>
    [EnumMember(Value = "SMRY")]
    [IsoId("_6Ukd8JqlEeGSON8vddiWzQ_1446759063")]
    [Description(@"Highest level within an account hierarchy.")]
    Summary,
    
    /// <summary>
    /// Account is a real deposit/current account.
    /// Encoded/decoded by serializers as "Detail".
    /// </summary>
    [EnumMember(Value = "DETL")]
    [IsoId("_6Ukd8ZqlEeGSON8vddiWzQ_-2087443080")]
    [Description(@"Account is a real deposit/current account.")]
    Detail,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountLevel2CodeMetadataExtensions
{
    private static readonly AccountLevel2CodeDropdownSource _dropdownSource = new AccountLevel2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountLevel2CodeDropdownRow GetMetadata(this AccountLevel2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


