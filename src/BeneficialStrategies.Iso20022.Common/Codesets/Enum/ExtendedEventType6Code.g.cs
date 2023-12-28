﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExtendedEventType6Code.  ISO2002 ID# _32I1Ub_pEeeb2ZBoAlSG1Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_32I1Ub_pEeeb2ZBoAlSG1Q")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.")]
[DerivedFrom(typeof(ExtendedEventTypeV2Code))]
public enum ExtendedEventType6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Termination".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4GDgob_pEeeb2ZBoAlSG1Q")]
    [Description(@"??")]
    Termination,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FinalPaydown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4GDgo7_pEeeb2ZBoAlSG1Q")]
    [Description(@"??")]
    FinalPaydown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CertificateOfDepositEarlyRedemption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4GDgpb_pEeeb2ZBoAlSG1Q")]
    [Description(@"??")]
    CertificateOfDepositEarlyRedemption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RedemptionOfWarrant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BkJywb_qEeeb2ZBoAlSG1Q")]
    [Description(@"??")]
    RedemptionOfWarrant,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExtendedEventType6CodeMetadataExtensions
{
    private static readonly ExtendedEventType6CodeDropdownSource _dropdownSource = new ExtendedEventType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExtendedEventType6CodeDropdownRow GetMetadata(this ExtendedEventType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

