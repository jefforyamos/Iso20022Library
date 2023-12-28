﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderRestrictions1Code.  ISO2002 ID# _aReN09p-Ed-ak6NoX_4Aeg_-414935483.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the classification and thus the restrictions associated with an order (for regulatory purposes).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aReN09p-Ed-ak6NoX_4Aeg_-414935483")]
[Description(@"Identifies the classification and thus the restrictions associated with an order (for regulatory purposes).")]
[DerivedFrom(typeof(OrderClassificationCode))]
public enum OrderRestrictions1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProgramTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aReN1Np-Ed-ak6NoX_4Aeg_1960362266")]
    [Description(@"??")]
    ProgramTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IndexArbitrage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aReN1dp-Ed-ak6NoX_4Aeg_1960362301")]
    [Description(@"??")]
    IndexArbitrage,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonIndexArbitrage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aReN1tp-Ed-ak6NoX_4Aeg_1960362319")]
    [Description(@"??")]
    NonIndexArbitrage,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetingMarketMaker".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aReN19p-Ed-ak6NoX_4Aeg_1960362379")]
    [Description(@"??")]
    CompetingMarketMaker,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SpecialistInSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aReN2Np-Ed-ak6NoX_4Aeg_1960362421")]
    [Description(@"??")]
    SpecialistInSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SpecialistInUnderlyingSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aRn-0Np-Ed-ak6NoX_4Aeg_1960362456")]
    [Description(@"??")]
    SpecialistInUnderlyingSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignEntity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aRn-0dp-Ed-ak6NoX_4Aeg_1960362516")]
    [Description(@"??")]
    ForeignEntity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExternalMarketParticipant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aRn-0tp-Ed-ak6NoX_4Aeg_1960362776")]
    [Description(@"??")]
    ExternalMarketParticipant,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExternalInterConnectedMarketLinkage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aRn-09p-Ed-ak6NoX_4Aeg_1960362828")]
    [Description(@"??")]
    ExternalInterConnectedMarketLinkage,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RisklessArbitrage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aRn-1Np-Ed-ak6NoX_4Aeg_1960362888")]
    [Description(@"??")]
    RisklessArbitrage,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderRestrictions1CodeMetadataExtensions
{
    private static readonly OrderRestrictions1CodeDropdownSource _dropdownSource = new OrderRestrictions1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderRestrictions1CodeDropdownRow GetMetadata(this OrderRestrictions1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


