﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amendment10.  ISO2002 ID# _EmVXet3pEeieV46qhAnbyQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the Amendment message.
/// </summary>
public partial record Amendment10
{
    #nullable enable
    
    /// <summary>
    /// Contains or describes the information pertaining to the actors interacting with the transaction.
    /// </summary>
    public required Environment3 Environment { get; init; } 
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    public Context6? Context { get; init; } 
    /// <summary>
    /// Transaction details of the amendment message.
    /// </summary>
    public required Transaction102 Transaction { get; init; } 
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    public ProtectedData1? ProtectedData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
