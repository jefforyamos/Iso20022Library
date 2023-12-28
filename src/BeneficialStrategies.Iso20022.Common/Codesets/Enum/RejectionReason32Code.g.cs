﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason32Code.  ISO2002 ID# _POtDcUAuEeGeCKosDOIVvQ_1275943519.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Unrecognised or invalid depository.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_POtDcUAuEeGeCKosDOIVvQ_1275943519")]
[Description(@"Unrecognised or invalid depository.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason32Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_POtDckAuEeGeCKosDOIVvQ_290415620")]
    [Description(@"??")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_POtDc0AuEeGeCKosDOIVvQ_1444288981")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PO20cEAuEeGeCKosDOIVvQ_-127436514")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotFoundRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PO20cUAuEeGeCKosDOIVvQ_-1085893749")]
    [Description(@"??")]
    NotFoundRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PO20ckAuEeGeCKosDOIVvQ_-489704418")]
    [Description(@"??")]
    ReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoMatch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PO20c0AuEeGeCKosDOIVvQ_1877174322")]
    [Description(@"??")]
    NoMatch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PO20dEAuEeGeCKosDOIVvQ_1937778798")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason32CodeMetadataExtensions
{
    private static readonly RejectionReason32CodeDropdownSource _dropdownSource = new RejectionReason32CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason32CodeDropdownRow GetMetadata(this RejectionReason32Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

