﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StandingOrderType1Code.  ISO2002 ID# _8OFBU6MgEeCJ6YNENx4h-w_-143150650.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of standing order, such as a user defined standing order or a predefined liquidity transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8OFBU6MgEeCJ6YNENx4h-w_-143150650")]
[Description(@"Specifies the type of standing order, such as a user defined standing order or a predefined liquidity transfer.")]
[DerivedFrom(typeof(StandingOrderTypeCode))]
public enum StandingOrderType1Code
{
    /// <summary>
    /// Liquidity transfer standing order type, that has been customised or defined to the specific need of the user.
    /// Encoded/decoded by serializers as "UserDefinedStandingOrder".
    /// </summary>
    [EnumMember(Value = "USTO")]
    [IsoId("_8OFBVKMgEeCJ6YNENx4h-w_1846866247")]
    [Description(@"Liquidity transfer standing order type, that has been customised or defined to the specific need of the user.")]
    UserDefinedStandingOrder,
    
    /// <summary>
    /// Liquidity transfer standing order type, as predefined in the system.
    /// Encoded/decoded by serializers as "PredefinedStandingOrder".
    /// </summary>
    [EnumMember(Value = "PSTO")]
    [IsoId("_8OFBVaMgEeCJ6YNENx4h-w_328114765")]
    [Description(@"Liquidity transfer standing order type, as predefined in the system.")]
    PredefinedStandingOrder,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StandingOrderType1CodeMetadataExtensions
{
    private static readonly StandingOrderType1CodeDropdownSource _dropdownSource = new StandingOrderType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStandingOrderType1CodeDropdownRow GetMetadata(this StandingOrderType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


