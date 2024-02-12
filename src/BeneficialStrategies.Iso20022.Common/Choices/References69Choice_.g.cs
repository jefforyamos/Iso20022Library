﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References69Choice.  ISO2002 ID# _zwc0sQzXEeuUZuaHWzkTew.
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
    [KnownType(typeof(References69Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [KnownType(typeof(References69Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References69Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [KnownType(typeof(References69Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(typeof(References69Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [KnownType(typeof(References69Choice.OtherMessageIdentification))]
    [KnownType(typeof(References69Choice.TotalPortfolioValuationReportIdentification))]
    [KnownType(typeof(References69Choice.TripartyCollateralTransactionInstructionProcessingStatusAdviceIdentification))]
    [KnownType(typeof(References69Choice.TripartyCollateralStatusAdviceIdentification))]
    [KnownType(typeof(References69Choice.TripartyCollateralAndExposureReportIdentification))]
    [IsoId("_zwc0sQzXEeuUZuaHWzkTew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("References 69 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References69Choice_
    #else
    public abstract partial class References69Choice_
    #endif
    {
    }
}
