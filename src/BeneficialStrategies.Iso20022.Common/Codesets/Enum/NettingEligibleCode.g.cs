﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NettingEligibleCode.  ISO2002 ID# _YZ0Ipdp-Ed-ak6NoX_4Aeg_-1067297210.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the trade is eligible for netting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZ0Ipdp-Ed-ak6NoX_4Aeg_-1067297210")]
[Description(@"Specifies whether the trade is eligible for netting.")]
[Derivations(typeof(NettingEligible1Code))]
public enum NettingEligibleCode
{
    /// <summary>
    /// Indicates that the trade is not eligible for settlement netting.
    /// Encoded/decoded by serializers as "GROS".
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_YZ0Iptp-Ed-ak6NoX_4Aeg_-104590487")]
    [Description(@"Indicates that the trade is not eligible for settlement netting.")]
    Gross,
    
    /// <summary>
    /// Indicates that the trade is eligible for settlement netting.
    /// Encoded/decoded by serializers as "NETT".
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_YZ0Ip9p-Ed-ak6NoX_4Aeg_2047176134")]
    [Description(@"Indicates that the trade is eligible for settlement netting.")]
    Nett,
    
    /// <summary>
    /// Grouping of receipts/purchases to create one settlement obligation, and the grouping of deliveries/sales to create one settlement obligation.
    /// Encoded/decoded by serializers as "AGFS".
    /// </summary>
    [EnumMember(Value = "AGFS")]
    [IsoId("_YZ0IqNp-Ed-ak6NoX_4Aeg_-674500416")]
    [Description(@"Grouping of receipts/purchases to create one settlement obligation, and the grouping of deliveries/sales to create one settlement obligation.")]
    AggregationForSettlement,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NettingEligibleCodeMetadataExtensions
{
    private static readonly NettingEligibleCodeDropdownSource _dropdownSource = new NettingEligibleCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INettingEligibleCodeDropdownRow GetMetadata(this NettingEligibleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


