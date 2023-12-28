﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfDate1Code.  ISO2002 ID# _TVs0sFfvEeOuDtoQo1qilA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a date is actual or estimated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVs0sFfvEeOuDtoQo1qilA")]
[Description(@"Specifies whether a date is actual or estimated.")]
[DerivedFrom(typeof(TypeOfDateCode))]
public enum TypeOfDate1Code
{
    /// <summary>
    /// Date / date and time is the actual date / date and time.
    /// Encoded/decoded by serializers as "Actual".
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_Ua4UEVfvEeOuDtoQo1qilA")]
    [Description(@"Date / date and time is the actual date / date and time.")]
    Actual,
    
    /// <summary>
    /// Date/date and time is estimated.
    /// Encoded/decoded by serializers as "Estimated".
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_UiUY0VfvEeOuDtoQo1qilA")]
    [Description(@"Date/date and time is estimated.")]
    Estimated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfDate1CodeMetadataExtensions
{
    private static readonly TypeOfDate1CodeDropdownSource _dropdownSource = new TypeOfDate1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfDate1CodeDropdownRow GetMetadata(this TypeOfDate1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


