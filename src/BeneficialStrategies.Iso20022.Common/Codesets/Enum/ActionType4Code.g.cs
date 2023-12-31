﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionType4Code.  ISO2002 ID# _jaoKQHsNEeSR68OJvMfxJQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Recommended action for the issuer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jaoKQHsNEeSR68OJvMfxJQ")]
[Description(@"Recommended action for the issuer.")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType4Code
{
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as "CaptureCard".
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_886RsXsNEeSR68OJvMfxJQ")]
    [Description(@"Capture the card.")]
    CaptureCard,
    
    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as "IdentificationRequired".
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_-W7YoXsNEeSR68OJvMfxJQ")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired,
    
    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as "Referral".
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_-k7_cXsNEeSR68OJvMfxJQ")]
    [Description(@"Referral has to be performed.")]
    Referral,
    
    /// <summary>
    /// Approve the transaction.
    /// Encoded/decoded by serializers as "Approve".
    /// </summary>
    [EnumMember(Value = "APPV")]
    [IsoId("_S_kQQS6qEeWc7f-D6ByqMg")]
    [Description(@"Approve the transaction.")]
    Approve,
    
    /// <summary>
    /// Block the card.
    /// Encoded/decoded by serializers as "BlockCard".
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_TcMh4S6qEeWc7f-D6ByqMg")]
    [Description(@"Block the card.")]
    BlockCard,
    
    /// <summary>
    /// No reason for declining the transaction.
    /// Encoded/decoded by serializers as "NoReasonForDecline".
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_UMkO4S6qEeWc7f-D6ByqMg")]
    [Description(@"No reason for declining the transaction.")]
    NoReasonForDecline,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ActionType4CodeMetadataExtensions
{
    private static readonly ActionType4CodeDropdownSource _dropdownSource = new ActionType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IActionType4CodeDropdownRow GetMetadata(this ActionType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


