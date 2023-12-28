﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUnableToApplyMissingData1Code.  ISO2002 ID# _p-vHsN4jEeqt1ZcLzWyWFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of an unable to apply due to missing data, as published in an external unable to apply missing data code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p-vHsN4jEeqt1ZcLzWyWFw")]
[Description(@"Specifies the reason of an unable to apply due to missing data, as published in an external unable to apply missing data code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUnableToApplyMissingDataCode))]
public enum ExternalUnableToApplyMissingData1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingRemittanceInformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uwqq8vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingRemittanceInformation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructionForNextAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uwqq9fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingInstructionForNextAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingDebtor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uwz04vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingDebtor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingDebtorAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uwz05fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingDebtorAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingDebtorAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uwz06PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingDebtorAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uwz06_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingSettlementAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uw9l4vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingSettlementAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingIntermediary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uw9l5fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingIntermediary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructingReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uw9l6PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingInstructingReimbursementAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructedReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uw9l6_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingInstructedReimbursementAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingThirdReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uxHW4vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingThirdReimbursementAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingCreditor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uxHW5fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingCreditor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingCreditorAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uxQg0vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingCreditorAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uxQg1fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingInstruction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingCreditorAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uxQg2PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingCreditorAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructionForCreditorAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uxQg2_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingInstructionForCreditorAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingInstructionForDebtorAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uxaR0vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingInstructionForDebtorAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingRelatedRemittanceInformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uxaR1fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    MissingRelatedRemittanceInformation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Narrative".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uxjbwvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Narrative,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUnableToApplyMissingData1CodeMetadataExtensions
{
    private static readonly ExternalUnableToApplyMissingData1CodeDropdownSource _dropdownSource = new ExternalUnableToApplyMissingData1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUnableToApplyMissingData1CodeDropdownRow GetMetadata(this ExternalUnableToApplyMissingData1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


