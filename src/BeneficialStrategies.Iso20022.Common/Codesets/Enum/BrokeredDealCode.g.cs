﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BrokeredDealCode.  ISO2002 ID# _TXL5MHvREeWrWYBng3OpVw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the transaction is arranged via a third party broker or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TXL5MHvREeWrWYBng3OpVw")]
[Description(@"Specifies whether the transaction is arranged via a third party broker or not.")]
public enum BrokeredDealCode
{
    /// <summary>
    /// Transaction was arranged by a third party broking agent.
    /// 
    /// 
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_WQ54UHvREeWrWYBng3OpVw")]
    [Description(@"Transaction was arranged by a third party broking agent.  ")]
    BROK,
    
    /// <summary>
    /// Transaction was arranged directly by the reporting agent.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_WXrOsHvREeWrWYBng3OpVw")]
    [Description(@"Transaction was arranged directly by the reporting agent.")]
    BILA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BrokeredDealCodeMetadataExtensions
{
    private static readonly BrokeredDealCodeDropdownSource _dropdownSource = new BrokeredDealCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBrokeredDealCodeDropdownRow GetMetadata(this BrokeredDealCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


