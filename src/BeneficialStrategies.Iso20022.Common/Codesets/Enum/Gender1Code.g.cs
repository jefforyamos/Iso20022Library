﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Gender1Code.  ISO2002 ID# _JyNe4IoTEeahcZ3Nzs1Qag.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the gender of a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JyNe4IoTEeahcZ3Nzs1Qag")]
[Description(@"Specifies the gender of a person.")]
[DerivedFrom(typeof(GenderCode))]
public enum Gender1Code
{
    /// <summary>
    /// Individual is a female.
    /// Encoded/decoded by serializers as "Female".
    /// </summary>
    [EnumMember(Value = "FEMA")]
    [IsoId("_LwE5wYoTEeahcZ3Nzs1Qag")]
    [Description(@"Individual is a female.")]
    Female,
    
    /// <summary>
    /// Individual is a male.
    /// Encoded/decoded by serializers as "Male".
    /// </summary>
    [EnumMember(Value = "MALE")]
    [IsoId("_L01d8YoTEeahcZ3Nzs1Qag")]
    [Description(@"Individual is a male.")]
    Male,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Gender1CodeMetadataExtensions
{
    private static readonly Gender1CodeDropdownSource _dropdownSource = new Gender1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGender1CodeDropdownRow GetMetadata(this Gender1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


