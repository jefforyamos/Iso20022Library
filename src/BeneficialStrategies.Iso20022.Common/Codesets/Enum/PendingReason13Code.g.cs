﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingReason13Code.  ISO2002 ID# _wtDRwFhfEeSsH9MSoogb7Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wtDRwFhfEeSsH9MSoogb7Q")]
[Description(@"Specifies the reason why the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum PendingReason13Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6MzwwVhfEeSsH9MSoogb7Q")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__VT7oVhfEeSsH9MSoogb7Q")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingBeneficiaryOwnerDetails".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_A6xdkVhgEeSsH9MSoogb7Q")]
    [Description(@"??")]
    PendingBeneficiaryOwnerDetails,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingCertification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BrRtcVhgEeSsH9MSoogb7Q")]
    [Description(@"??")]
    MissingCertification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsufficientMoney".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_CFdIAVhgEeSsH9MSoogb7Q")]
    [Description(@"??")]
    InsufficientMoney,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_DaQ-0VhgEeSsH9MSoogb7Q")]
    [Description(@"??")]
    LackOfSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_DrhG4VhgEeSsH9MSoogb7Q")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityDisagreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KfSgwVhgEeSsH9MSoogb7Q")]
    [Description(@"??")]
    QuantityDisagreement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingReceipt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Pl_74VhgEeSsH9MSoogb7Q")]
    [Description(@"??")]
    PendingReceipt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WrongCertificatesNumbers".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8DwwVhgEeSsH9MSoogb7Q")]
    [Description(@"??")]
    WrongCertificatesNumbers,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingReason13CodeMetadataExtensions
{
    private static readonly PendingReason13CodeDropdownSource _dropdownSource = new PendingReason13CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingReason13CodeDropdownRow GetMetadata(this PendingReason13Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


