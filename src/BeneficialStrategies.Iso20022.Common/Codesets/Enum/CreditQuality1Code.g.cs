﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CreditQuality1Code.  ISO2002 ID# _cDPBAKckEeaGcf8_qtd8Yw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Assessment of the credit quality of a party or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cDPBAKckEeaGcf8_qtd8Yw")]
[Description(@"Assessment of the credit quality of a party or financial instrument.")]
[DerivedFrom(typeof(CreditQualityCode))]
public enum CreditQuality1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DefaultImminent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__w3O8apBEealmMs9XoW70w")]
    [Description(@"??")]
    DefaultImminent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExtremelySpeculative".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__45JkapBEealmMs9XoW70w")]
    [Description(@"??")]
    ExtremelySpeculative,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HighGrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AACTYapCEealmMs9XoW70w")]
    [Description(@"??")]
    HighGrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HighlySpeculative".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AHBsMapCEealmMs9XoW70w")]
    [Description(@"??")]
    HighlySpeculative,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InDefault".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AN37EapCEealmMs9XoW70w")]
    [Description(@"??")]
    InDefault,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LowerMediumGrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AUuJ8apCEealmMs9XoW70w")]
    [Description(@"??")]
    LowerMediumGrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonInvestmentGradeSpeculative".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AcdJoapCEealmMs9XoW70w")]
    [Description(@"??")]
    NonInvestmentGradeSpeculative,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Prime".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AlrXEapCEealmMs9XoW70w")]
    [Description(@"??")]
    Prime,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SubstantialRisk".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AtRM0apCEealmMs9XoW70w")]
    [Description(@"??")]
    SubstantialRisk,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UpperMediumGrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_A1vzYapCEealmMs9XoW70w")]
    [Description(@"??")]
    UpperMediumGrade,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CreditQuality1CodeMetadataExtensions
{
    private static readonly CreditQuality1CodeDropdownSource _dropdownSource = new CreditQuality1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICreditQuality1CodeDropdownRow GetMetadata(this CreditQuality1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

