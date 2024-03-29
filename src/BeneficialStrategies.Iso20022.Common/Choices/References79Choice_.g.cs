﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References79Choice.  ISO2002 ID# _WVQM4UfGEey6Is2iMqV8fg.
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
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References79Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [KnownType(typeof(References79Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References79Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [KnownType(typeof(References79Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(typeof(References79Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [KnownType(typeof(References79Choice.OtherMessageIdentification))]
    [KnownType(typeof(References79Choice.TotalPortfolioValuationReportIdentification))]
    [KnownType(typeof(References79Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification))]
    [KnownType(typeof(References79Choice.TripartyCollateralStatusAdviceIdentification))]
    [KnownType(typeof(References79Choice.TripartyCollateralAndExposureReportIdentification))]
    [IsoId("_WVQM4UfGEey6Is2iMqV8fg")]
    [DisplayName("References 79 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References79Choice_
    #else
    public abstract partial class References79Choice_
    #endif
    {
    }
}
