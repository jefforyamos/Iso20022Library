﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfAmount8Code.  ISO2002 ID# _f6oSka11EeawR4FMacHsRQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualifies the amount associated with the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_f6oSka11EeawR4FMacHsRQ")]
[Description(@"Qualifies the amount associated with the transaction.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount8Code
{
    /// <summary>
    /// Actual amount.
    /// Encoded/decoded by serializers as "Actual".
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_gKHgEa11EeawR4FMacHsRQ")]
    [Description(@"Actual amount.")]
    Actual,
    
    /// <summary>
    /// Estimated amount (the final amount could be above or below).
    /// Encoded/decoded by serializers as "Estimated".
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_gKHgE611EeawR4FMacHsRQ")]
    [Description(@"Estimated amount (the final amount could be above or below).")]
    Estimated,
    
    /// <summary>
    /// Maximum amount (the final amount must be less or equal).
    /// Encoded/decoded by serializers as "Maximum".
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_gKHgFa11EeawR4FMacHsRQ")]
    [Description(@"Maximum amount (the final amount must be less or equal).")]
    Maximum,
    
    /// <summary>
    /// Default amount.
    /// Encoded/decoded by serializers as "Default".
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_gKHgF611EeawR4FMacHsRQ")]
    [Description(@"Default amount.")]
    Default,
    
    /// <summary>
    /// Replacement amount.
    /// Encoded/decoded by serializers as "Replacement".
    /// </summary>
    [EnumMember(Value = "RPLT")]
    [IsoId("_gKHgGa11EeawR4FMacHsRQ")]
    [Description(@"Replacement amount.")]
    Replacement,
    
    /// <summary>
    /// Incremental amount for reservation.
    /// Encoded/decoded by serializers as "Incremental".
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_ldQNoa11EeawR4FMacHsRQ")]
    [Description(@"Incremental amount for reservation.")]
    Incremental,
    
    /// <summary>
    /// Decremental amount for reservation.
    /// Encoded/decoded by serializers as "Decremental".
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_mJlvMa11EeawR4FMacHsRQ")]
    [Description(@"Decremental amount for reservation.")]
    Decremental,
    
    /// <summary>
    /// Reserved or updated reserved amount for reservation.
    /// Encoded/decoded by serializers as "Reserved".
    /// </summary>
    [EnumMember(Value = "RESD")]
    [IsoId("_m246Ea11EeawR4FMacHsRQ")]
    [Description(@"Reserved or updated reserved amount for reservation.")]
    Reserved,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfAmount8CodeMetadataExtensions
{
    private static readonly TypeOfAmount8CodeDropdownSource _dropdownSource = new TypeOfAmount8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfAmount8CodeDropdownRow GetMetadata(this TypeOfAmount8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


