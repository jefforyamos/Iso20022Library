﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VoteInstructionCode.  ISO2002 ID# _Y9bzEdp-Ed-ak6NoX_4Aeg_2072155739.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the possible types of voting instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y9bzEdp-Ed-ak6NoX_4Aeg_2072155739")]
[Description(@"Specifies the possible types of voting instructions.")]
[Derivations(typeof(VoteInstruction2Code),typeof(VoteInstruction1Code),typeof(VoteInstructionAtMeeting1Code),typeof(VoteInstruction3Code),typeof(VoteInstruction4Code))]
// External derivations that should be provided by the proper interface are: 
public enum VoteInstructionCode
{
    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as "CFOR".
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_Y9bzEtp-Ed-ak6NoX_4Aeg_1363718364")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For,
    
    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as "CAGS".
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_Y9bzE9p-Ed-ak6NoX_4Aeg_1366490757")]
    [Description(@"Vote against a meeting resolution.")]
    Against,
    
    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as "ABST".
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_Y9bzFNp-Ed-ak6NoX_4Aeg_1606604412")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain,
    
    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as "WTHH".
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_Y9bzFdp-Ed-ak6NoX_4Aeg_1610301180")]
    [Description(@"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).")]
    Withhold,
    
    /// <summary>
    /// Vote instruction is in line with the voting recommendations of the management.
    /// Encoded/decoded by serializers as "WMGT".
    /// </summary>
    [EnumMember(Value = "WMGT")]
    [IsoId("_Y9bzFtp-Ed-ak6NoX_4Aeg_1613993530")]
    [Description(@"Vote instruction is in line with the voting recommendations of the management.")]
    WithManagement,
    
    /// <summary>
    /// Vote instruction is in against the voting recommendations of the management.
    /// Encoded/decoded by serializers as "AMGT".
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_Y9bzF9p-Ed-ak6NoX_4Aeg_1623229081")]
    [Description(@"Vote instruction is in against the voting recommendations of the management.")]
    AgainstManagement,
    
    /// <summary>
    /// Voting party is assigned discretionary right to vote for one resolution.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_Y9bzGNp-Ed-ak6NoX_4Aeg_985657770")]
    [Description(@"Voting party is assigned discretionary right to vote for one resolution.")]
    Discretionary,
    
    /// <summary>
    /// Indicates a recommendation to take no action.
    /// Encoded/decoded by serializers as "NOAC".
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_Y9k9ANp-Ed-ak6NoX_4Aeg_580576107")]
    [Description(@"Indicates a recommendation to take no action.")]
    NoAction,
    
    /// <summary>
    /// Specifies that the rights holder gives authority to the chairman to vote on his behalf.
    /// Encoded/decoded by serializers as "CHRM".
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_Y9k9Adp-Ed-ak6NoX_4Aeg_1528124890")]
    [Description(@"Specifies that the rights holder gives authority to the chairman to vote on his behalf.")]
    Chairman,
    
    /// <summary>
    /// Vote in favour for one year for "say on pay" type of resolution.
    /// Encoded/decoded by serializers as "ONEY".
    /// </summary>
    [EnumMember(Value = "ONEY")]
    [IsoId("_PAnpsF69EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for one year for ""say on pay"" type of resolution.")]
    OneYear,
    
    /// <summary>
    /// Vote in favour for two years for "say on pay" type of resolution.
    /// Encoded/decoded by serializers as "TWOY".
    /// </summary>
    [EnumMember(Value = "TWOY")]
    [IsoId("_fxC58F69EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for two years for ""say on pay"" type of resolution.")]
    TwoYears,
    
    /// <summary>
    /// Vote in favour for three years for "say on pay" type of resolution.
    /// Encoded/decoded by serializers as "THRY".
    /// </summary>
    [EnumMember(Value = "THRY")]
    [IsoId("_kovosF69EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for three years for ""say on pay"" type of resolution.")]
    ThreeYears,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class VoteInstructionCodeMetadataExtensions
{
    private static readonly VoteInstructionCodeDropdownSource _dropdownSource = new VoteInstructionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVoteInstructionCodeDropdownRow GetMetadata(this VoteInstructionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


