﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestorType3Code.  ISO2002 ID# _H58RoNdkEeibyvRfU9vJ7w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H58RoNdkEeibyvRfU9vJ7w")]
[Description(@"Specifies the type of investor.")]
[DerivedFrom(typeof(InvestorTypeCode))]
public enum InvestorType3Code
{
    /// <summary>
    /// Investor is a retail investor.
    /// Encoded/decoded by serializers as "Retail".
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_KSbzAddkEeibyvRfU9vJ7w")]
    [Description(@"Investor is a retail investor.")]
    Retail,
    
    /// <summary>
    /// Investor is professional or professional per se.
    /// Encoded/decoded by serializers as "ProfessionalOrPerSe".
    /// </summary>
    [EnumMember(Value = "PRF2")]
    [IsoId("_LvkfYddkEeibyvRfU9vJ7w")]
    [Description(@"Investor is professional or professional per se.")]
    ProfessionalOrPerSe,
    
    /// <summary>
    /// Investor is neither professional or retail.
    /// Encoded/decoded by serializers as "NeitherProfessionalOrRetail".
    /// </summary>
    [EnumMember(Value = "NEI1")]
    [IsoId("_Mq77cddkEeibyvRfU9vJ7w")]
    [Description(@"Investor is neither professional or retail.")]
    NeitherProfessionalOrRetail,
    
    /// <summary>
    /// Investor is both professional and retail.
    /// Encoded/decoded by serializers as "BothProfessionalAndRetail".
    /// </summary>
    [EnumMember(Value = "BOT2")]
    [IsoId("_NgC-gddkEeibyvRfU9vJ7w")]
    [Description(@"Investor is both professional and retail.")]
    BothProfessionalAndRetail,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestorType3CodeMetadataExtensions
{
    private static readonly InvestorType3CodeDropdownSource _dropdownSource = new InvestorType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestorType3CodeDropdownRow GetMetadata(this InvestorType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


