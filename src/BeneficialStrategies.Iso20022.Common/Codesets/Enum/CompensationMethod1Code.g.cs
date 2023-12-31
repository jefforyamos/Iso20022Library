﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CompensationMethod1Code.  ISO2002 ID# _6Vm_x5qlEeGSON8vddiWzQ_2080901699.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines if and how charges and taxes due are paid to the financial institution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Vm_x5qlEeGSON8vddiWzQ_2080901699")]
[Description(@"Defines if and how charges and taxes due are paid to the financial institution.")]
[DerivedFrom(typeof(CompensationMethodCode))]
public enum CompensationMethod1Code
{
    /// <summary>
    /// Account does not pay and charges or taxes due.
    /// Encoded/decoded by serializers as "No".
    /// </summary>
    [EnumMember(Value = "NOCP")]
    [IsoId("_6Vm_yJqlEeGSON8vddiWzQ_-1993728072")]
    [Description(@"Account does not pay and charges or taxes due.")]
    No,
    
    /// <summary>
    /// Account is debited for any charges or taxes due.
    /// Encoded/decoded by serializers as "Debited".
    /// </summary>
    [EnumMember(Value = "DBTD")]
    [IsoId("_6VwwwJqlEeGSON8vddiWzQ_-1432359176")]
    [Description(@"Account is debited for any charges or taxes due.")]
    Debited,
    
    /// <summary>
    /// Account or summary account is invoiced for any charges or taxes due.
    /// Encoded/decoded by serializers as "Invoiced".
    /// </summary>
    [EnumMember(Value = "INVD")]
    [IsoId("_6VwwwZqlEeGSON8vddiWzQ_1164179586")]
    [Description(@"Account or summary account is invoiced for any charges or taxes due.")]
    Invoiced,
    
    /// <summary>
    /// Account is automatically debited on a future date.
    /// Encoded/decoded by serializers as "DelayedDebit".
    /// </summary>
    [EnumMember(Value = "DDBT")]
    [IsoId("_6VwwwpqlEeGSON8vddiWzQ_-174770726")]
    [Description(@"Account is automatically debited on a future date.")]
    DelayedDebit,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CompensationMethod1CodeMetadataExtensions
{
    private static readonly CompensationMethod1CodeDropdownSource _dropdownSource = new CompensationMethod1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICompensationMethod1CodeDropdownRow GetMetadata(this CompensationMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


