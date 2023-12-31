﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionDeadline1Code.  ISO2002 ID# _bDPpCNp-Ed-ak6NoX_4Aeg_474204484.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the deadline reference of a corporate action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDPpCNp-Ed-ak6NoX_4Aeg_474204484")]
[Description(@"Specifies the deadline reference of a corporate action.")]
[DerivedFrom(typeof(CorporateActionReferenceDateCode))]
public enum CorporateActionDeadline1Code
{
    /// <summary>
    /// Issuer or issuer's agent deadline to respond, with an election instruction, to an outstanding offer or privilege.
    /// Encoded/decoded by serializers as "MarketDeadline".
    /// </summary>
    [EnumMember(Value = "MKDT")]
    [IsoId("_bDPpCdp-Ed-ak6NoX_4Aeg_803900500")]
    [Description(@"Issuer or issuer's agent deadline to respond, with an election instruction, to an outstanding offer or privilege.")]
    MarketDeadline,
    
    /// <summary>
    /// Date on which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// Encoded/decoded by serializers as "ResponseDeadline".
    /// </summary>
    [EnumMember(Value = "RDDT")]
    [IsoId("_bDZaANp-Ed-ak6NoX_4Aeg_819599893")]
    [Description(@"Date on which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).")]
    ResponseDeadline,
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// Encoded/decoded by serializers as "EarlyResponseDeadline".
    /// </summary>
    [EnumMember(Value = "EARD")]
    [IsoId("_bDZaAdp-Ed-ak6NoX_4Aeg_842687467")]
    [Description(@"Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).")]
    EarlyResponseDeadline,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionDeadline1CodeMetadataExtensions
{
    private static readonly CorporateActionDeadline1CodeDropdownSource _dropdownSource = new CorporateActionDeadline1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionDeadline1CodeDropdownRow GetMetadata(this CorporateActionDeadline1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


