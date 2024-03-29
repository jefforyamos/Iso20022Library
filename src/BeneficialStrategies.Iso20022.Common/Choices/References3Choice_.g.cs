﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References3Choice.  ISO2002 ID# _USqtF9p-Ed-ak6NoX_4Aeg_1744760474.
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
    [KnownType(typeof(References3Choice.SecuritiesSettlementTransactionConfirmationIdentification))]
    [KnownType(typeof(References3Choice.IntraPositionMovementConfirmationIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesBalanceAccountingReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesBalanceCustodyReportIdentification))]
    [KnownType(typeof(References3Choice.IntraPositionMovementPostingReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesFinancingConfirmationIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesTransactionPendingReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesTransactionPostingReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesSettlementTransactionAllegementReportIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification))]
    [KnownType(typeof(References3Choice.PortfolioTransferNotificationIdentification))]
    [KnownType(typeof(References3Choice.SecuritiesSettlementTransactionGenerationNotificationIdentification))]
    [KnownType(typeof(References3Choice.OtherMessageIdentification))]
    [IsoId("_USqtF9p-Ed-ak6NoX_4Aeg_1744760474")]
    [DisplayName("References 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References3Choice_
    #else
    public abstract partial class References3Choice_
    #endif
    {
    }
}
