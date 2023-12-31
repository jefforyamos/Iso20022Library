﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentNeed1Code.  ISO2002 ID# _7RZv0DcdEeidBoT_PugKiA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an investment need.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7RZv0DcdEeidBoT_PugKiA")]
[Description(@"Specifies an investment need.")]
[DerivedFrom(typeof(InvestmentNeedCode))]
public enum InvestmentNeed1Code
{
    /// <summary>
    /// Investment need is for environmental social corporate governance.
    /// 
    /// Encoded/decoded by serializers as "EnvironmentalSocialCorporateGovernance".
    /// </summary>
    [EnumMember(Value = "ESGO")]
    [IsoId("_-DCJ8TcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for environmental social corporate governance. ")]
    EnvironmentalSocialCorporateGovernance,
    
    /// <summary>
    /// Investment need is for ethical investment.
    /// Encoded/decoded by serializers as "EthicalInvestment".
    /// </summary>
    [EnumMember(Value = "ETHI")]
    [IsoId("_-IFpETcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for ethical investment.")]
    EthicalInvestment,
    
    /// <summary>
    /// Investment need is for green investment.
    /// Encoded/decoded by serializers as "GreenInvestment".
    /// </summary>
    [EnumMember(Value = "GRIN")]
    [IsoId("_-NJvQTcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for green investment.")]
    GreenInvestment,
    
    /// <summary>
    /// Investment need is for Islamic banking.
    /// Encoded/decoded by serializers as "IslamicBanking".
    /// </summary>
    [EnumMember(Value = "ISLB")]
    [IsoId("_-SgJUTcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for Islamic banking.")]
    IslamicBanking,
    
    /// <summary>
    /// No specific need.
    /// Encoded/decoded by serializers as "None".
    /// </summary>
    [EnumMember(Value = "NSPE")]
    [IsoId("_-US5ETcdEeidBoT_PugKiA")]
    [Description(@"No specific need.")]
    None,
    
    /// <summary>
    /// Other specific need.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-ZgJMTcdEeidBoT_PugKiA")]
    [Description(@"Other specific need.")]
    Other,
    
    /// <summary>
    /// Specific investment need.
    /// Encoded/decoded by serializers as "SpecificNeed".
    /// </summary>
    [EnumMember(Value = "YSPE")]
    [IsoId("_c_wd0el4Eei6w4V2u1HOBw")]
    [Description(@"Specific investment need.")]
    SpecificNeed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentNeed1CodeMetadataExtensions
{
    private static readonly InvestmentNeed1CodeDropdownSource _dropdownSource = new InvestmentNeed1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentNeed1CodeDropdownRow GetMetadata(this InvestmentNeed1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


