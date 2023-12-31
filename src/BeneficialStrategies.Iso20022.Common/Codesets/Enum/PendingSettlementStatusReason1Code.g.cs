﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingSettlementStatusReason1Code.  ISO2002 ID# _VjSAYdp-Ed-ak6NoX_4Aeg_1304044269.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction settlement pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VjSAYdp-Ed-ak6NoX_4Aeg_1304044269")]
[Description(@"Specifies the reason for a transfer or settlement instruction settlement pending status.")]
[DerivedFrom(typeof(PendingSettlementStatusReasonCode))]
public enum PendingSettlementStatusReason1Code
{
    /// <summary>
    /// Securities have not yet been received from the counterparty.
    /// Encoded/decoded by serializers as "AwaitingSharesFromCounterparty".
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_VjSAYtp-Ed-ak6NoX_4Aeg_-938732240")]
    [Description(@"Securities have not yet been received from the counterparty.")]
    AwaitingSharesFromCounterparty,
    
    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as "AccountBlocked".
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_VjSAY9p-Ed-ak6NoX_4Aeg_-912873576")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked,
    
    /// <summary>
    /// Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc.
    /// Encoded/decoded by serializers as "AwaitingSecurities".
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_VjSAZNp-Ed-ak6NoX_4Aeg_-911948803")]
    [Description(@"Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc.")]
    AwaitingSecurities,
    
    /// <summary>
    /// Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities.
    /// Encoded/decoded by serializers as "CounterpartyInsufficientSecurities".
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_VjSAZdp-Ed-ak6NoX_4Aeg_-838990050")]
    [Description(@"Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities.")]
    CounterpartyInsufficientSecurities,
    
    /// <summary>
    /// Awaiting documents or endorsements from the counterparty.
    /// Encoded/decoded by serializers as "AwaitingDocumentsOrEndorsementsFromCounterparty".
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_VjSAZtp-Ed-ak6NoX_4Aeg_-764186707")]
    [Description(@"Awaiting documents or endorsements from the counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty,
    
    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as "AwaitingDocumentsOrEndorsementsFromYou".
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_VjSAZ9p-Ed-ak6NoX_4Aeg_-512988206")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou,
    
    /// <summary>
    /// Pending reason is being investigated.
    /// Encoded/decoded by serializers as "StatusReasonInvestigation".
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_VjSAaNp-Ed-ak6NoX_4Aeg_-466811723")]
    [Description(@"Pending reason is being investigated.")]
    StatusReasonInvestigation,
    
    /// <summary>
    /// Insufficient deliverable securities in your account.
    /// Encoded/decoded by serializers as "LackOfSecurities".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_VjSAadp-Ed-ak6NoX_4Aeg_-426177626")]
    [Description(@"Insufficient deliverable securities in your account.")]
    LackOfSecurities,
    
    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as "PendingLinkedInstruction".
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_VjbKUNp-Ed-ak6NoX_4Aeg_-397547233")]
    [Description(@"Your instruction is pending settlement because the instruction linked to it is pending.")]
    PendingLinkedInstruction,
    
    /// <summary>
    /// Another settlement pending reason.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VjbKUdp-Ed-ak6NoX_4Aeg_-52149357")]
    [Description(@"Another settlement pending reason.")]
    Other,
    
    /// <summary>
    /// Physical shares have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as "PhysicalSecuritiesVerification".
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_VjbKUtp-Ed-ak6NoX_4Aeg_-40145471")]
    [Description(@"Physical shares have been received and are being checked for authenticity.")]
    PhysicalSecuritiesVerification,
    
    /// <summary>
    /// Settlement is physical and securities are being delivered.
    /// Encoded/decoded by serializers as "PhysicalDeliveryDelay".
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_VjbKU9p-Ed-ak6NoX_4Aeg_8803575")]
    [Description(@"Settlement is physical and securities are being delivered.")]
    PhysicalDeliveryDelay,
    
    /// <summary>
    /// Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment.
    /// Encoded/decoded by serializers as "SecuritiesBlocked".
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_VjbKVNp-Ed-ak6NoX_4Aeg_77141633")]
    [Description(@"Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment.")]
    SecuritiesBlocked,
    
    /// <summary>
    /// Information, for example, telephone number, contact person, is missing.
    /// Encoded/decoded by serializers as "MissingInformation".
    /// </summary>
    [EnumMember(Value = "MINF")]
    [IsoId("_VjbKVdp-Ed-ak6NoX_4Aeg_95611060")]
    [Description(@"Information, for example, telephone number, contact person, is missing.")]
    MissingInformation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingSettlementStatusReason1CodeMetadataExtensions
{
    private static readonly PendingSettlementStatusReason1CodeDropdownSource _dropdownSource = new PendingSettlementStatusReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingSettlementStatusReason1CodeDropdownRow GetMetadata(this PendingSettlementStatusReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


