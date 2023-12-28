﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfDateCode.  ISO2002 ID# _Oxs3y2-BEeKuY41pq1-dog.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a date is actual or estimated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Oxs3y2-BEeKuY41pq1-dog")]
[Description(@"Specifies whether a date is actual or estimated.")]
public enum TypeOfDateCode
{
    /// <summary>
    /// Date/date and time is estimated.
    /// Encoded/decoded by serializers as "ESTM".
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_Oxs3zm-BEeKuY41pq1-dog")]
    [Description(@"Date/date and time is estimated.")]
    Estimated,
    
    /// <summary>
    /// Date / date and time is the actual date / date and time.
    /// Encoded/decoded by serializers as "ACTL".
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_Oxs31W-BEeKuY41pq1-dog")]
    [Description(@"Date / date and time is the actual date / date and time.")]
    Actual,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfDateCodeMetadataExtensions
{
    private static readonly TypeOfDateCodeDropdownSource _dropdownSource = new TypeOfDateCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfDateCodeDropdownRow GetMetadata(this TypeOfDateCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


