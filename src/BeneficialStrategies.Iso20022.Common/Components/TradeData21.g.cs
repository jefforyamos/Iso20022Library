﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeData21.  ISO2002 ID# _CpO6Zf_oEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reported trade transactions.
/// </summary>
public partial record TradeData21
{
    #nullable enable
    
    /// <summary>
    /// Status of the required transactions reconciliation or pairing.
    /// </summary>
    public NumberOfReportsPerStatus2? PairingReconciliationStatus { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data on transaction requiring reconciliation or pairing. 
    /// </summary>
    public ReconciliationReport5? ReconciliationReport { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
