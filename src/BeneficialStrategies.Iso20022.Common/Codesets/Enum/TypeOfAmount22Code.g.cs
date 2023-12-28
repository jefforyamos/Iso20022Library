﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfAmount22Code.  ISO2002 ID# _7MFYEFFFEeyhmN3K0lwfug.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type or class of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7MFYEFFFEeyhmN3K0lwfug")]
[Description(@"Type or class of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount22Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Actual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-9S_4VFFEeyhmN3K0lwfug")]
    [Description(@"??")]
    Actual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Default".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__unIEVFFEeyhmN3K0lwfug")]
    [Description(@"??")]
    Default,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Deposit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ARnHcVFGEeyhmN3K0lwfug")]
    [Description(@"??")]
    Deposit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Estimated".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Al1rAVFGEeyhmN3K0lwfug")]
    [Description(@"??")]
    Estimated,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Maximum".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BQzTkVFGEeyhmN3K0lwfug")]
    [Description(@"??")]
    Maximum,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Proxy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_CP_fsVFGEeyhmN3K0lwfug")]
    [Description(@"??")]
    Proxy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reserved".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_DV9CMVFGEeyhmN3K0lwfug")]
    [Description(@"??")]
    Reserved,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfAmount22CodeMetadataExtensions
{
    private static readonly TypeOfAmount22CodeDropdownSource _dropdownSource = new TypeOfAmount22CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfAmount22CodeDropdownRow GetMetadata(this TypeOfAmount22Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


