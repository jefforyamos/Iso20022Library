﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralProposalResponseCode.  ISO2002 ID# _YbwCVtp-Ed-ak6NoX_4Aeg_493369117.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the collateral proposal response is an initial or a counter proposal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbwCVtp-Ed-ak6NoX_4Aeg_493369117")]
[Description(@"Specifies if the collateral proposal response is an initial or a counter proposal.")]
[Derivations(typeof(CollateralProposalResponse1Code))]
public enum CollateralProposalResponseCode
{
    /// <summary>
    /// Indicates that the collateral proposal response is an initial proposal.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_YbwCV9p-Ed-ak6NoX_4Aeg_-605829047")]
    [Description(@"Indicates that the collateral proposal response is an initial proposal.")]
    InitialProposal,
    
    /// <summary>
    /// Indicates that the collateral proposal response is a counter proposal.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_YbwCWNp-Ed-ak6NoX_4Aeg_926407591")]
    [Description(@"Indicates that the collateral proposal response is a counter proposal.")]
    CounterProposal,
    
}
