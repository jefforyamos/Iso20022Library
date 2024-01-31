﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CreditQuality1Code.  ISO2002 ID# _cDPBAKckEeaGcf8_qtd8Yw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Credit rating that indicates a default or default-like process has begun, or the issuer is in standstill, or for a closed funding vehicle, payment capacity is irrevocably impaired.
    /// Encoded/decoded by serializers as "DFIM".
    /// </summary>
    [EnumMember(Value = "DFIM")]
    [IsoId("__w3O8apBEealmMs9XoW70w")]
    [Description(@"Credit rating that indicates a default or default-like process has begun, or the issuer is in standstill, or for a closed funding vehicle, payment capacity is irrevocably impaired.")]
    DefaultImminent = CreditQualityCode.DefaultImminent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Default of some kind appears probable.
    /// Encoded/decoded by serializers as "EXSP".
    /// </summary>
    [EnumMember(Value = "EXSP")]
    [IsoId("__45JkapBEealmMs9XoW70w")]
    [Description(@"Default of some kind appears probable.")]
    ExtremelySpeculative = CreditQualityCode.ExtremelySpeculative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit rating that denotes expectations of very low default risk. It indicates a very strong capacity for payment of financial commitments which is not significantly vulnerable to foreseeable events.
    /// Encoded/decoded by serializers as "HIGR".
    /// </summary>
    [EnumMember(Value = "HIGR")]
    [IsoId("_AACTYapCEealmMs9XoW70w")]
    [Description(@"Credit rating that denotes expectations of very low default risk. It indicates a very strong capacity for payment of financial commitments which is not significantly vulnerable to foreseeable events.")]
    HighGrade = CreditQualityCode.HighGrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit rating that indicates that material default risk is present, but a limited margin of safety remains. Financial commitments are currently being met; however, capacity for continued payment is vulnerable to deterioration in the business and economic environment.
    /// Encoded/decoded by serializers as "HISP".
    /// </summary>
    [EnumMember(Value = "HISP")]
    [IsoId("_AHBsMapCEealmMs9XoW70w")]
    [Description(@"Credit rating that indicates that material default risk is present, but a limited margin of safety remains. Financial commitments are currently being met; however, capacity for continued payment is vulnerable to deterioration in the business and economic environment.")]
    HighlySpeculative = CreditQualityCode.HighlySpeculative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit rating that indicates an issuer has entered into bankruptcy filings, administration, receivership, liquidation or other formal winding-up procedure or that has otherwise ceased business.
    /// Encoded/decoded by serializers as "INDF".
    /// </summary>
    [EnumMember(Value = "INDF")]
    [IsoId("_AN37EapCEealmMs9XoW70w")]
    [Description(@"Credit rating that indicates an issuer has entered into bankruptcy filings, administration, receivership, liquidation or other formal winding-up procedure or that has otherwise ceased business.")]
    InDefault = CreditQualityCode.InDefault, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit rating that indicates that expectations of default risk are currently low. The capacity for payment of financial commitments is considered adequate, but adverse business or economic conditions are more likely to impair this capacity.
    /// Encoded/decoded by serializers as "LMGR".
    /// </summary>
    [EnumMember(Value = "LMGR")]
    [IsoId("_AUuJ8apCEealmMs9XoW70w")]
    [Description(@"Credit rating that indicates that expectations of default risk are currently low. The capacity for payment of financial commitments is considered adequate, but adverse business or economic conditions are more likely to impair this capacity.")]
    LowerMediumGrade = CreditQualityCode.LowerMediumGrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit rating that indicates an elevated vulnerability to default risk, particularly in the event of adverse changes in business or economic conditions over time; however, business or financial flexibility exists that supports the servicing of financial commitments.
    /// Encoded/decoded by serializers as "NIGS".
    /// </summary>
    [EnumMember(Value = "NIGS")]
    [IsoId("_AcdJoapCEealmMs9XoW70w")]
    [Description(@"Credit rating that indicates an elevated vulnerability to default risk, particularly in the event of adverse changes in business or economic conditions over time; however, business or financial flexibility exists that supports the servicing of financial commitments.")]
    NonInvestmentGradeSpeculative = CreditQualityCode.NonInvestmentGradeSpeculative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit rating that denotes the lowest expectation of default risk. Assigned only in cases of exceptionally strong capacity for payment of financial commitments. Where the capacity to meet financial commitments is highly unlikely to be adversely affected by foreseeable events.
    /// Encoded/decoded by serializers as "PRIM".
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_AlrXEapCEealmMs9XoW70w")]
    [Description(@"Credit rating that denotes the lowest expectation of default risk. Assigned only in cases of exceptionally strong capacity for payment of financial commitments. Where the capacity to meet financial commitments is highly unlikely to be adversely affected by foreseeable events.")]
    Prime = CreditQualityCode.Prime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Default is a real possibility.
    /// Encoded/decoded by serializers as "SURI".
    /// </summary>
    [EnumMember(Value = "SURI")]
    [IsoId("_AtRM0apCEealmMs9XoW70w")]
    [Description(@"Default is a real possibility.")]
    SubstantialRisk = CreditQualityCode.SubstantialRisk, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit rating that denotes expectations of low default risk. The capacity for payment of financial commitments is considered strong. This capacity may, nevertheless, be more vulnerable to adverse business or economic conditions than is the case for higher ratings.
    /// Encoded/decoded by serializers as "UMGR".
    /// </summary>
    [EnumMember(Value = "UMGR")]
    [IsoId("_A1vzYapCEealmMs9XoW70w")]
    [Description(@"Credit rating that denotes expectations of low default risk. The capacity for payment of financial commitments is considered strong. This capacity may, nevertheless, be more vulnerable to adverse business or economic conditions than is the case for higher ratings.")]
    UpperMediumGrade = CreditQualityCode.UpperMediumGrade, // same ordinal as derivation source for type conversions
    
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


