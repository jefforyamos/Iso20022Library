﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CurrencyDesignationCode.  ISO2002 ID# _zhg64Qd1EeSPHJIdUs1USg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a currency is settled offshore or onshore.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zhg64Qd1EeSPHJIdUs1USg")]
[Description(@"Specifies whether a currency is settled offshore or onshore.")]
[Derivations(typeof(CurrencyDesignation1Code))]
public enum CurrencyDesignationCode
{
    /// <summary>
    /// Onshore.
    /// Encoded/decoded by serializers as "ONSH".
    /// </summary>
    [EnumMember(Value = "ONSH")]
    [IsoId("_6C154Ad1EeSPHJIdUs1USg")]
    [Description(@"Onshore.")]
    Onshore,
    
    /// <summary>
    /// Offshore.
    /// Encoded/decoded by serializers as "OFFS".
    /// </summary>
    [EnumMember(Value = "OFFS")]
    [IsoId("_80VxIAd1EeSPHJIdUs1USg")]
    [Description(@"Offshore.")]
    Offshore,
    
}
