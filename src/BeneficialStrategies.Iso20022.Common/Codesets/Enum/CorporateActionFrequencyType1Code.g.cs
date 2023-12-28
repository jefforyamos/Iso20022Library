﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionFrequencyType1Code.  ISO2002 ID# _bJ8t99p-Ed-ak6NoX_4Aeg_1457749701.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the frequency of a CA event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bJ8t99p-Ed-ak6NoX_4Aeg_1457749701")]
[Description(@"Specifies the frequency of a CA event.")]
[DerivedFrom(typeof(CorporateActionFrequencyTypeCode))]
public enum CorporateActionFrequencyType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Final".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bJ8t-Np-Ed-ak6NoX_4Aeg_1457749703")]
    [Description(@"??")]
    Final,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bKGe8Np-Ed-ak6NoX_4Aeg_1457749980")]
    [Description(@"??")]
    Interim,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Regular".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bKGe8dp-Ed-ak6NoX_4Aeg_1457749981")]
    [Description(@"??")]
    Regular,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Special".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bKGe8tp-Ed-ak6NoX_4Aeg_1457749982")]
    [Description(@"??")]
    Special,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionFrequencyType1CodeMetadataExtensions
{
    private static readonly CorporateActionFrequencyType1CodeDropdownSource _dropdownSource = new CorporateActionFrequencyType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionFrequencyType1CodeDropdownRow GetMetadata(this CorporateActionFrequencyType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

