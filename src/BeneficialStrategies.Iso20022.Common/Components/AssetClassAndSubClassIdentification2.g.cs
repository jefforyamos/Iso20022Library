﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AssetClassAndSubClassIdentification2.  ISO2002 ID# _b_iE8aaUEeqZmriXpMtonA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a non-equity asset-class and sub-class.
/// </summary>
[DataContract]
[XmlType]
public partial record AssetClassAndSubClassIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Asset class of non-equity instruments to which the result relates
    /// </summary>
    [DataMember]
    public required NonEquityAssetClass1Code AssetClass { get; init; } 
    /// <summary>
    /// Sub class of non-equity instruments to which the result relates, as defined in the local regulation.
    /// </summary>
    [DataMember]
    public NonEquitySubClass1? DerivativeSubClass { get; init; } 
    /// <summary>
    /// Identification of non-equity financial instruments.
    /// </summary>
    [DataMember]
    public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
    
    #nullable disable
}
