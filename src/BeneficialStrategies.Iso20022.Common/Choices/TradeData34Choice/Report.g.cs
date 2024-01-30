﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _ArgEc8K3EeuFNp8LZAnorg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TradeData34Choice;

/// <summary>
/// Information concerning the reporting at transaction level.
/// </summary>
public partial record Report : ITradeData34Choice
{
    #nullable enable
    /// <summary>
    /// Status of the required transactions reconciliation or pairing.
    /// </summary>
    public NumberOfReportsPerStatus4? PairingReconciliationStatus { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data on transaction requiring reconciliation or pairing. 
    /// </summary>
    public ReconciliationReport8? ReconciliationReport { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
