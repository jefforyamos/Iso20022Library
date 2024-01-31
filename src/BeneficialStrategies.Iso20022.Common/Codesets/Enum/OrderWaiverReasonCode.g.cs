﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderWaiverReasonCode.  ISO2002 ID# _ZwscBtp-Ed-ak6NoX_4Aeg_-2076610546.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies investment fund processes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZwscBtp-Ed-ak6NoX_4Aeg_-2076610546")]
[Description(@"Specifies investment fund processes.")]
[Derivations(typeof(OrderWaiverReason1Code))]
public enum OrderWaiverReasonCode
{
    /// <summary>
    /// Dealing of the trade is outside the normal limit.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZwscB9p-Ed-ak6NoX_4Aeg_-1281455618")]
    [Description(@"Dealing of the trade is outside the normal limit.")]
    LateTradeDealing,
    
    /// <summary>
    /// Front end load charge differs from PPM.
    /// Encoded/decoded by serializers as "FEND".
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_ZwscCNp-Ed-ak6NoX_4Aeg_-791990734")]
    [Description(@"Front end load charge differs from PPM.")]
    FrontEndLoadCharge,
    
    /// <summary>
    /// Amount of subscription is below the minimum initial investment amount.
    /// Encoded/decoded by serializers as "BMIN".
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_Zw1l8Np-Ed-ak6NoX_4Aeg_-307141806")]
    [Description(@"Amount of subscription is below the minimum initial investment amount.")]
    BelowMinimumInvestmentAmount,
    
    /// <summary>
    /// Cut off date has been passed.
    /// Encoded/decoded by serializers as "CUTO".
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_Zw1l8dp-Ed-ak6NoX_4Aeg_-204631374")]
    [Description(@"Cut off date has been passed.")]
    CutOffDate,
    
    /// <summary>
    /// Standard commission is waived.
    /// Encoded/decoded by serializers as "COMW".
    /// </summary>
    [EnumMember(Value = "COMW")]
    [IsoId("_Zw1l8tp-Ed-ak6NoX_4Aeg_-1357804984")]
    [Description(@"Standard commission is waived.")]
    CommissionWaiver,
    
    /// <summary>
    /// General waiver.
    /// Encoded/decoded by serializers as "WAIV".
    /// </summary>
    [EnumMember(Value = "WAIV")]
    [IsoId("_ep-90NnYEeSy3ba5KBm7wA")]
    [Description(@"General waiver.")]
    GenericWaiver,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderWaiverReasonCodeMetadataExtensions
{
    private static readonly OrderWaiverReasonCodeDropdownSource _dropdownSource = new OrderWaiverReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderWaiverReasonCodeDropdownRow GetMetadata(this OrderWaiverReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


