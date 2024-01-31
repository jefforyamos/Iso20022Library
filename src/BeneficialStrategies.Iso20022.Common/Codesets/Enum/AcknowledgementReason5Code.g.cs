﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AcknowledgementReason5Code.  ISO2002 ID# _bpPSBdp-Ed-ak6NoX_4Aeg_-775300363.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bpPSBdp-Ed-ak6NoX_4Aeg_-775300363")]
[Description(@"Specifies additional information about the processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
public enum AcknowledgementReason5Code
{
    /// <summary>
    /// Received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_bpPSBtp-Ed-ak6NoX_4Aeg_-27223806")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = AcknowledgementReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is accepted but does not comply with the market practice rule published for the concerned market or process.
    /// Encoded/decoded by serializers as "SMPG".
    /// </summary>
    [EnumMember(Value = "SMPG")]
    [IsoId("_bpPSB9p-Ed-ak6NoX_4Aeg_1110394808")]
    [Description(@"Instruction is accepted but does not comply with the market practice rule published for the concerned market or process.")]
    MarketPracticeRuleDiscrepency = AcknowledgementReasonCode.MarketPracticeRuleDiscrepency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bpPSCNp-Ed-ak6NoX_4Aeg_180042807")]
    [Description(@"Other. See Narrative.")]
    Other = AcknowledgementReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as "CDCY".
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_bpZDANp-Ed-ak6NoX_4Aeg_1232765698")]
    [Description(@"Execution is conditional to the execution of a process linked to the currency of the transaction.")]
    ConditionalCurrency = AcknowledgementReasonCode.ConditionalCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as "CDRG".
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_bpZDAdp-Ed-ak6NoX_4Aeg_1991941032")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar = AcknowledgementReasonCode.ConditionalRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as "CDRE".
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_bpZDAtp-Ed-ak6NoX_4Aeg_148072043")]
    [Description(@"Execution is conditional to the execution of a process of realignment at the issuer CSD.")]
    ConditionalRealignement = AcknowledgementReasonCode.ConditionalRealignement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually.
    /// Encoded/decoded by serializers as "NSTP".
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_bpZDA9p-Ed-ak6NoX_4Aeg_-780265528")]
    [Description(@"Instruction was not straight through processing and had to be processed manually.")]
    NotStraightThroughProcessing = AcknowledgementReasonCode.NotStraightThroughProcessing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction registration is accepted but the registration is not in full, that is, not with voting rights.
    /// Encoded/decoded by serializers as "RQWV".
    /// </summary>
    [EnumMember(Value = "RQWV")]
    [IsoId("_bpZDBNp-Ed-ak6NoX_4Aeg_865001907")]
    [Description(@"Instruction registration is accepted but the registration is not in full, that is, not with voting rights.")]
    AcceptedWithoutVotingRights = AcknowledgementReasonCode.AcceptedWithoutVotingRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_bpZDBdp-Ed-ak6NoX_4Aeg_-1891176947")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = AcknowledgementReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AcknowledgementReason5CodeMetadataExtensions
{
    private static readonly AcknowledgementReason5CodeDropdownSource _dropdownSource = new AcknowledgementReason5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAcknowledgementReason5CodeDropdownRow GetMetadata(this AcknowledgementReason5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


