﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GoodsAndServicesSubTypeCode.  ISO2002 ID# _38ZrgOkCEemeDPHh-U9b6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Sub type of goods and services purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_38ZrgOkCEemeDPHh-U9b6w")]
[Description(@"Sub type of goods and services purchased.")]
[Derivations(typeof(GoodsAndServicesSubType1Code))]
public enum GoodsAndServicesSubTypeCode
{
    /// <summary>
    /// Sub type applied is securities.
    /// Encoded/decoded by serializers as "SECS".
    /// </summary>
    [EnumMember(Value = "SECS")]
    [IsoId("_Ltug8OkDEemeDPHh-U9b6w")]
    [Description(@"Sub type applied is securities.")]
    Securities,
    
    /// <summary>
    /// Sub type applied is foreign exchange.
    /// Encoded/decoded by serializers as "FORX".
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_o3JuMOkDEemeDPHh-U9b6w")]
    [Description(@"Sub type applied is foreign exchange.")]
    ForeignExchange,
    
    /// <summary>
    /// Sub type applied is cryptocurrency.
    /// Encoded/decoded by serializers as "CRCU".
    /// </summary>
    [EnumMember(Value = "CRCU")]
    [IsoId("_zqKk0OkDEemeDPHh-U9b6w")]
    [Description(@"Sub type applied is cryptocurrency.")]
    CryptoCurrency,
    
    /// <summary>
    /// Other sub type of goods and service at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_B5UyMOkEEemeDPHh-U9b6w")]
    [Description(@"Other sub type of goods and service at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other sub type of goods and service at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_bnpKgOkEEemeDPHh-U9b6w")]
    [Description(@"Other sub type of goods and service at private level.")]
    OtherPrivate,
    
}
