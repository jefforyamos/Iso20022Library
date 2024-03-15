﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CollateralProposalResponse2Choice.  ISO2002 ID# _vOOvQWTUEeSSTJlMfOKFsA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralProposalResponse2Choice.CollateralProposal))]
    [KnownType(typeof(CollateralProposalResponse2Choice.SegregatedIndependentAmount))]
    [IsoId("_vOOvQWTUEeSSTJlMfOKFsA")]
    [DisplayName("Collateral Proposal Response 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralProposalResponse2Choice_
    #else
    public abstract partial class CollateralProposalResponse2Choice_
    #endif
    {
    }
}
