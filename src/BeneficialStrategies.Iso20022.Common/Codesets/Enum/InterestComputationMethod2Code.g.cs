﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterestComputationMethod2Code.  ISO2002 ID# _aZhWkNp-Ed-ak6NoX_4Aeg_163960764.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used to compute accruing interest of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aZhWkNp-Ed-ak6NoX_4Aeg_163960764")]
[Description(@"Specifies the method used to compute accruing interest of a financial instrument.")]
[DerivedFrom(typeof(InterestComputationMethodCode))]
public enum InterestComputationMethod2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IC30360ISDAor30360AmericanBasicRule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZhWkdp-Ed-ak6NoX_4Aeg_1728403415")]
    [Description(@"??")]
    IC30360ISDAor30360AmericanBasicRule,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IC30365".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZhWktp-Ed-ak6NoX_4Aeg_1728403804")]
    [Description(@"??")]
    IC30365,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IC30Actual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZhWk9p-Ed-ak6NoX_4Aeg_1728404207")]
    [Description(@"??")]
    IC30Actual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Actual360".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZhWlNp-Ed-ak6NoX_4Aeg_1728404362")]
    [Description(@"??")]
    Actual360,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Actual365Fixed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZhWldp-Ed-ak6NoX_4Aeg_1728404752")]
    [Description(@"??")]
    Actual365Fixed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ActualActualICMA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZhWltp-Ed-ak6NoX_4Aeg_1728405190")]
    [Description(@"??")]
    ActualActualICMA,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IC30E360orEuroBondBasismodel1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZhWl9p-Ed-ak6NoX_4Aeg_1728405353")]
    [Description(@"??")]
    IC30E360orEuroBondBasismodel1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ActualActualISDA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZhWmNp-Ed-ak6NoX_4Aeg_1728405743")]
    [Description(@"??")]
    ActualActualISDA,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Actual365LorActuActubasisRule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZhWmdp-Ed-ak6NoX_4Aeg_1728406163")]
    [Description(@"??")]
    Actual365LorActuActubasisRule,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ActualActualAFB".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZrHkNp-Ed-ak6NoX_4Aeg_1728406336")]
    [Description(@"??")]
    ActualActualAFB,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IC30360ICMAor30360basicrule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZrHkdp-Ed-ak6NoX_4Aeg_1728406708")]
    [Description(@"??")]
    IC30360ICMAor30360basicrule,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IC30E2360orEurobondbasismodel2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZrHktp-Ed-ak6NoX_4Aeg_1729326859")]
    [Description(@"??")]
    IC30E2360orEurobondbasismodel2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IC30E3360orEurobondbasismodel3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZrHk9p-Ed-ak6NoX_4Aeg_1729327284")]
    [Description(@"??")]
    IC30E3360orEurobondbasismodel3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Actual365NL".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZrHlNp-Ed-ak6NoX_4Aeg_1729327843")]
    [Description(@"??")]
    Actual365NL,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Narrative".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aZrHldp-Ed-ak6NoX_4Aeg_1729328300")]
    [Description(@"??")]
    Narrative,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InterestComputationMethod2CodeMetadataExtensions
{
    private static readonly InterestComputationMethod2CodeDropdownSource _dropdownSource = new InterestComputationMethod2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInterestComputationMethod2CodeDropdownRow GetMetadata(this InterestComputationMethod2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

