﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingMethodCode.  ISO2002 ID# _YrGs8Np-Ed-ak6NoX_4Aeg_627416882.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used for the negotiation and execution of a trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrGs8Np-Ed-ak6NoX_4Aeg_627416882")]
[Description(@"Specifies the method used for the negotiation and execution of a trade.")]
public enum TradingMethodCode
{
    /// <summary>
    /// Trade executed through an electronic trading system.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_YrGs8dp-Ed-ak6NoX_4Aeg_627416883")]
    [Description(@"Trade executed through an electronic trading system.")]
    ELEC,
    
    /// <summary>
    /// Trade executed over the phone.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_YrGs8tp-Ed-ak6NoX_4Aeg_627416884")]
    [Description(@"Trade executed over the phone.")]
    PHON,
    
    /// <summary>
    /// Trade executed through a broker.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_YrGs89p-Ed-ak6NoX_4Aeg_627416885")]
    [Description(@"Trade executed through a broker.")]
    BROK,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingMethodCodeMetadataExtensions
{
    private static readonly TradingMethodCodeDropdownSource _dropdownSource = new TradingMethodCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingMethodCodeDropdownRow GetMetadata(this TradingMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


