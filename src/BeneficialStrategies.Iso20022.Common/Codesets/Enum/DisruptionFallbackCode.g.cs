﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DisruptionFallbackCode.  ISO2002 ID# _awUtBtp-Ed-ak6NoX_4Aeg_627416917.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the method used to determine a settlement rate when a disruption event has occurred.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awUtBtp-Ed-ak6NoX_4Aeg_627416917")]
[Description(@"Identifies the method used to determine a settlement rate when a disruption event has occurred.")]
public enum DisruptionFallbackCode
{
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "AOCL")]
    [IsoId("_awUtB9p-Ed-ak6NoX_4Aeg_627416918")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    AOCL,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "CADS")]
    [IsoId("_awUtCNp-Ed-ak6NoX_4Aeg_627417183")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    CADS,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "DLVS")]
    [IsoId("_awd28Np-Ed-ak6NoX_4Aeg_627417184")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    DLVS,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("_awd28dp-Ed-ak6NoX_4Aeg_627417192")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    ESCA,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "FBRP")]
    [IsoId("_awd28tp-Ed-ak6NoX_4Aeg_627417193")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    FBRP,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "LASG")]
    [IsoId("_awd289p-Ed-ak6NoX_4Aeg_627417194")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    LASG,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "LASN")]
    [IsoId("_awd29Np-Ed-ak6NoX_4Aeg_627417195")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    LASN,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "LCYS")]
    [IsoId("_awd29dp-Ed-ak6NoX_4Aeg_627417196")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    LCYS,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "NFTR")]
    [IsoId("_awd29tp-Ed-ak6NoX_4Aeg_627417197")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    NFTR,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "NDLS")]
    [IsoId("_awd299p-Ed-ak6NoX_4Aeg_627417206")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    NDLS,
    
    /// <summary>
    /// As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.
    /// </summary>
    [EnumMember(Value = "STPP")]
    [IsoId("_awd2-Np-Ed-ak6NoX_4Aeg_627417207")]
    [Description(@"As per the 1998 FX and Currency Option Definitions published by the International Swaps and Derivatives Association inc., the Emerging Market Traders Association and the Foreign Exchange Committee.")]
    STPP,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DisruptionFallbackCodeMetadataExtensions
{
    private static readonly DisruptionFallbackCodeDropdownSource _dropdownSource = new DisruptionFallbackCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDisruptionFallbackCodeDropdownRow GetMetadata(this DisruptionFallbackCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


