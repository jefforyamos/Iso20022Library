﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ValidationRuleCode.  ISO2002 ID# _pQycwB8_EeuaqdhZaJ3GHw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies all codes that are to be used in the formal validation rules.
/// 
/// Usage: those codes must not be used in message definitions, as the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pQycwB8_EeuaqdhZaJ3GHw")]
[Description(@"Specifies all codes that are to be used in the formal validation rules.  Usage: those codes must not be used in message definitions, as the code set is used when the formal validation rules make reference of an external code sets.")]
[Derivations(typeof(ValidationRuleStatus1Code),typeof(ValidationRuleInstruction1Code),typeof(ValidationRulePayCreditorByCheque1Code),typeof(ValidationRuleStatus3Code),typeof(ValidationRuleReceived1Code),typeof(ValidationRuleRejected1Code),typeof(ValidationRuleNarrative1Code),typeof(ValidationRuleStatus2Code),typeof(ValidationRulePending1Code),typeof(ValidationRuleConfirmation1Code),typeof(ValidationRuleAnyBank1Code),typeof(ValidationRuleSpecifiedAddress1Code),typeof(ValidationRuleIssuanceType1Code),typeof(ValidationRuleCreditSettlement1Code),typeof(ValidationRuleSettlementInProcess1Code),typeof(ValidationRulePendingAndRejected1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ValidationRuleCode
{
    /// <summary>
    /// Accepted cancellation request.
    /// Encoded/decoded by serializers as "ACCR".
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_h-RVMh-yEeuxStysDTgLiw")]
    [Description(@"Accepted cancellation request.")]
    AcceptedCancellationRequest,
    
    /// <summary>
    /// Accepted customer profile.
    /// Encoded/decoded by serializers as "ACCP".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_h-RVNB-yEeuxStysDTgLiw")]
    [Description(@"Accepted customer profile.")]
    AcceptedCustomerProfile,
    
    /// <summary>
    /// Accepted settlement completed.
    /// Encoded/decoded by serializers as "ACSC".
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_h-RVNR-yEeuxStysDTgLiw")]
    [Description(@"Accepted settlement completed.")]
    AcceptedSettlementCompleted,
    
    /// <summary>
    /// Accepted settlement in process.
    /// Encoded/decoded by serializers as "ACSP".
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_h-RVNh-yEeuxStysDTgLiw")]
    [Description(@"Accepted settlement in process.")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// Accepted technical validation.
    /// Encoded/decoded by serializers as "ACTC".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_h-RVNx-yEeuxStysDTgLiw")]
    [Description(@"Accepted technical validation.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Accepted with change.
    /// Encoded/decoded by serializers as "ACWC".
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_h-RVOB-yEeuxStysDTgLiw")]
    [Description(@"Accepted with change.")]
    AcceptedWithChange,
    
    /// <summary>
    /// Pending.
    /// Encoded/decoded by serializers as "PDNG".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_h-RVPR-yEeuxStysDTgLiw")]
    [Description(@"Pending.")]
    Pending,
    
    /// <summary>
    /// Received.
    /// Encoded/decoded by serializers as "RCVD".
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_h-RVPx-yEeuxStysDTgLiw")]
    [Description(@"Received.")]
    Received,
    
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_h-RVQB-yEeuxStysDTgLiw")]
    [Description(@"Rejected.")]
    Rejected,
    
    /// <summary>
    /// Narrative.
    /// Encoded/decoded by serializers as "NARR".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_9DoG8B-0EeuxStysDTgLiw")]
    [Description(@"Narrative.")]
    Narrative,
    
    /// <summary>
    /// Pay creditor by cheque.
    /// Encoded/decoded by serializers as "CHQB".
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_WWUTMR-1EeuxStysDTgLiw")]
    [Description(@"Pay creditor by cheque.")]
    PayCreditorByCheque,
    
    /// <summary>
    /// Hold cash for creditor.
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_jz9loyAZEeuxStysDTgLiw")]
    [Description(@"Hold cash for creditor.")]
    HoldCashForCreditor,
    
    /// <summary>
    /// Phone beneficiary.
    /// Encoded/decoded by serializers as "PHOB".
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_jz9lpSAZEeuxStysDTgLiw")]
    [Description(@"Phone beneficiary.")]
    PhoneBeneficiary,
    
    /// <summary>
    /// Telecom beneficiary.
    /// Encoded/decoded by serializers as "TELB".
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_prFKASAZEeuxStysDTgLiw")]
    [Description(@"Telecom beneficiary.")]
    Telecom,
    
    /// <summary>
    /// Specified address.
    /// Encoded/decoded by serializers as "SPEC".
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_ohocwCBoEeugLNJneiyzbA")]
    [Description(@"Specified address.")]
    SpecifiedAddress,
    
    /// <summary>
    /// Any bank.
    /// Encoded/decoded by serializers as "ANYB".
    /// </summary>
    [EnumMember(Value = "ANYB")]
    [IsoId("_oraD0CBoEeugLNJneiyzbA")]
    [Description(@"Any bank.")]
    AnyBank,
    
    /// <summary>
    /// Confirmation party in trade.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_ow4ZsCBoEeugLNJneiyzbA")]
    [Description(@"Confirmation party in trade.")]
    Confirmation,
    
    /// <summary>
    /// Undertaking issued direct.
    /// Encoded/decoded by serializers as "ISSU".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_h0ouYyBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued direct.")]
    UndertakingIssuedDirect,
    
    /// <summary>
    /// Undertaking issued via confirming party.
    /// Encoded/decoded by serializers as "ISCO".
    /// </summary>
    [EnumMember(Value = "ISCO")]
    [IsoId("_h0ouZCBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued via confirming party.")]
    UndertakingIssuedViaConfirmingParty,
    
    /// <summary>
    /// Undertaking issued via advising party.
    /// Encoded/decoded by serializers as "ISAD".
    /// </summary>
    [EnumMember(Value = "ISAD")]
    [IsoId("_h0ouZSBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued via advising party.")]
    UndertakingViaAdvisingParty,
    
    /// <summary>
    /// AcceptedCreditSettlementCompleted
    /// Encoded/decoded by serializers as "ACCC".
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_aAh30CE5EeuIZ4Hf6difAw")]
    [Description(@"AcceptedCreditSettlementCompleted")]
    AcceptedCreditSettlementCompleted,
    
    /// <summary>
    /// Request for Cancellation has been forwarded to the payment processing/last payment processing agent.
    /// Encoded/decoded by serializers as "S003".
    /// </summary>
    [EnumMember(Value = "S003")]
    [IsoId("_TXXz0H-0Ee27G9oJfa4a8Q")]
    [Description(@"Request for Cancellation has been forwarded to the payment processing/last payment processing agent.")]
    RequestForCancellationForwarded,
    
    /// <summary>
    /// Request for Cancellation has been acknowledged as delivered to payment processing/last payment processing agent.
    /// Encoded/decoded by serializers as "S004".
    /// </summary>
    [EnumMember(Value = "S004")]
    [IsoId("_lDCkUH-0Ee27G9oJfa4a8Q")]
    [Description(@"Request for Cancellation has been acknowledged as delivered to payment processing/last payment processing agent.")]
    RequestForCancellationDeliveryAcknowledgement,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ValidationRuleCodeMetadataExtensions
{
    private static readonly ValidationRuleCodeDropdownSource _dropdownSource = new ValidationRuleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IValidationRuleCodeDropdownRow GetMetadata(this ValidationRuleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


