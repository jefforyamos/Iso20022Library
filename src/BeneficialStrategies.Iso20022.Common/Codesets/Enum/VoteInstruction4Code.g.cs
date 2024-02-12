﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VoteInstruction4Code.  ISO2002 ID# _rC5MMF6-EeSjaerr_EM7AQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the possible types of voting instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rC5MMF6-EeSjaerr_EM7AQ")]
[Description(@"Specifies the possible types of voting instructions.")]
[DerivedFrom(typeof(VoteInstructionCode))]
public enum VoteInstruction4Code
{
    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as "ABST".
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_uEKk0V6-EeSjaerr_EM7AQ")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain = VoteInstructionCode.Abstain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as "CAGS".
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_uU03AV6-EeSjaerr_EM7AQ")]
    [Description(@"Vote against a meeting resolution.")]
    Against = VoteInstructionCode.Against, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote instruction is in against the voting recommendations of the management.
    /// Encoded/decoded by serializers as "AMGT".
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_uq2KUV6-EeSjaerr_EM7AQ")]
    [Description(@"Vote instruction is in against the voting recommendations of the management.")]
    AgainstManagement = VoteInstructionCode.AgainstManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the rights holder gives authority to the chairman to vote on his behalf.
    /// Encoded/decoded by serializers as "CHRM".
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_vFVG4V6-EeSjaerr_EM7AQ")]
    [Description(@"Specifies that the rights holder gives authority to the chairman to vote on his behalf.")]
    Chairman = VoteInstructionCode.Chairman, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as "CFOR".
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_vswTQV6-EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For = VoteInstructionCode.For, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a recommendation to take no action.
    /// Encoded/decoded by serializers as "NOAC".
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_wGfo8V6-EeSjaerr_EM7AQ")]
    [Description(@"Indicates a recommendation to take no action.")]
    NoAction = VoteInstructionCode.NoAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as "WTHH".
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_wffXwV6-EeSjaerr_EM7AQ")]
    [Description(@"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).")]
    Withhold = VoteInstructionCode.Withhold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote instruction is in line with the voting recommendations of the management.
    /// Encoded/decoded by serializers as "WMGT".
    /// </summary>
    [EnumMember(Value = "WMGT")]
    [IsoId("_wrGK0V6-EeSjaerr_EM7AQ")]
    [Description(@"Vote instruction is in line with the voting recommendations of the management.")]
    WithManagement = VoteInstructionCode.WithManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote in favour for two years for "say on pay" type of resolution.
    /// Encoded/decoded by serializers as "TWOY".
    /// </summary>
    [EnumMember(Value = "TWOY")]
    [IsoId("_w3vfsV6-EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for two years for ""say on pay"" type of resolution.")]
    TwoYears = VoteInstructionCode.TwoYears, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote in favour for three years for "say on pay" type of resolution.
    /// Encoded/decoded by serializers as "THRY".
    /// </summary>
    [EnumMember(Value = "THRY")]
    [IsoId("_w9F5wV6-EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for three years for ""say on pay"" type of resolution.")]
    ThreeYears = VoteInstructionCode.ThreeYears, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote in favour for one year for "say on pay" type of resolution.
    /// Encoded/decoded by serializers as "ONEY".
    /// </summary>
    [EnumMember(Value = "ONEY")]
    [IsoId("_xCTw8V6-EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for one year for ""say on pay"" type of resolution.")]
    OneYear = VoteInstructionCode.OneYear, // same ordinal as derivation source for type conversions
    
}
