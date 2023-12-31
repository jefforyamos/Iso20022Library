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
    /// Instruction was received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_6MzwwVhfEeSsH9MSoogb7Q")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__VT7oVhfEeSsH9MSoogb7Q")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as "PendingBeneficiaryOwnerDetails".
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_A6xdkVhgEeSsH9MSoogb7Q")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails,
    
    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as "MissingCertification".
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_BrRtcVhgEeSsH9MSoogb7Q")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification,
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as "InsufficientMoney".
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_CFdIAVhgEeSsH9MSoogb7Q")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,
    
    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as "LackOfSecurities".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_DaQ-0VhgEeSsH9MSoogb7Q")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities,
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_DrhG4VhgEeSsH9MSoogb7Q")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as "QuantityDisagreement".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_KfSgwVhgEeSsH9MSoogb7Q")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement,
    
    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as "PendingReceipt".
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_Pl_74VhgEeSsH9MSoogb7Q")]
    [Description(@"The instruction is pending receipt of securities, for example, from a purchase, loan etc.")]
    PendingReceipt,
    
    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as "WrongCertificatesNumbers".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_Z8DwwVhgEeSsH9MSoogb7Q")]
    [Description(@"Certificate number error.")]
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


