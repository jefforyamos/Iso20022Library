﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LimitType1Code.  ISO2002 ID# _Vof3ldp-Ed-ak6NoX_4Aeg_-702729300.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of risk management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vof3ldp-Ed-ak6NoX_4Aeg_-702729300")]
[Description(@"Specifies the type of risk management limit.")]
[DerivedFrom(typeof(LimitTypeCode))]
public enum LimitType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Multilateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vof3ltp-Ed-ak6NoX_4Aeg_-230810934")]
    [Description(@"??")]
    Multilateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bilateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vof3l9p-Ed-ak6NoX_4Aeg_-230810874")]
    [Description(@"??")]
    Bilateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NetBilateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vof3mNp-Ed-ak6NoX_4Aeg_-230810779")]
    [Description(@"??")]
    NetBilateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IndirectBilateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vof3mdp-Ed-ak6NoX_4Aeg_-230810425")]
    [Description(@"??")]
    IndirectBilateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Global".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VopBgNp-Ed-ak6NoX_4Aeg_-230810039")]
    [Description(@"??")]
    Global,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LimitType1CodeMetadataExtensions
{
    private static readonly LimitType1CodeDropdownSource _dropdownSource = new LimitType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILimitType1CodeDropdownRow GetMetadata(this LimitType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

