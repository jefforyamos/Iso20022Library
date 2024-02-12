﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionType8Code.  ISO2002 ID# _EsxP4ErCEeenp6hmNprBHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Recommended action for the card issuer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EsxP4ErCEeenp6hmNprBHg")]
[Description(@"Recommended action for the card issuer.")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType8Code
{
    /// <summary>
    /// Approve the transaction.
    /// Encoded/decoded by serializers as "APPV".
    /// </summary>
    [EnumMember(Value = "APPV")]
    [IsoId("_MHVkAUrCEeenp6hmNprBHg")]
    [Description(@"Approve the transaction.")]
    Approve = ActionTypeCode.Approve, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Block the card.
    /// Encoded/decoded by serializers as "BLCK".
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_M_48okrCEeenp6hmNprBHg")]
    [Description(@"Block the card.")]
    BlockCard = ActionTypeCode.BlockCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as "CPTR".
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_NkoockrCEeenp6hmNprBHg")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Decline the transaction.
    /// Encoded/decoded by serializers as "DCLN".
    /// </summary>
    [EnumMember(Value = "DCLN")]
    [IsoId("_OFsHEkrCEeenp6hmNprBHg")]
    [Description(@"Decline the transaction.")]
    Decline = ActionTypeCode.Decline, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as "RQID".
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_Orj0QkrCEeenp6hmNprBHg")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No reason for declining the transaction.
    /// Encoded/decoded by serializers as "NDCL".
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_PjFSIkrCEeenp6hmNprBHg")]
    [Description(@"No reason for declining the transaction.")]
    NoReasonForDecline = ActionTypeCode.NoReasonForDecline, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as "RFRL".
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_QmCj8krCEeenp6hmNprBHg")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other action defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_RLezUkrCEeenp6hmNprBHg")]
    [Description(@"Other action defined at national level.")]
    OtherNational = ActionTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other action defined at private level
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_RWsk0krCEeenp6hmNprBHg")]
    [Description(@"Other action defined at private level")]
    OtherPrivate = ActionTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Further authentication required (e.g. one-time password)
    /// Encoded/decoded by serializers as "STUA".
    /// </summary>
    [EnumMember(Value = "STUA")]
    [IsoId("_3eqrceChEee9RadpHmUgYw")]
    [Description(@"Further authentication required (e.g. one-time password)")]
    StepUpAuthentication = ActionTypeCode.StepUpAuthentication, // same ordinal as derivation source for type conversions
    
}
