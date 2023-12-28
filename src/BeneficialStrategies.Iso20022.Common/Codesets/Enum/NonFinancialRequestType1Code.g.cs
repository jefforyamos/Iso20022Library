﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NonFinancialRequestType1Code.  ISO2002 ID# _a6o5MC_rEeugIJ3Gvoevmg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a6o5MC_rEeugIJ3Gvoevmg")]
[Description(@"Type of non financial request that could be processed between an Acceptor and an Intermediary Agent or an Acquirer.")]
[DerivedFrom(typeof(NonFinancialRequestTypeCode))]
public enum NonFinancialRequestType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcquirerSelection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hzPIsS_rEeugIJ3Gvoevmg")]
    [Description(@"??")]
    AcquirerSelection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ParRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_h4cY0S_rEeugIJ3Gvoevmg")]
    [Description(@"??")]
    ParRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RiskManagement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_h8-TgS_rEeugIJ3Gvoevmg")]
    [Description(@"??")]
    RiskManagement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TokenRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iB8TES_rEeugIJ3Gvoevmg")]
    [Description(@"??")]
    TokenRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NonFinancialRequestType1CodeMetadataExtensions
{
    private static readonly NonFinancialRequestType1CodeDropdownSource _dropdownSource = new NonFinancialRequestType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INonFinancialRequestType1CodeDropdownRow GetMetadata(this NonFinancialRequestType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

