﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StandingOrderTypeCode.  ISO2002 ID# _8N7QU6MgEeCJ6YNENx4h-w_814542161.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of standing order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8N7QU6MgEeCJ6YNENx4h-w_814542161")]
[Description(@"Specifies the type of standing order.")]
[Derivations(typeof(StandingOrderType1Code))]
public enum StandingOrderTypeCode
{
    /// <summary>
    /// Liquidity transfer standing order type, that has been customised or defined to the specific need of the user.
    /// Encoded/decoded by serializers as "USTO".
    /// </summary>
    [EnumMember(Value = "USTO")]
    [IsoId("_8N7QVKMgEeCJ6YNENx4h-w_-1951616938")]
    [Description(@"Liquidity transfer standing order type, that has been customised or defined to the specific need of the user.")]
    UserDefinedStandingOrder,
    
    /// <summary>
    /// Liquidity transfer standing order type, as predefined in the system.
    /// Encoded/decoded by serializers as "PSTO".
    /// </summary>
    [EnumMember(Value = "PSTO")]
    [IsoId("_8N7QVaMgEeCJ6YNENx4h-w_1666330764")]
    [Description(@"Liquidity transfer standing order type, as predefined in the system.")]
    PredefinedStandingOrder,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StandingOrderTypeCodeMetadataExtensions
{
    private static readonly StandingOrderTypeCodeDropdownSource _dropdownSource = new StandingOrderTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStandingOrderTypeCodeDropdownRow GetMetadata(this StandingOrderTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


