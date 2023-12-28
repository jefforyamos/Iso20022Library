﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CompensationMethodCode.  ISO2002 ID# _6Vwww5qlEeGSON8vddiWzQ_197335871.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines if and how charges and taxes due are paid to the financial institution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Vwww5qlEeGSON8vddiWzQ_197335871")]
[Description(@"Defines if and how charges and taxes due are paid to the financial institution.")]
public enum CompensationMethodCode
{
    /// <summary>
    /// Account does not pay and charges or taxes due.
    /// Encoded/decoded by serializers as "NOCP".
    /// </summary>
    [EnumMember(Value = "NOCP")]
    [IsoId("_6VwwxJqlEeGSON8vddiWzQ_375454543")]
    [Description(@"Account does not pay and charges or taxes due.")]
    No,
    
    /// <summary>
    /// Account is debited for any charges or taxes due.
    /// Encoded/decoded by serializers as "DBTD".
    /// </summary>
    [EnumMember(Value = "DBTD")]
    [IsoId("_6VwwxZqlEeGSON8vddiWzQ_83496805")]
    [Description(@"Account is debited for any charges or taxes due.")]
    Debited,
    
    /// <summary>
    /// Account or summary account is invoiced for any charges or taxes due.
    /// Encoded/decoded by serializers as "INVD".
    /// </summary>
    [EnumMember(Value = "INVD")]
    [IsoId("_6VwwxpqlEeGSON8vddiWzQ_1842603306")]
    [Description(@"Account or summary account is invoiced for any charges or taxes due.")]
    Invoiced,
    
    /// <summary>
    /// Account is automatically debited on a future date.
    /// Encoded/decoded by serializers as "DDBT".
    /// </summary>
    [EnumMember(Value = "DDBT")]
    [IsoId("_6Vwwx5qlEeGSON8vddiWzQ_-799736482")]
    [Description(@"Account is automatically debited on a future date.")]
    DelayedDebit,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CompensationMethodCodeMetadataExtensions
{
    private static readonly CompensationMethodCodeDropdownSource _dropdownSource = new CompensationMethodCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICompensationMethodCodeDropdownRow GetMetadata(this CompensationMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

